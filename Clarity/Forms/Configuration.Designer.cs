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
            ViewBtn = new Button();
            AddBlockBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            ClearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)WorkTimeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestTimeInput).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(62, 39, 35);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(38, 117);
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
            label1.Location = new Point(24, 39);
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
            WorkTimeLabel.Location = new Point(38, 164);
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
            RestTimeLabel.Location = new Point(38, 234);
            RestTimeLabel.Name = "RestTimeLabel";
            RestTimeLabel.Size = new Size(148, 31);
            RestTimeLabel.TabIndex = 27;
            RestTimeLabel.Text = "Rest Time:";
            // 
            // WorkTimeInput
            // 
            WorkTimeInput.Anchor = AnchorStyles.None;
            WorkTimeInput.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkTimeInput.Location = new Point(214, 162);
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
            RestTimeInput.Location = new Point(202, 232);
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
            WorkTimeInfo.Location = new Point(294, 164);
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
            RestTimeInfo.Location = new Point(282, 234);
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
            BlockedLinksLabel.Location = new Point(38, 416);
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
            SaveBtn.Location = new Point(41, 305);
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
            LinkBlockTextBox.Location = new Point(212, 413);
            LinkBlockTextBox.Name = "LinkBlockTextBox";
            LinkBlockTextBox.Size = new Size(563, 38);
            LinkBlockTextBox.TabIndex = 37;
            // 
            // ViewBtn
            // 
            ViewBtn.Anchor = AnchorStyles.None;
            ViewBtn.BackColor = Color.FromArgb(161, 136, 127);
            ViewBtn.FlatAppearance.BorderSize = 0;
            ViewBtn.FlatStyle = FlatStyle.Flat;
            ViewBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewBtn.Location = new Point(35, 691);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(301, 56);
            ViewBtn.TabIndex = 38;
            ViewBtn.Text = "View blocked links";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // AddBlockBtn
            // 
            AddBlockBtn.Anchor = AnchorStyles.None;
            AddBlockBtn.BackColor = Color.FromArgb(161, 136, 127);
            AddBlockBtn.FlatAppearance.BorderSize = 0;
            AddBlockBtn.FlatStyle = FlatStyle.Flat;
            AddBlockBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBlockBtn.Location = new Point(791, 413);
            AddBlockBtn.Name = "AddBlockBtn";
            AddBlockBtn.Size = new Size(111, 38);
            AddBlockBtn.TabIndex = 39;
            AddBlockBtn.Text = "Block";
            AddBlockBtn.UseVisualStyleBackColor = false;
            AddBlockBtn.Click += AddBlockBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(35, 540);
            label2.MaximumSize = new Size(900, 0);
            label2.Name = "label2";
            label2.Size = new Size(896, 124);
            label2.TabIndex = 40;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(38, 509);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 41;
            label3.Text = "Alert!";
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.None;
            ClearBtn.BackColor = Color.FromArgb(161, 136, 127);
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(379, 691);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(301, 56);
            ClearBtn.TabIndex = 42;
            ClearBtn.Text = "Clear all blocked links";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Configuration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1010, 778);
            Controls.Add(ClearBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddBlockBtn);
            Controls.Add(ViewBtn);
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
        private Button ViewBtn;
        private Button AddBlockBtn;
        private Label label2;
        private Label label3;
        private Button ClearBtn;
    }
}