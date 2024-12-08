namespace Clarity.Forms
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            label6 = new Label();
            label1 = new Label();
            WorkTimeLabel = new Label();
            RestTimeLabel = new Label();
            WorkTimeInput = new NumericUpDown();
            RestTimeInput = new NumericUpDown();
            WorkTimeInfo = new Label();
            RestTimeInfo = new Label();
            BlockedLinksLabel = new Label();
            SaveBtn = new Button();
            LinkBlockTextBox = new TextBox();
            AddBlockBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            change_parental_password = new Button();
            parental_control_enable = new Button();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)WorkTimeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestTimeInput).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(62, 39, 35);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(113, 167);
            label6.Name = "label6";
            label6.Size = new Size(430, 3);
            label6.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(99, 89);
            label1.Name = "label1";
            label1.Size = new Size(435, 73);
            label1.TabIndex = 21;
            label1.Text = "Configuration";
            // 
            // WorkTimeLabel
            // 
            WorkTimeLabel.Anchor = AnchorStyles.None;
            WorkTimeLabel.AutoSize = true;
            WorkTimeLabel.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkTimeLabel.ForeColor = Color.FromArgb(62, 39, 35);
            WorkTimeLabel.Location = new Point(102, 286);
            WorkTimeLabel.Name = "WorkTimeLabel";
            WorkTimeLabel.Size = new Size(159, 31);
            WorkTimeLabel.TabIndex = 26;
            WorkTimeLabel.Text = "Work Time:";
            // 
            // RestTimeLabel
            // 
            RestTimeLabel.Anchor = AnchorStyles.None;
            RestTimeLabel.AutoSize = true;
            RestTimeLabel.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RestTimeLabel.ForeColor = Color.FromArgb(62, 39, 35);
            RestTimeLabel.Location = new Point(102, 356);
            RestTimeLabel.Name = "RestTimeLabel";
            RestTimeLabel.Size = new Size(148, 31);
            RestTimeLabel.TabIndex = 27;
            RestTimeLabel.Text = "Rest Time:";
            // 
            // WorkTimeInput
            // 
            WorkTimeInput.Anchor = AnchorStyles.None;
            WorkTimeInput.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkTimeInput.Location = new Point(278, 284);
            WorkTimeInput.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            WorkTimeInput.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            WorkTimeInput.Name = "WorkTimeInput";
            WorkTimeInput.Size = new Size(74, 38);
            WorkTimeInput.TabIndex = 31;
            WorkTimeInput.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // RestTimeInput
            // 
            RestTimeInput.Anchor = AnchorStyles.None;
            RestTimeInput.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RestTimeInput.Location = new Point(266, 354);
            RestTimeInput.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            RestTimeInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RestTimeInput.Name = "RestTimeInput";
            RestTimeInput.Size = new Size(74, 38);
            RestTimeInput.TabIndex = 32;
            RestTimeInput.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // WorkTimeInfo
            // 
            WorkTimeInfo.Anchor = AnchorStyles.None;
            WorkTimeInfo.AutoSize = true;
            WorkTimeInfo.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkTimeInfo.ForeColor = Color.FromArgb(62, 39, 35);
            WorkTimeInfo.Location = new Point(358, 286);
            WorkTimeInfo.Name = "WorkTimeInfo";
            WorkTimeInfo.Size = new Size(329, 31);
            WorkTimeInfo.TabIndex = 33;
            WorkTimeInfo.Text = "minutes (min 5, max 90)";
            // 
            // RestTimeInfo
            // 
            RestTimeInfo.Anchor = AnchorStyles.None;
            RestTimeInfo.AutoSize = true;
            RestTimeInfo.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RestTimeInfo.ForeColor = Color.FromArgb(62, 39, 35);
            RestTimeInfo.Location = new Point(346, 356);
            RestTimeInfo.Name = "RestTimeInfo";
            RestTimeInfo.Size = new Size(329, 31);
            RestTimeInfo.TabIndex = 34;
            RestTimeInfo.Text = "minutes (min 1, max 30)";
            // 
            // BlockedLinksLabel
            // 
            BlockedLinksLabel.Anchor = AnchorStyles.None;
            BlockedLinksLabel.AutoSize = true;
            BlockedLinksLabel.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BlockedLinksLabel.ForeColor = Color.FromArgb(62, 39, 35);
            BlockedLinksLabel.Location = new Point(102, 596);
            BlockedLinksLabel.Name = "BlockedLinksLabel";
            BlockedLinksLabel.Size = new Size(156, 31);
            BlockedLinksLabel.TabIndex = 35;
            BlockedLinksLabel.Text = "Block links:";
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.None;
            SaveBtn.BackColor = Color.FromArgb(161, 136, 127);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.Location = new Point(105, 427);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(301, 56);
            SaveBtn.TabIndex = 36;
            SaveBtn.Text = "Save configuration";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LinkBlockTextBox
            // 
            LinkBlockTextBox.Anchor = AnchorStyles.None;
            LinkBlockTextBox.BackColor = Color.White;
            LinkBlockTextBox.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LinkBlockTextBox.Location = new Point(276, 593);
            LinkBlockTextBox.Name = "LinkBlockTextBox";
            LinkBlockTextBox.Size = new Size(563, 38);
            LinkBlockTextBox.TabIndex = 37;
            // 
            // AddBlockBtn
            // 
            AddBlockBtn.Anchor = AnchorStyles.None;
            AddBlockBtn.BackColor = Color.FromArgb(161, 136, 127);
            AddBlockBtn.FlatAppearance.BorderSize = 0;
            AddBlockBtn.FlatStyle = FlatStyle.Flat;
            AddBlockBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBlockBtn.Location = new Point(855, 593);
            AddBlockBtn.Name = "AddBlockBtn";
            AddBlockBtn.Size = new Size(111, 38);
            AddBlockBtn.TabIndex = 39;
            AddBlockBtn.Text = "Block";
            AddBlockBtn.UseVisualStyleBackColor = false;
            AddBlockBtn.Click += AddBlockBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.FromArgb(62, 39, 35);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(105, 258);
            label4.Name = "label4";
            label4.Size = new Size(430, 3);
            label4.TabIndex = 44;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(62, 39, 35);
            label5.Location = new Point(105, 214);
            label5.Name = "label5";
            label5.Size = new Size(427, 34);
            label5.TabIndex = 43;
            label5.Text = "Work/Rest times settings";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.FromArgb(62, 39, 35);
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(102, 573);
            label7.Name = "label7";
            label7.Size = new Size(370, 3);
            label7.TabIndex = 46;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(62, 39, 35);
            label8.Location = new Point(102, 529);
            label8.Name = "label8";
            label8.Size = new Size(373, 34);
            label8.TabIndex = 45;
            label8.Text = "Link blockage settings";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.BackColor = Color.FromArgb(62, 39, 35);
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(99, 993);
            label9.Name = "label9";
            label9.Size = new Size(410, 3);
            label9.TabIndex = 48;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(62, 39, 35);
            label10.Location = new Point(99, 949);
            label10.Name = "label10";
            label10.Size = new Size(410, 34);
            label10.TabIndex = 47;
            label10.Text = "Parental control settings";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(62, 39, 35);
            label11.Location = new Point(99, 1017);
            label11.MaximumSize = new Size(900, 0);
            label11.Name = "label11";
            label11.Size = new Size(888, 93);
            label11.TabIndex = 49;
            label11.Text = resources.GetString("label11.Text");
            // 
            // change_parental_password
            // 
            change_parental_password.Anchor = AnchorStyles.None;
            change_parental_password.BackColor = Color.FromArgb(161, 136, 127);
            change_parental_password.FlatAppearance.BorderSize = 0;
            change_parental_password.FlatStyle = FlatStyle.Flat;
            change_parental_password.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            change_parental_password.Location = new Point(443, 1149);
            change_parental_password.Name = "change_parental_password";
            change_parental_password.Size = new Size(301, 56);
            change_parental_password.TabIndex = 51;
            change_parental_password.Text = "Change password";
            change_parental_password.UseVisualStyleBackColor = false;
            change_parental_password.Click += change_parental_password_Click;
            // 
            // parental_control_enable
            // 
            parental_control_enable.Anchor = AnchorStyles.None;
            parental_control_enable.BackColor = Color.FromArgb(161, 136, 127);
            parental_control_enable.FlatAppearance.BorderSize = 0;
            parental_control_enable.FlatStyle = FlatStyle.Flat;
            parental_control_enable.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            parental_control_enable.Location = new Point(99, 1149);
            parental_control_enable.Name = "parental_control_enable";
            parental_control_enable.Size = new Size(301, 56);
            parental_control_enable.TabIndex = 50;
            parental_control_enable.Text = "Enable parental control";
            parental_control_enable.UseVisualStyleBackColor = false;
            parental_control_enable.Click += parental_control_enable_Click;
            // 
            // panel1
            //
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.Location = new Point(110, 659);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 267);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(257, 776);
            label2.Name = "label2";
            label2.Size = new Size(552, 31);
            label2.TabIndex = 53;
            label2.Text = "There are no blocked links at the moment.";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(161, 136, 127);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(981, 593);
            button1.Name = "button1";
            button1.Size = new Size(45, 38);
            button1.TabIndex = 54;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Configuration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1132, 1253);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(change_parental_password);
            Controls.Add(parental_control_enable);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(AddBlockBtn);
            Controls.Add(LinkBlockTextBox);
            Controls.Add(SaveBtn);
            Controls.Add(BlockedLinksLabel);
            Controls.Add(RestTimeInfo);
            Controls.Add(WorkTimeInfo);
            Controls.Add(RestTimeInput);
            Controls.Add(WorkTimeInput);
            Controls.Add(RestTimeLabel);
            Controls.Add(WorkTimeLabel);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "Configuration";
            Text = "Configuration";
            Load += Configuration_Load;
            ((System.ComponentModel.ISupportInitialize)WorkTimeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestTimeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private Label WorkTimeLabel;
        private Label RestTimeLabel;
        private NumericUpDown WorkTimeInput;
        private NumericUpDown RestTimeInput;
        private Label WorkTimeInfo;
        private Label RestTimeInfo;
        private Label BlockedLinksLabel;
        private Button SaveBtn;
        private TextBox LinkBlockTextBox;
        private Button AddBlockBtn;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button change_parental_password;
        private Button parental_control_enable;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}