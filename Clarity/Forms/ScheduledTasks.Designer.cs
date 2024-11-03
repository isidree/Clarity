namespace Clarity.Forms
{
    partial class ScheduledTasks
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
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.Location = new Point(34, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 600);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(34, 159);
            label2.Name = "label2";
            label2.Size = new Size(605, 36);
            label2.TabIndex = 35;
            label2.Text = "There are currently 0 tasks scheduled.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(62, 39, 35);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(34, 127);
            label6.Name = "label6";
            label6.Size = new Size(570, 3);
            label6.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(521, 73);
            label1.TabIndex = 33;
            label1.Text = "Scheduled tasks";
            // 
            // ScheduledTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1010, 778);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ScheduledTasks";
            Text = "ScheduledTasks";
            Load += ScheduledTasks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label2;
    }
}