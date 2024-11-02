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

namespace Clarity.Forms
{
    public partial class TaskExecutor : Form
    {
        private string text;
        private DateTime endTime;
        private string selectedItem;
        private TimeSpan timeRemaining;

        private List<TimeSpan> countdownSpans;
        private int currentSpanIndex;
        private string originalHostsContent;
        private string hostFilePath = @"C:\WINDOWS\system32\drivers\etc\hosts";

        private List<string> blockedLinks;
        private int workTime;
        private int restTime;

        // INITIALIZATIONS

        public TaskExecutor(string _text, DateTime _endTime, string _selectedItem)
        {
            InitializeComponent();
            text = _text;
            endTime = _endTime;
            selectedItem = _selectedItem;

            var database = new DatabaseManager();
            (blockedLinks, workTime, restTime) = database.GetConfiguration();

            this.FormClosing += TaskExecutor_FormClosing;
            if (File.Exists(hostFilePath))
            {
                originalHostsContent = File.ReadAllText(hostFilePath);
            }
        }

        private void TaskExecutor_Load(object sender, EventArgs e)
        {
            if (selectedItem == "UltraFocus")
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (selectedItem == "Focus")
            {
                FlushDns();

                for (int i = 0; i < blockedLinks.Count; i++)
                {
                    BlockWebsite(blockedLinks[i]);
                }
            }

            countdownSpans = GenerateTimeSpans(endTime);

            currentSpanIndex = 0;
            StartNextSpan();

            label3.Text = text;
            label5.Text = restTime.ToString() + ":00";
            label1.Text = workTime.ToString() + ":00";
            label7.Text = "Ending time: " + endTime.ToString();

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

        public void BlockWebsite(string url)
        {
            List<string> blocklist = new List<string>();
            blocklist.Add("127.0.0.1 " + url);
            File.AppendAllLines(hostFilePath, blocklist);
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
                }
                else if (currentSpanIndex % 2 != 0)
                {
                    label2.Text = "Rest time";
                    label5.Text = workTime.ToString() + ":00";
                    label4.Text = "Work time";
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

        private void exit()
        {
            Form1.AppState.ClosingPermit = true;
            if (selectedItem == "UltraFocus")
            {
                this.Close();
                Application.Restart();
            }
            else if (selectedItem == "Focus")
            {
                Application.Restart();
            }
        }

        public void TaskExecutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(hostFilePath, originalHostsContent ?? string.Empty);

            if (selectedItem == "UltraFocus" && Form1.AppState.ClosingPermit == false)
            {
                e.Cancel = true;
            }
        }
    }
}