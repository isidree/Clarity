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
        public FastTask()
        {
            InitializeComponent();
        }

        private void FastTask_Load(object sender, EventArgs e)
        {

        }

        private void fast_task_btn_Click(object sender, EventArgs e)
        {
            UltraFocus u = new UltraFocus(textBox1.Text, dateTimePicker2.Value.Ticks, comboBox1.SelectedItem.ToString());
            u.Show();
            
        }
    }
}
