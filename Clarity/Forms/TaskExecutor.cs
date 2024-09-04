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
        private long ticks;
        private string selectedItem;
        private DateTime endTime;
        private TimeSpan timeRemaining;

        public TaskExecutor(string _text, long _ticks, string _selectedItem)
        {
            InitializeComponent();
            text = _text;
            ticks = _ticks;
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

            endTime = DateTime.Now.AddMinutes(5);
            timeRemaining = endTime - DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining = endTime - DateTime.Now;

            if (timeRemaining.TotalSeconds <= 0)
            {
                timer1.Stop();
                label1.Text = "Time's up!";
            }
            else
            {
                label1.Text = timeRemaining.ToString(@"hh\:mm\:ss");
            }
        }
    }
}
