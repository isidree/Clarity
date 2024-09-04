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

    public partial class FastTask : Form
    {
        public event EventHandler<TaskStartedEventArgs> TaskStarted;

        public FastTask()
        {
            InitializeComponent();
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem?.ToString() ?? "Focus";

            if (selected != "Focus" && selected != "UltraFocus")
            {
                selected = "Focus";
            }

            var args = new TaskStartedEventArgs(
                string.IsNullOrEmpty(textBox1?.Text) ? "Unknown" : textBox1.Text,
                dateTimePicker2.Value.Ticks,
                comboBox1.SelectedItem?.ToString() ?? "Focus"
            );

            TaskStarted?.Invoke(this, args);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem?.ToString() == "Focus")
            {
                MessageBox.Show("Focus mode is the default mode for this app. It is a less restrictive mode, which allows you to use your computer, but you can block the web pages that distract you the most. Apps installed in your device can't be blocked.");
            }
            else if (comboBox1.SelectedItem?.ToString() == "UltraFocus")
            {
                MessageBox.Show("UltraFocus mode is the most restrictive mode in Clarity. This mode does not allow you to use your computer at all, and will only close itself once the task has ended, or the user voluntarily clicks on the button to stop.");
            }
            else
            {
                MessageBox.Show("Pleaase, select a valid mode.");
            }
        }
    }

    public class TaskStartedEventArgs : EventArgs
    {
        public string Text { get; }
        public long Ticks { get; }
        public string SelectedItem { get; }

        public TaskStartedEventArgs(string text, long ticks, string selectedItem)
        {
            Text = text;
            Ticks = ticks;
            SelectedItem = selectedItem;
        }
    }
}
