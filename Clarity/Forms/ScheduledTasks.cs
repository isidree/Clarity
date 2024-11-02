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
    public partial class ScheduledTasks : Form
    {
        public ScheduledTasks()
        {
            InitializeComponent();
        }

        private void ScheduledTasks_Load(object sender, EventArgs e)
        {
            // if studysessions > 0
            var database = new DatabaseManager();
            List<(string TaskName, DateTime StartDate, DateTime EndDate, string FocusMode, bool ReceiveNotifications)> studySessions = database.GetStudySessions();
            foreach (var studySession in studySessions)
            {
                MessageBox.Show($"{studySession.TaskName}, {studySession.StartDate.ToString()}, {studySession.EndDate.ToString()}, {studySession.FocusMode}, {studySession.ReceiveNotifications}");
            }
        }
    }
}
