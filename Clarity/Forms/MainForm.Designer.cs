﻿namespace Clarity
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menu = new Panel();
            home_btn = new Button();
            panel1 = new Panel();
            logo = new PictureBox();
            Exit = new Button();
            configuration_btn = new Button();
            scheduled_tasks_btn = new Button();
            scheduler_btn = new Button();
            fast_task_btn = new Button();
            desktop = new Panel();
            TimeChecker = new System.Windows.Forms.Timer(components);
            menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(215, 204, 200);
            menu.Controls.Add(home_btn);
            menu.Controls.Add(panel1);
            menu.Controls.Add(Exit);
            menu.Controls.Add(configuration_btn);
            menu.Controls.Add(scheduled_tasks_btn);
            menu.Controls.Add(scheduler_btn);
            menu.Controls.Add(fast_task_btn);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(277, 908);
            menu.TabIndex = 0;
            // 
            // home_btn
            // 
            home_btn.BackColor = Color.FromArgb(161, 136, 127);
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.FlatStyle = FlatStyle.Flat;
            home_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            home_btn.Location = new Point(8, 343);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(259, 56);
            home_btn.TabIndex = 6;
            home_btn.Text = "Home";
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 136, 127);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 277);
            panel1.TabIndex = 0;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.None;
            logo.Image = Properties.Resources.final_logo;
            logo.Location = new Point(22, 23);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(232, 232);
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(161, 136, 127);
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(8, 826);
            Exit.Name = "Exit";
            Exit.Size = new Size(259, 56);
            Exit.TabIndex = 7;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // configuration_btn
            // 
            configuration_btn.BackColor = Color.FromArgb(161, 136, 127);
            configuration_btn.FlatAppearance.BorderSize = 0;
            configuration_btn.FlatStyle = FlatStyle.Flat;
            configuration_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            configuration_btn.Location = new Point(8, 744);
            configuration_btn.Name = "configuration_btn";
            configuration_btn.Size = new Size(259, 56);
            configuration_btn.TabIndex = 4;
            configuration_btn.Text = "Configuration";
            configuration_btn.UseVisualStyleBackColor = false;
            configuration_btn.Click += configuration_btn_Click;
            // 
            // scheduled_tasks_btn
            // 
            scheduled_tasks_btn.BackColor = Color.FromArgb(161, 136, 127);
            scheduled_tasks_btn.FlatAppearance.BorderSize = 0;
            scheduled_tasks_btn.FlatStyle = FlatStyle.Flat;
            scheduled_tasks_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            scheduled_tasks_btn.Location = new Point(8, 591);
            scheduled_tasks_btn.Name = "scheduled_tasks_btn";
            scheduled_tasks_btn.Size = new Size(259, 56);
            scheduled_tasks_btn.TabIndex = 3;
            scheduled_tasks_btn.Text = "Scheduled tasks";
            scheduled_tasks_btn.UseVisualStyleBackColor = false;
            scheduled_tasks_btn.Click += scheduled_tasks_btn_Click;
            // 
            // scheduler_btn
            // 
            scheduler_btn.BackColor = Color.FromArgb(161, 136, 127);
            scheduler_btn.FlatAppearance.BorderSize = 0;
            scheduler_btn.FlatStyle = FlatStyle.Flat;
            scheduler_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            scheduler_btn.Location = new Point(8, 510);
            scheduler_btn.Name = "scheduler_btn";
            scheduler_btn.Size = new Size(259, 56);
            scheduler_btn.TabIndex = 2;
            scheduler_btn.Text = "Scheduler";
            scheduler_btn.UseVisualStyleBackColor = false;
            scheduler_btn.Click += scheduler_btn_Click;
            // 
            // fast_task_btn
            // 
            fast_task_btn.BackColor = Color.FromArgb(161, 136, 127);
            fast_task_btn.FlatAppearance.BorderSize = 0;
            fast_task_btn.FlatStyle = FlatStyle.Flat;
            fast_task_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            fast_task_btn.Location = new Point(8, 427);
            fast_task_btn.Name = "fast_task_btn";
            fast_task_btn.Size = new Size(259, 56);
            fast_task_btn.TabIndex = 1;
            fast_task_btn.Text = "Fast task";
            fast_task_btn.UseVisualStyleBackColor = false;
            fast_task_btn.Click += fast_task_btn_Click;
            // 
            // desktop
            // 
            desktop.AutoScroll = true;
            desktop.BackColor = Color.FromArgb(228, 228, 228);
            desktop.Dock = DockStyle.Fill;
            desktop.Location = new Point(277, 0);
            desktop.Name = "desktop";
            desktop.Size = new Size(1168, 908);
            desktop.TabIndex = 10;
            // 
            // TimeChecker
            // 
            TimeChecker.Interval = 1000;
            TimeChecker.Tick += TimeChecker_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1445, 908);
            Controls.Add(desktop);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clarity";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private Button fast_task_btn;
        private Button configuration_btn;
        private Button scheduled_tasks_btn;
        private Button scheduler_btn;
        private PictureBox logo;
        private Panel desktop;
        private Button home_btn;
        private Button Exit;
        private Panel panel1;
        private System.Windows.Forms.Timer TimeChecker;
    }
}