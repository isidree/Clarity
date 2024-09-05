namespace Clarity.Forms
{
    partial class FastTask
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
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            fast_task_btn = new Button();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(538, 73);
            label1.TabIndex = 9;
            label1.Text = "Begin a fast task";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(62, 39, 35);
            label4.Location = new Point(28, 203);
            label4.Name = "label4";
            label4.Size = new Size(243, 31);
            label4.TabIndex = 12;
            label4.Text = "Name of the task:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(277, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 38);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(28, 320);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 16;
            label3.Text = "End date:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(62, 39, 35);
            label5.Location = new Point(30, 436);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 18;
            label5.Text = "Focus mode:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Focus", "UltraFocus" });
            comboBox1.Location = new Point(210, 433);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 39);
            comboBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(62, 39, 35);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(42, 132);
            label6.Name = "label6";
            label6.Size = new Size(570, 3);
            label6.TabIndex = 20;
            // 
            // fast_task_btn
            // 
            fast_task_btn.Anchor = AnchorStyles.None;
            fast_task_btn.BackColor = Color.FromArgb(161, 136, 127);
            fast_task_btn.FlatAppearance.BorderSize = 0;
            fast_task_btn.FlatStyle = FlatStyle.Flat;
            fast_task_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            fast_task_btn.Location = new Point(28, 672);
            fast_task_btn.Name = "fast_task_btn";
            fast_task_btn.Size = new Size(645, 56);
            fast_task_btn.TabIndex = 22;
            fast_task_btn.Text = "Begin task";
            fast_task_btn.UseVisualStyleBackColor = false;
            fast_task_btn.Click += fast_task_btn_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.CalendarFont = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(161, 136, 127);
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(172, 314);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(308, 38);
            dateTimePicker2.TabIndex = 23;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(161, 136, 127);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(443, 433);
            button1.Name = "button1";
            button1.Size = new Size(45, 39);
            button1.TabIndex = 24;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FastTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1010, 778);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(fast_task_btn);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FastTask";
            Text = "FastTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button fast_task_btn;
        private DateTimePicker dateTimePicker2;
        private Button button1;
    }
}