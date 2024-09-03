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
        public delegate void TaskStartedEventHandler(object sender, EventArgs e);
        public event TaskStartedEventHandler TaskStarted;

        public FastTask()
        {
            InitializeComponent();
        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            TaskStarted?.Invoke(this, EventArgs.Empty);

            //TaskMode u = new TaskMode(textBox1.Text, dateTimePicker2.Value.Ticks, comboBox1.SelectedItem.ToString());
            //u.Show();
        }
    }
}
