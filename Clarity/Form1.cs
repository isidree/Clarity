using Clarity.Forms;
using System;
using System.Windows.Forms;

namespace Clarity
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Button[] buttons;
        private FastTask fastTask;
        private bool locked;

        public Form1()
        {
            InitializeComponent();

            fastTask = new FastTask();
            fastTask.TaskStarted += FastTask_TaskStarted1;

            this.FormClosing += Form1_FormClosing;
        }

        // Closure control
        public static class AppState
        {
            public static bool ClosingPermit { get; set; } = false;
        }

        // EVENT RESPONSE
        private void FastTask_TaskStarted1(object? sender, TaskStartedEventArgs e)
        {
            string text = e.Text;
            DateTime EndTime = e.EndTime;
            string selectedItem = e.SelectedItem;

            if (selectedItem == "Focus")
            {
                locked = true;
                OpenChildForm(new Forms.TaskExecutor(text, EndTime, selectedItem));
            }
            else if (selectedItem == "UltraFocus")
            {
                TaskExecutor t = new(text, EndTime, selectedItem);
                t.Show();
            }
        }

        // -- Global functions --
        private void OpenChildForm(Form childForm)
        {
            activeForm?.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktop.Controls.Add(childForm);
            this.desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SelectedButton(Button selectedButton)
        {
            Color selectedColor = Color.FromArgb(97, 79, 71);
            Color normalColor = Color.FromArgb(161, 136, 127);

            buttons = new Button[] { fast_task_btn, scheduler_btn,
                scheduled_tasks_btn, configuration_btn, home_btn };

            foreach (var button in buttons)
            {
                button.BackColor = normalColor;
                button.ForeColor = Color.Black;
            }

            selectedButton.BackColor = selectedColor;
            selectedButton.ForeColor = Color.Beige;
        }

        private void ifLocked(Action action)
        {
            if (locked)
            {
                MessageBox.Show("Focus mode is currently in effect, meaning that you cannot navigate at the moment.");
                return;
            }
            action();
        }

        // -- Page loading through initializations & buttons --
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home());
            SelectedButton(home_btn);

            // create database

            var database = new DatabaseManager();
            database.CreateConfigurationTable();
            database.CreateStudySessionsTable();
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            ifLocked(() =>
            {
                OpenChildForm(fastTask);
                SelectedButton(fast_task_btn);
            });
        }

        private void scheduler_btn_Click(object sender, EventArgs e)
        {
            ifLocked(() =>
            {
                OpenChildForm(new Forms.Scheduler());
                SelectedButton(scheduler_btn);
            });
        }

        private void scheduled_tasks_btn_Click(object sender, EventArgs e)
        {
            ifLocked(() =>
            {
                OpenChildForm(new Forms.ScheduledTasks());
                SelectedButton(scheduled_tasks_btn);
            });
        }

        private void configuration_btn_Click(object sender, EventArgs e)
        {
            ifLocked(() =>
            {
                OpenChildForm(new Forms.Configuration());
                SelectedButton(configuration_btn);
            });
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            ifLocked(() =>
            {
                OpenChildForm(new Forms.Home());
                SelectedButton(home_btn);
            });
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ifLocked(() =>
            {
                AppState.ClosingPermit = true;
                Application.Exit();
            });
        }

        // -- Closure --

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AppState.ClosingPermit)
            {
                e.Cancel = true;
            }
        }
    }
}