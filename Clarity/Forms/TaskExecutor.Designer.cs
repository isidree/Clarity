namespace Clarity.Forms
{
    partial class TaskExecutor
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
            components = new System.ComponentModel.Container();
            fast_task_btn = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // fast_task_btn
            // 
            fast_task_btn.Anchor = AnchorStyles.None;
            fast_task_btn.BackColor = Color.FromArgb(161, 136, 127);
            fast_task_btn.FlatAppearance.BorderSize = 0;
            fast_task_btn.FlatStyle = FlatStyle.Flat;
            fast_task_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            fast_task_btn.Location = new Point(335, 730);
            fast_task_btn.Name = "fast_task_btn";
            fast_task_btn.Size = new Size(475, 56);
            fast_task_btn.TabIndex = 28;
            fast_task_btn.Text = "Stop";
            fast_task_btn.UseVisualStyleBackColor = false;
            fast_task_btn.Click += fast_task_btn_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(62, 39, 35);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(282, 172);
            label6.Name = "label6";
            label6.Size = new Size(570, 3);
            label6.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(74, 58);
            label3.MaximumSize = new Size(1000, 97);
            label3.MinimumSize = new Size(1000, 97);
            label3.Name = "label3";
            label3.Size = new Size(1000, 97);
            label3.TabIndex = 26;
            label3.Text = "Maths homework";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(187, 475);
            label2.MaximumSize = new Size(454, 97);
            label2.MinimumSize = new Size(454, 97);
            label2.Name = "label2";
            label2.Size = new Size(454, 97);
            label2.TabIndex = 25;
            label2.Text = "Work time";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(206, 330);
            label1.Name = "label1";
            label1.Size = new Size(421, 145);
            label1.TabIndex = 24;
            label1.Text = "20:00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(62, 39, 35);
            label4.Location = new Point(721, 499);
            label4.MaximumSize = new Size(270, 57);
            label4.MinimumSize = new Size(270, 57);
            label4.Name = "label4";
            label4.Size = new Size(270, 57);
            label4.TabIndex = 30;
            label4.Text = "Rest time";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(62, 39, 35);
            label5.Location = new Point(715, 359);
            label5.Name = "label5";
            label5.Size = new Size(282, 97);
            label5.TabIndex = 29;
            label5.Text = "10:00";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskExecutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1150, 861);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(fast_task_btn);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaskExecutor";
            Text = "TaskExecutor";
            Load += TaskExecutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fast_task_btn;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label label5;
    }
}