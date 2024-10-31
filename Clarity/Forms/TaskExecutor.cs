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

        public event EventHandler TaskEnded;

        public TaskExecutor(string _text, DateTime _endTime, string _selectedItem)
        {
            InitializeComponent();
            text = _text;
            endTime = _endTime;
            selectedItem = _selectedItem;
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void TaskExecutor_Load(object sender, EventArgs e)
        {
            if (selectedItem == "UltraFocus")
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
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
            if (selectedItem == "UltraFocus")
            {
                this.Close();
                Application.Restart();
            }
            else if (selectedItem == "Focus")
            {
                Application.Restart();
                //TaskEnded?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
