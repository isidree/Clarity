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

namespace Clarity.Forms
{
    public partial class TaskExecutor : Form
    {
        private string text;
        private DateTime endTime;
        private string selectedItem;
        private int sessionId;
        private TimeSpan timeRemaining;

        private List<TimeSpan> countdownSpans;
        private int currentSpanIndex;
        private string originalHostsContent;
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
            var database = new DatabaseManager();
            (blockedLinks, workTime, restTime) = database.GetConfiguration();

            // Handle form closure
            this.FormClosing += TaskExecutor_FormClosing;
            if (File.Exists(hostFilePath))
            {
                originalHostsContent = File.ReadAllText(hostFilePath);
            }

            // Shape the buttons to round form
            var rndsh = new RoundShaper();
            rndsh.RoundButton(fast_task_btn);
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
            label5.Text = restTime.ToString() + ":00";
            label1.Text = workTime.ToString() + ":00";
            label7.Text = "Ending time: " + endTime.ToString(@"dd/MM/yyyy HH:mm");

            if (currentSpanIndex == countdownSpans.Count - 1)
            {
                label5.Text = "00:00";
                label4.Text = "Ending";
            }
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

        public void BlockWebsites()
        {
            FlushDns();
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
            if (currentSpanIndex >= countdownSpans.Count)
            {
                timer1.Stop();
                exit();
                return;
            }

            timeRemaining = countdownSpans[currentSpanIndex];
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
                    label5.Text = restTime.ToString() + ":00";
                    label4.Text = "Rest time";

                    if (selectedItem == "Focus")
                    {
                        BlockWebsites();
                        MessageBox.Show("Work time: the pages have been blocked.");
                    }
                    else if (selectedItem == "UltraFocus")
                    {
                        BlockComputer();
                        MessageBox.Show("Work time: the computer has been blocked.");
                    }
                    
                }
                else if (currentSpanIndex % 2 != 0)
                {
                    label2.Text = "Rest time";
                    label5.Text = workTime.ToString() + ":00";
                    label4.Text = "Work time";

                    if (selectedItem == "Focus")
                    {
                        UnblockWebsites();
                        MessageBox.Show("Rest time: the blocked pages are temporarily unblocked.");
                    }
                    else if (selectedItem == "UltraFocus")
                    {
                        UnblockComputer();
                        MessageBox.Show("Rest time: the computer is temporarily unblocked.");
                    }
                }

                if (currentSpanIndex == countdownSpans.Count - 1)
                {
                    label5.Text = "00:00";
                    label4.Text = "Ending";
                }
            }
        }

        // FORM CLOSURE

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit? It is highly advised not to stop while you still have to finish your tasks.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                exit();
            }
            else
            {
                MessageBox.Show("I'm glad you stayed. Keep working hard, you're almost there!");
            }
        }

        private void removePossibleScheduledTask()
        {
            if (sessionId != 0)
            {
                var database = new DatabaseManager();
                database.DeleteStudySession(sessionId);
            }
        }

        private void exit()
        {
            Form1.AppState.ClosingPermit = true;
            Application.Restart();
        }

        public void TaskExecutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnblockWebsites();
            removePossibleScheduledTask();

            if (selectedItem == "UltraFocus" && Form1.AppState.ClosingPermit == false)
            {
                e.Cancel = true;
            }
        }
    }
}