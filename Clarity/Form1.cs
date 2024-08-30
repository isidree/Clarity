using System;
using System.Windows.Forms;

namespace Clarity
{
    public static class Global
    {

    }

    public partial class Form1 : Form
    {
        private Form activeForm;
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
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

            buttons = new Button[] { fast_task_btn, scheduler_btn, scheduled_tasks_btn, configuration_btn };

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
            OpenChildForm(new Forms.Instructions());
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FastTask());
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
    }
}