namespace Clarity.Forms
{
    partial class Instructions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(62, 39, 35);
            label7.Location = new Point(72, 440);
            label7.Name = "label7";
            label7.Size = new Size(887, 31);
            label7.TabIndex = 14;
            label7.Text = "· Use \"Scheduled tasks\" to view all the tasks you've scheduled so far.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(62, 39, 35);
            label6.Location = new Point(72, 398);
            label6.Name = "label6";
            label6.Size = new Size(949, 31);
            label6.TabIndex = 13;
            label6.Text = "· Use \"Scheduler\" to schedule a task that you're going to do in the future.";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(62, 39, 35);
            label5.Location = new Point(72, 353);
            label5.Name = "label5";
            label5.Size = new Size(734, 31);
            label5.TabIndex = 12;
            label5.Text = "· Use \"Fast task\" to use Clarity for a brief and quick task.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(62, 39, 35);
            label4.Location = new Point(72, 293);
            label4.Name = "label4";
            label4.Size = new Size(724, 31);
            label4.TabIndex = 11;
            label4.Text = "Using the app for first time? Here's a brief walkthrough:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(222, 160);
            label3.Name = "label3";
            label3.Size = new Size(595, 31);
            label3.TabIndex = 10;
            label3.Text = "Removing distractions, enhancing productivity";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(579, 84);
            label2.Name = "label2";
            label2.Size = new Size(253, 73);
            label2.TabIndex = 9;
            label2.Text = "Clarity";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(211, 86);
            label1.Name = "label1";
            label1.Size = new Size(382, 73);
            label1.TabIndex = 8;
            label1.Text = "Welcome to";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(62, 39, 35);
            label9.Location = new Point(72, 588);
            label9.MaximumSize = new Size(914, 0);
            label9.Name = "label9";
            label9.Size = new Size(912, 93);
            label9.TabIndex = 16;
            label9.Text = "· For a better experience, consider going to configuration. This app has a predetermined set of configurations; despite of that, we encourage our users to enhance the limits of this app.";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(62, 39, 35);
            label8.Location = new Point(72, 527);
            label8.Name = "label8";
            label8.Size = new Size(236, 31);
            label8.TabIndex = 15;
            label8.Text = "Important step!";
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1093, 690);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Instructions";
            Text = "Instructions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
    }
}