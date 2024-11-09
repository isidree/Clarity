using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Security.Principal;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Media;
using Clarity.Utilities;

namespace Clarity.Forms
{
    public partial class TaskExecutor : Form
    {
        private string text;
        private DateTime endTime;
        private string selectedItem;
        private int sessionId;
        private TimeSpan timeRemaining;

        private List<TimeSpan>? countdownSpans;
        private int currentSpanIndex;
        private string? originalHostsContent;
        private string hostFilePath = @"C:\WINDOWS\system32\drivers\etc\hosts";

        private List<string> blockedLinks;
        private int workTime;
        private int restTime;

        // INITIALIZATIONS

        public TaskExecutor(string _text, DateTime _endTime, string _selectedItem, int _sessionId)
        {
            InitializeComponent();

            // Retrieve data obtained from session
            text = _text;
            endTime = _endTime;
            selectedItem = _selectedItem;
            sessionId = _sessionId;

            // Retrieve data from configuration db
            var database = new Utilities.DatabaseManager();
            (blockedLinks, workTime, restTime, _, _) = database.GetConfiguration();

            // Handle form closure
            if (File.Exists(hostFilePath))
            {
                originalHostsContent = File.ReadAllText(hostFilePath);
            }

            // Shape the buttons to round form
            var rndsh = new Utilities.RoundShaper();
            rndsh.RoundControl(fast_task_btn);
        }

        private void TaskExecutor_Load(object sender, EventArgs e)
        {
            if (selectedItem == "UltraFocus")
            {
                BlockComputer();
            }
            else if (selectedItem == "Focus")
            {
                BlockWebsites();
            }

            countdownSpans = GenerateTimeSpans(endTime);

            currentSpanIndex = 0;
            StartNextSpan();

            label3.Text = text;
            label5.Text = restTime < 10 ? "0" + restTime.ToString() + ":00" : restTime.ToString() + ":00";
            label1.Text = workTime < 10 ? "0" + workTime.ToString() + ":00" : workTime.ToString() + ":00";
            label7.Text = "Ending time: " + endTime.ToString(@"dd/MM/yyyy HH:mm");

            if (currentSpanIndex == countdownSpans.Count - 1)
            {
                label5.Text = "00:00";
                label4.Text = "Ending";
            }

            SoundPlayer player = new SoundPlayer(Properties.Resources.work);
            player.Play();
        }
        private void FlushDns()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c ipconfig /flushdns";
                process.StartInfo.Verb = "runas";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearEdgeCache()
        {
            // Check if Edge is installed
            string edgeCachePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Microsoft\\Edge\\User Data\\Default\\Cache"
            );

            if (Directory.Exists(edgeCachePath))
            {
                try
                {
                    // Ensure Edge is closed
                    Process[] edgeInstances = Process.GetProcessesByName("msedge");
                    foreach (var instance in edgeInstances)
                    {
                        instance.Kill();
                    }

                    // Clear cache
                    Directory.Delete(edgeCachePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error clearing Edge cache: {ex.Message}", "Error");
                }
            }
        }

        public void BlockWebsites()
        {
            FlushDns();
            //ClearEdgeCache();
            for (int i = 0; i < blockedLinks.Count; i++)
            {
                if (!(blockedLinks[i] == ""))
                {
                    List<string> blocklist = new List<string>();
                    blocklist.Add("127.0.0.1 " + blockedLinks[i]);
                    File.AppendAllLines(hostFilePath, blocklist);
                }
            }
        }

        public void UnblockWebsites()
        {
            File.WriteAllText(hostFilePath, originalHostsContent ?? string.Empty);
        }

        public void BlockComputer()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public void UnblockComputer()
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        // TIME MANAGEMENT

        private List<TimeSpan> GenerateTimeSpans(DateTime end)
        {
            List<TimeSpan> spans = new List<TimeSpan>();
            TimeSpan intervalWork = TimeSpan.FromMinutes(workTime);
            TimeSpan intervalRest = TimeSpan.FromMinutes(restTime);
            bool isWorkSpan = true;

            DateTime current = DateTime.Now;
            while (current < end)
            {
                TimeSpan interval = isWorkSpan ? intervalWork : intervalRest;
                DateTime nextSpanEnd = current + interval;

                if (nextSpanEnd > end)
                {
                    nextSpanEnd = end;
                }

                spans.Add(nextSpanEnd - current);
                current = nextSpanEnd;
                isWorkSpan = !isWorkSpan;
            }

            return spans;
        }

        private void StartNextSpan()
        {
            if (currentSpanIndex >= countdownSpans?.Count)
            {
                timer1.Stop();
                exit();
                return;
            }

            timeRemaining = countdownSpans?[currentSpanIndex] ?? TimeSpan.Zero;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining = timeRemaining.Subtract(TimeSpan.FromSeconds(1));

            label1.Text = timeRemaining.ToString(@"mm\:ss");

            if (timeRemaining <= TimeSpan.Zero)
            {
                timer1.Stop();
                currentSpanIndex++;
                StartNextSpan();

                if (currentSpanIndex % 2 == 0)
                {
                    label2.Text = "Work time";
                    label5.Text = restTime < 10 ? "0" + restTime.ToString() + ":00" : restTime.ToString() + ":00";
                    label4.Text = "Rest time";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.work);
                    player.Play();

                    if (selectedItem == "Focus")
                    {
                        BlockWebsites();
                        MessageBox.Show("Work time: the pages have been blocked.", "Information");
                    }
                    else if (selectedItem == "UltraFocus")
                    {
                        BlockComputer();
                        MessageBox.Show("Work time: the computer has been blocked.", "Information");
                    }
                    
                }
                else if (currentSpanIndex % 2 != 0)
                {
                    label2.Text = "Rest time";
                    label5.Text = workTime < 10 ? "0" + workTime.ToString() + ":00" : workTime.ToString() + ":00";
                    label4.Text = "Work time";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.rest);
                    player.Play();

                    if (selectedItem == "Focus")
                    {
                        UnblockWebsites();
                        MessageBox.Show("Rest time: the blocked pages are temporarily unblocked.", "Information");
                    }
                    else if (selectedItem == "UltraFocus")
                    {
                        UnblockComputer();
                        MessageBox.Show("Rest time: the computer is temporarily unblocked.", "Information");
                    }
                }

                if (currentSpanIndex == countdownSpans?.Count - 1)
                {
                    label5.Text = "00:00";
                    label4.Text = "Ending";
                }
            }
        }

        // FORM CLOSURE

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            new InputDialog().VerifyPassword(() =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit? It is highly advised not to stop while you still have to finish your tasks.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    exit();
                }
            });
        }

        private void removePossibleScheduledTask()
        {
            if (sessionId != 0)
            {
                var database = new Utilities.DatabaseManager();
                database.DeleteStudySession(sessionId);
            }
        }

        private void exit()
        {
            MainForm.AppState.ClosingPermit = true;
            Application.Restart();
        }
        
        public void TaskExecutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnblockWebsites();
            removePossibleScheduledTask();

            if (selectedItem == "UltraFocus" && MainForm.AppState.ClosingPermit == false)
            {
                e.Cancel = true;
            }
        }
    }
}