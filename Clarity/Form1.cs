using Clarity.Forms;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Drawing.Drawing2D;

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

            SetButtonRegion(home_btn, 30);
            SetButtonRegion(fast_task_btn, 30);
            SetButtonRegion(scheduler_btn, 30);
            SetButtonRegion(scheduled_tasks_btn, 30);
            SetButtonRegion(configuration_btn, 30);
            SetButtonRegion(Exit, 30);

            fastTask = new FastTask();
            fastTask.TaskStarted += FastTask_TaskStarted1;

            this.FormClosing += Form1_FormClosing;

            TimeChecker.Start(); // For time checking studySessions
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

            launchTaskExecutor(text, EndTime, selectedItem);
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

        private void SetButtonRegion(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(button.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, button.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
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

        private void launchTaskExecutor(string text, DateTime EndTime, string selectedItem)
        {
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


        // Scheduler method timecheck

        private void TimeChecker_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var database = new DatabaseManager();
            List<(int Id, string TaskName, DateTime StartDate, DateTime EndDate, string FocusMode, bool ReceiveNotifications)> studySessions = database.GetStudySessions();

            foreach (var session in studySessions)
            {
                bool isSessionToday = session.StartDate.Date == now.Date;
                bool isHourMatch = session.StartDate.Hour == now.Hour;
                bool isMinuteMatch = session.StartDate.Minute == now.Minute;

                if (session.ReceiveNotifications)
                {
                    if (isSessionToday && isHourMatch && session.StartDate.Minute - 5 == now.Minute && now.Second == 0)
                    {
                        ShowNotification(session.TaskName, "5 minutes");
                    }
                    else if (isSessionToday && isHourMatch && session.StartDate.Minute - 1 == now.Minute && now.Second == 0)
                    {
                        ShowNotification(session.TaskName, "1 minute");
                    }
                }

                if (isSessionToday && isHourMatch && isMinuteMatch && now.Second == 0)
                {
                    launchTaskExecutor(session.TaskName, session.EndDate, session.FocusMode);
                }
            }
        }

        private void ShowNotification(string taskName, string time)
        {
            using (NotifyIcon notifyIcon = new NotifyIcon())
            {
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Session starting soon!";
                notifyIcon.BalloonTipText = $"{taskName} scheduled within {time}.";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(5000);
            }
        }
    }
}
