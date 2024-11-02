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

namespace Clarity.Forms
{
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddHours(1);
            dateTimePicker2.Value = DateTime.Now.AddHours(2);
            comboBox1.SelectedItem = "Focus";
        }

        private void save_task_btn_Click(object sender, EventArgs e)
        {
            if (
                dateTimePicker2.Value < dateTimePicker1.Value
                || dateTimePicker1.Value < DateTime.Now
                || (dateTimePicker2.Value - dateTimePicker1.Value).TotalMinutes < 5
            )
            {
                MessageBox.Show("Please, ensure that the dates selected are valid.");
            }
            else
            {
                var database = new DatabaseManager();
                database.AddStudySession(
                    textBox1.Text == "" ? "Unknown" : textBox1.Text,
                    dateTimePicker1.Value,
                    dateTimePicker2.Value,
                    comboBox1.SelectedItem.ToString(),
                    checkBox1.Checked
                );

                MessageBox.Show("The task has successfully been saved in the database.");
            }
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
                MessageBox.Show("Please, select a valid mode.");
            }
        }
    }
}
