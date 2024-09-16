using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clarity.Forms
{
    public partial class TaskExecutor : Form
    {
        private string text;
        private DateTime endTime;
        private string selectedItem;
        private TimeSpan timeRemaining;

        private List<TimeSpan> countdownSpans;
        private DateTime currentSpanEnd;
        private int currentSpanIndex;

        public TaskExecutor(string _text, DateTime _endTime, string _selectedItem)
        {
            InitializeComponent();
            text = _text;
            endTime = _endTime;
            selectedItem = _selectedItem;
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {

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

            DateTime startTime = DateTime.Now;

            countdownSpans = GenerateTimeSpans(startTime, endTime);

            currentSpanIndex = 0;
            StartNextSpan();
        }

        private List<TimeSpan> GenerateTimeSpans(DateTime start, DateTime end)
        {
            List<TimeSpan> spans = new List<TimeSpan>();
            TimeSpan interval20 = TimeSpan.FromMinutes(20);
            TimeSpan interval10 = TimeSpan.FromMinutes(10);
            bool is20MinuteSpan = true;

            DateTime current = start;
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
                MessageBox.Show("Countdown complete!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
    }
}
