namespace Clarity.Forms
{
    partial class Scheduler
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
            dateTimePicker2 = new DateTimePicker();
            fast_task_btn = new Button();
            checkBox1 = new CheckBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.CalendarFont = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(161, 136, 127);
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(156, 354);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(308, 38);
            dateTimePicker2.TabIndex = 35;
            // 
            // fast_task_btn
            // 
            fast_task_btn.Anchor = AnchorStyles.None;
            fast_task_btn.BackColor = Color.FromArgb(161, 136, 127);
            fast_task_btn.FlatAppearance.BorderSize = 0;
            fast_task_btn.FlatStyle = FlatStyle.Flat;
            fast_task_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            fast_task_btn.Location = new Point(12, 656);
            fast_task_btn.Name = "fast_task_btn";
            fast_task_btn.Size = new Size(645, 56);
            fast_task_btn.TabIndex = 34;
            fast_task_btn.Text = "Save task";
            fast_task_btn.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(62, 39, 35);
            checkBox1.Location = new Point(9, 518);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(301, 35);
            checkBox1.TabIndex = 33;
            checkBox1.Text = ":Receive notifications";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(62, 39, 35);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(26, 116);
            label6.Name = "label6";
            label6.Size = new Size(570, 3);
            label6.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Focus", "UltraFocus" });
            comboBox1.Location = new Point(192, 435);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 39);
            comboBox1.TabIndex = 31;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(62, 39, 35);
            label5.Location = new Point(12, 438);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 30;
            label5.Text = "Focus mode:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(12, 360);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 29;
            label3.Text = "End date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(161, 136, 127);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(171, 270);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(308, 38);
            dateTimePicker1.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(12, 276);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 27;
            label2.Text = "Start date:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(261, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 38);
            textBox1.TabIndex = 26;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(62, 39, 35);
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(243, 31);
            label4.TabIndex = 25;
            label4.Text = "Name of the task:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(538, 73);
            label1.TabIndex = 24;
            label1.Text = "Begin a fast task";
            // 
            // Scheduler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 829);
            Controls.Add(dateTimePicker2);
            Controls.Add(fast_task_btn);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Scheduler";
            Text = "Scheduler";
            Load += Scheduler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Button fast_task_btn;
        private CheckBox checkBox1;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
    }
}