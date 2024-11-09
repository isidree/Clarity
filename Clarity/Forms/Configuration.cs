using Clarity.Utilities;
using System.Data.Entity;
using static System.Windows.Forms.LinkLabel;

namespace Clarity.Forms
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();

            // Shape the buttons to round form
            var rndsh = new Utilities.RoundShaper();
            rndsh.RoundControl(SaveBtn);
            rndsh.RoundControl(AddBlockBtn);
            rndsh.RoundControl(parental_control_enable);
            rndsh.RoundControl(change_parental_password);
            rndsh.RoundControl(button1);
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            var database = new Utilities.DatabaseManager();
            var (_, workTime, restTime, parentalControl, _) = database.GetConfiguration();

            WorkTimeInput.Value = workTime;
            RestTimeInput.Value = restTime;
            parental_control_enable.Text = parentalControl == 0 ? "Enable parental control" : "Disable parental control";

            LoadBlockedLinks();
        }

        private void LoadBlockedLinks()
        {
            var database = new Utilities.DatabaseManager();
            var (blockedLinks, _, _, _, _) = database.GetConfiguration();

            if (blockedLinks.Count > 1)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }

            panel1.Controls.Clear();

            int verticalOffset = 10;
            int margin = 10;

            foreach (var link in blockedLinks)
            {
                if (link == "") { continue; }

                var linksPanel = new Panel
                {
                    Width = 840,
                    Height = 90,
                    Margin = new Padding(margin)
                };

                var linkLabel = new Label { Text = $"• {link}", Font = new Font("Verdana", 15), AutoSize = false, Width = 650, Height = 30, AutoEllipsis = true };
                var deleteBtn = new Button { Text = "Delete", Font = new Font("Verdana", 15), FlatStyle = FlatStyle.Flat, Width = 150, Height = 50, BackColor = Color.FromArgb(161, 136, 127), TextAlign = ContentAlignment.MiddleCenter };
                var divider = new Panel { Height = 2, Dock = DockStyle.Bottom, BackColor = Color.Gray, Margin = new Padding(0, 5, 0, 5) };

                var rndsh = new Utilities.RoundShaper();
                rndsh.RoundControl(deleteBtn);
                deleteBtn.FlatAppearance.BorderSize = 0;
                deleteBtn.Click += (s, e) => DeleteLink(link);

                linksPanel.Controls.Add(linkLabel);
                linksPanel.Controls.Add(deleteBtn);
                linksPanel.Controls.Add(divider);

                linkLabel.Location = new Point(10, 25);
                deleteBtn.Location = new Point(670, 10);
                linksPanel.Location = new Point(0, verticalOffset);

                verticalOffset += linksPanel.Height + margin;

                panel1.Controls.Add(linksPanel);
            }
        }

        private void DeleteLink(string link)
        {
            new InputDialog().VerifyPassword(() =>
            {
                DialogResult result = MessageBox.Show($"{link} will be deleted. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var database = new Utilities.DatabaseManager();
                    database.ClearBlockedPage(link);
                    LoadBlockedLinks();
                }
            });
        }

        private void AddBlockBtn_Click(object sender, EventArgs e)
        {
            new InputDialog().VerifyPassword(() =>
            {
                if (LinkBlockTextBox.Text == "")
                {
                    MessageBox.Show("The textbox was empty. Input a link.", "Error");
                }
                else
                {
                    var database = new Utilities.DatabaseManager();
                    database.SaveBlockedPages(LinkBlockTextBox.Text);
                    LoadBlockedLinks();
                }
            });
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            new InputDialog().VerifyPassword(() =>
            {
                var database = new Utilities.DatabaseManager();
                database.SaveWorkRestTimes((int)WorkTimeInput.Value, (int)RestTimeInput.Value);
                MessageBox.Show($"Work time set to: {WorkTimeInput.Value} minutes.\nRest time set to: {RestTimeInput.Value} minutes.", "Success");
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not include http:// or https:// in the beginning of the link. To effectively block a site, consider adding multiple domains that lead to the same page, for example: www.youtube.com, youtube.com, m.youtube.com, etc.", "Information");
        }

        private void parental_control_enable_Click(object sender, EventArgs e)
        {
            new InputDialog().VerifyPassword(() =>
            {
                var database = new Utilities.DatabaseManager();
                var (_, _, _, parentalControl, parentalPassword) = database.GetConfiguration();

                if (parentalPassword == "")
                {
                    var InputDialog = new Utilities.InputDialog();
                    string password = InputDialog.ShowDialog("Create a password");

                    if (password == "")
                    {
                        MessageBox.Show("TextBox was empty.", "Error");
                    }
                    else
                    {
                        database.ChangePassword(password);
                    }

                    return;
                }

                if (parentalControl == 0)
                {
                    database.SwitchParentalControl(1);
                    parental_control_enable.Text = "Disable parental control";
                    MessageBox.Show("Parental Control is now ENABLED.", "Information");
                }
                else if (parentalControl == 1)
                {
                    database.SwitchParentalControl(0);
                    parental_control_enable.Text = "Enable parental control";
                    MessageBox.Show("Parental Control is now DISABLED.", "Information");
                }
            });
        }

        private void change_parental_password_Click(object sender, EventArgs e)
        {
            var database = new Utilities.DatabaseManager();
            var (_, _, _, _, parentalPassword) = database.GetConfiguration();
            var InputDialog = new Utilities.InputDialog();
            var oldPassword = InputDialog.ShowDialog("Input old password");

            if (oldPassword == parentalPassword)
            {
                var newPassword = InputDialog.ShowDialog("Input new password");

                if (newPassword == "")
                {
                    MessageBox.Show("TextBox was empty.", "Error");
                }
                else
                {
                    database.ChangePassword(newPassword);
                }
            }
            else
            {
                MessageBox.Show("Wrong password.", "Error");
            }
        }
    }
}
