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
        private TaskExecutor taskExecutor;

        public Form1()
        {
            InitializeComponent();

            fastTask = new FastTask();
            fastTask.TaskStarted += FastTask_TaskStarted1;

            taskExecutor = new TaskExecutor("dummy value", DateTime.Now.AddSeconds(20), "dummy value");
            taskExecutor.TaskEnded += TaskExecutor_TaskEnded1;
        }

        private void FastTask_TaskStarted1(object? sender, TaskStartedEventArgs e)
        {
            string text = e.Text;
            DateTime EndTime = e.EndTime;
            string selectedItem = e.SelectedItem;

            if (selectedItem == "Focus")
            {
                OpenChildForm(new Forms.TaskExecutor(text, EndTime, selectedItem));
            }
            else if (selectedItem == "UltraFocus")
            {
                TaskExecutor t = new(text, EndTime, selectedItem);
                t.Show();
            }
        }

        private void TaskExecutor_TaskEnded1(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            OpenChildForm(new Forms.Home());
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home());
            SelectedButton(home_btn);
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(fastTask);
            SelectedButton(fast_task_btn);
        }

        private void scheduler_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Scheduler());
            SelectedButton(scheduler_btn);
        }

        private void scheduled_tasks_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ScheduledTasks());
            SelectedButton(scheduled_tasks_btn);
        }

        private void configuration_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Configuration());
            SelectedButton(configuration_btn);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home());
            SelectedButton(home_btn);
        }
    }
}