using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;

namespace Clarity.Forms
{
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();

            // Shape the buttons to round form
            var rndsh = new Utilities.RoundShaper();
            rndsh.RoundControl(button1);
            rndsh.RoundControl(save_task_btn);
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddHours(1);
            dateTimePicker2.Value = DateTime.Now.AddHours(2);
            comboBox1.SelectedItem = "Focus";
        }

        private void save_task_btn_Click(object sender, EventArgs e)
        {
            var database = new Utilities.DatabaseManager();
            List<(int Id, string TaskName, DateTime StartDate, DateTime EndDate, string FocusMode, bool ReceiveNotifications)> studySessions = database.GetStudySessions();

            // Check overlap
            foreach (var studySession in studySessions)
            {
                if (
                    dateTimePicker1.Value >= studySession.StartDate && dateTimePicker1.Value <= studySession.EndDate
                    || dateTimePicker2.Value >= studySession.StartDate && dateTimePicker2.Value <= studySession.EndDate
                )
                {
                    MessageBox.Show("There is interference with another session. Make sure your interval doesn't interfere with another session you've already programmed.", "Error");
                    return;
                }
            }

            // Check correct intervals
            if (
                dateTimePicker2.Value < dateTimePicker1.Value
                || dateTimePicker1.Value < DateTime.Now
                || (dateTimePicker2.Value - dateTimePicker1.Value).TotalMinutes < 5
            )
            {
                MessageBox.Show("The inputted datetime is either past or too short. Select another one.", "Error");
            }
            else
            {
                // All conditions true

                database.AddStudySession(
                    textBox1.Text == "" ? "Unknown" : textBox1.Text,
                    dateTimePicker1.Value,
                    dateTimePicker2.Value,
                    comboBox1.SelectedItem.ToString() ?? "Focus",
                    checkBox1.Checked
                );

                MessageBox.Show("The task has successfully been saved in the database.", "Success");
            }
        }

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
}
