using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clarity.Forms
{
    public partial class ScheduledTasks : Form
    {
        private List<(int Id, string TaskName, DateTime StartDate, DateTime EndDate, string FocusMode, bool ReceiveNotifications)> studySessions;

        public ScheduledTasks()
        {
            InitializeComponent();
        }

        private void ScheduledTasks_Load(object sender, EventArgs e)
        {
            LoadStudySessions();
        }

        private void LoadStudySessions()
        {
            var database = new DatabaseManager();
            studySessions = database.GetStudySessions();

            label2.Text = $"There are currently {studySessions.Count} tasks scheduled.";
            panel1.Controls.Clear();

            int verticalOffset = 10;
            int margin = 10;

            foreach (var session in studySessions)
            {
                var sessionPanel = new Panel
                {
                    Width = 900,
                    Height = 150,
                    Margin = new Padding(margin)
                };

                var taskLabel = new Label { Text = session.TaskName, Font = new Font("Verdana", 15, FontStyle.Bold), AutoSize = true };
                var dateLabel = new Label { Text = $"{session.StartDate:g} - {session.EndDate:g}", Font = new Font("Verdana", 15), AutoSize = true };
                var focusModeLabel = new Label { Text = $"Focus Mode: {session.FocusMode}", Font = new Font("Verdana", 15), AutoSize = true };
                var notificationLabel = new Label { Text = session.ReceiveNotifications ? "🔔 Notifications On" : "🔕 Notifications Off", Font = new Font("Verdana", 15), AutoSize = true };
                var deleteBtn = new Button { Text = "Delete", Font = new Font("Verdana", 15), FlatStyle = FlatStyle.Flat, Width = 150, Height = 50, BackColor = Color.FromArgb(161, 136, 127), TextAlign = ContentAlignment.MiddleCenter };
                var divider = new Panel { Height = 2, Dock = DockStyle.Bottom, BackColor = Color.Gray, Margin = new Padding(0, 5, 0, 5) };

                deleteBtn.Click += (s, e) => DeleteStudySession(session.Id);

                sessionPanel.Controls.Add(taskLabel);
                sessionPanel.Controls.Add(dateLabel);
                sessionPanel.Controls.Add(focusModeLabel);
                sessionPanel.Controls.Add(notificationLabel);
                sessionPanel.Controls.Add(deleteBtn);
                sessionPanel.Controls.Add(divider);

                taskLabel.Location = new Point(10, 10);
                dateLabel.Location = new Point(10, 40);
                focusModeLabel.Location = new Point(10, 70);
                notificationLabel.Location = new Point(10, 100);
                deleteBtn.Location = new Point(750, 50);
                sessionPanel.Location = new Point(0, verticalOffset);

                verticalOffset += sessionPanel.Height + margin;

                panel1.Controls.Add(sessionPanel);
            }
        }

        private void DeleteStudySession(int sessionId)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this session?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var database = new DatabaseManager();
                database.DeleteStudySession(sessionId);
                LoadStudySessions();
            }
        }
    }
}
