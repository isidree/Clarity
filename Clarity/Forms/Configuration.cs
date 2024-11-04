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
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();

            // Shape the buttons to round form
            var rndsh = new RoundShaper();
            rndsh.RoundButton(SaveBtn);
            rndsh.RoundButton(AddBlockBtn);
            rndsh.RoundButton(ViewBtn);
            rndsh.RoundButton(ClearBtn);
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            var database = new DatabaseManager();
            var (_, workTime, restTime) = database.GetConfiguration();

            WorkTimeInput.Value = workTime;
            RestTimeInput.Value = restTime;
        }

        private void AddBlockBtn_Click(object sender, EventArgs e)
        {
            if (LinkBlockTextBox.Text == "")
            {
                MessageBox.Show("The textbox was empty. Input a link.");
            }
            else
            {
                var database = new DatabaseManager();
                database.SaveBlockedPages(LinkBlockTextBox.Text);
                MessageBox.Show(LinkBlockTextBox.Text + " has been added to the blocked links list!");
            }
            
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            var database = new DatabaseManager();
            var (blockedLinks, _, _) = database.GetConfiguration();

            string viewableLinks;

            if (blockedLinks.Count == 1 && blockedLinks[0] == "")
            {
                viewableLinks = "There are no links blocked.";
            }
            else
            {
                viewableLinks = string.Join(", ", blockedLinks.Where(link => !string.IsNullOrWhiteSpace(link)));
            }

            MessageBox.Show(viewableLinks);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All the blocked links will be cleared. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var database = new DatabaseManager();
                database.ClearBlockedPages();
                MessageBox.Show("All the links have been cleared.");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var database = new DatabaseManager();
            database.SaveWorkRestTimes((int)WorkTimeInput.Value, (int)RestTimeInput.Value);
            MessageBox.Show($"Work time set to: {WorkTimeInput.Value} minutes.\nRest time set to: {RestTimeInput.Value} minutes.");
        }
    }
}
