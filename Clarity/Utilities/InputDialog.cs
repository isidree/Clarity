using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Clarity.Utilities
{
    internal class InputDialog
    {
        public string? ShowDialog(string prompt = "Input password")
        {
            var rspr = new RoundShaper();

            Form inputForm = new Form();
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.ClientSize = new Size(280, 130);
            inputForm.FormBorderStyle = FormBorderStyle.None;
            inputForm.BackColor = Color.FromArgb(215, 204, 200);

            Label promptLabel = new Label() { Left = 10, Top = 20, Width = 260, Text = prompt, Font = new Font("Verdana", 12), TextAlign = ContentAlignment.MiddleCenter };
            TextBox inputTextBox = new TextBox() { Left = 10, Top = 50, Width = 260, Font = new Font("Verdana", 8) };
            Button okButton = new Button() { Text = "Confirm", Left = 10, Width = 120, Top = 90, Height = 30, Font = new Font("Verdana", 8), FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(161, 136, 127), TextAlign = ContentAlignment.MiddleCenter, DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "Cancel", Left = 150, Width = 120, Top = 90, Height = 30, Font = new Font("Verdana", 8), FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(161, 136, 127), TextAlign = ContentAlignment.MiddleCenter, DialogResult = DialogResult.Cancel };

            okButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatAppearance.BorderSize = 0;
            rspr.RoundControl(inputForm);
            rspr.RoundControl(okButton);
            rspr.RoundControl(cancelButton);

            okButton.Click += (s, e) => { inputForm.DialogResult = DialogResult.OK; };

            inputForm.Controls.Add(promptLabel);
            inputForm.Controls.Add(inputTextBox);
            inputForm.Controls.Add(okButton);
            inputForm.Controls.Add(cancelButton);

            inputForm.AcceptButton = okButton;
            inputForm.CancelButton = cancelButton;

            return inputForm.ShowDialog() == DialogResult.OK ? inputTextBox.Text : null;
        }

        public void VerifyPassword(Action action)
        {
            var database = new DatabaseManager();
            var (_, _, _, parentalControlEnabled, realPassword) = database.GetConfiguration();

            if (parentalControlEnabled == 1)
            {
                string inputtedPassword = ShowDialog();

                if (inputtedPassword != realPassword)
                {
                    return;
                }
            }

            action();
        }
    }
}
