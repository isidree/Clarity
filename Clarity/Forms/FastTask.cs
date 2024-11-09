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
        public event EventHandler<TaskStartedEventArgs>? TaskStarted;

        public FastTask()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Now.AddHours(1);
            comboBox1.SelectedItem = "Focus";

            // Shape the buttons to round form
            var rndsh = new Utilities.RoundShaper();
            rndsh.RoundControl(button1);
            rndsh.RoundControl(fast_task_btn);
        }

        // Button clicked --> Launch event
        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            var database = new Utilities.DatabaseManager();
            List<(int Id, string TaskName, DateTime StartDate, DateTime EndDate, string FocusMode, bool ReceiveNotifications)> studySessions = database.GetStudySessions();

            // Check overlap
            foreach (var studySession in studySessions)
            {
                if (dateTimePicker2.Value >= studySession.StartDate && dateTimePicker2.Value <= studySession.EndDate)
                {
                    MessageBox.Show("There is interference with another session. Make sure your interval doesn't interfere with another session you've already programmed.", "Error");
                    return;
                }
            }

            // Check correct intervals
            if (dateTimePicker2.Value < DateTime.Now.AddMinutes(1))
            {
                MessageBox.Show("The inputted datetime is either past or too short. Select another one.", "Error");
                return;
            }
            string selected = comboBox1.SelectedItem?.ToString() ?? "Focus";

            var args = new TaskStartedEventArgs(
                string.IsNullOrEmpty(textBox1?.Text) ? "Unknown" : textBox1.Text,
                dateTimePicker2.Value,
                comboBox1.SelectedItem?.ToString() ?? "Focus"
            );

            TaskStarted?.Invoke(this, args);
        }

        // Information button
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem?.ToString() == "Focus")
            {
                MessageBox.Show("Focus mode is the default mode for this app. It is a less restrictive mode, which allows you to use your computer, but you can block the web pages that distract you the most. Apps installed in your device can't be blocked.", "Information");
            }
            else if (comboBox1.SelectedItem?.ToString() == "UltraFocus")
            {
                MessageBox.Show("UltraFocus mode is the most restrictive mode in Clarity. This mode does not allow you to use your computer at all, and will only close itself once the task has ended, or the user voluntarily clicks on the button to stop.", "Information");
            }
            else
            {
                MessageBox.Show("Please, select a valid mode.", "Error");
            }
        }
    }

    // Get data to send to event
    public class TaskStartedEventArgs : EventArgs
    {
        public string Text { get; }
        public DateTime EndTime { get; }
        public string SelectedItem { get; }

        public TaskStartedEventArgs(string text, DateTime endtime, string selectedItem)
        {
            Text = text;
            EndTime = endtime;
            SelectedItem = selectedItem;
        }
    }
}
