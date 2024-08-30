using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clarity
{
    public partial class UltraFocus : Form
    {
        private string taskName, mode;
        private long endDate;
        public UltraFocus(string _taskName, long _endDate, string _mode)
        {
            taskName = _taskName;
            endDate = _endDate;
            mode = _mode;

            InitializeComponent();
        }

        private void UltraFocus_Load(object sender, EventArgs e)
        {
            if (mode == "UltraFocus")
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (mode == "Focus")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
        }
    }
}
