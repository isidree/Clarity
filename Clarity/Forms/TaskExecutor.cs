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

        public TaskExecutor(string _text, DateTime _endTime, string _selectedItem)
        {
            InitializeComponent();
            text = _text;
            endTime = _endTime;
            selectedItem = _selectedItem;

            this.FormClosing += TaskExecutor_FormClosing;
            if (File.Exists(hostFilePath))
            {
                originalHostsContent = File.ReadAllText(hostFilePath);
            }
        }

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
                BlockWebsite("www.roblox.com");
            }

            label3.Text = text;


            countdownSpans = GenerateTimeSpans(endTime);

            currentSpanIndex = 0;
            StartNextSpan();

            if (currentSpanIndex == countdownSpans.Count - 1)
            {
                label5.Text = "00:00";
                label4.Text = "Ending";
            }
        }

        private List<TimeSpan> GenerateTimeSpans(DateTime end)
        {
            List<TimeSpan> spans = new List<TimeSpan>();
            TimeSpan interval20 = TimeSpan.FromMinutes(20);
            TimeSpan interval10 = TimeSpan.FromMinutes(10);
            bool is20MinuteSpan = true;

            DateTime current = DateTime.Now;
            while (current < end)
            {
                TimeSpan interval = is20MinuteSpan ? interval20 : interval10;
                DateTime nextSpanEnd = current + interval;

                if (nextSpanEnd > end)
                {
                    nextSpanEnd = end;
                }

                spans.Add(nextSpanEnd - current);
                current = nextSpanEnd;
                is20MinuteSpan = !is20MinuteSpan;
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
                    label5.Text = "10:00";
                    label4.Text = "Rest time";
                }
                else if (currentSpanIndex % 2 != 0)
                {
                    label2.Text = "Rest time";
                    label5.Text = "20:00";
                    label4.Text = "Work time";
                }

                if (currentSpanIndex == countdownSpans.Count - 1)
                {
                    label5.Text = "00:00";
                    label4.Text = "Ending";
                }
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

        // FOCUS MODE: Blocking websites
        public void BlockWebsite(string url)
        {
            /*for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                list.Add("127.0.0.1" + " " + comboBox1.Items[i].ToString());
            }*/

            List<string> blocklist = new List<string>();
            blocklist.Add("127.0.0.1 " + url);
            File.AppendAllLines(hostFilePath, blocklist); //list
        }

        public void TaskExecutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(hostFilePath, originalHostsContent ?? string.Empty);
        }

        private void FlushDns()
        {
            try
            {
                // Create a new process
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe"; // Command prompt
                process.StartInfo.Arguments = "/c ipconfig /flushdns"; // Command to execute
                process.StartInfo.Verb = "runas"; // Run as administrator
                process.StartInfo.RedirectStandardOutput = true; // Redirect output
                process.StartInfo.UseShellExecute = false; // Do not use shell execute
                process.StartInfo.CreateNoWindow = true; // Do not create a window

                // Start the process
                process.Start();

                // Optional: Read the output
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit(); // Wait for the process to finish
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
