namespace Clarity
{
    partial class Form1
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
            menu = new Panel();
            Exit = new Button();
            home_btn = new Button();
            logo = new PictureBox();
            configuration_btn = new Button();
            scheduled_tasks_btn = new Button();
            scheduler_btn = new Button();
            fast_task_btn = new Button();
            desktop = new Panel();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(215, 204, 200);
            menu.Controls.Add(Exit);
            menu.Controls.Add(home_btn);
            menu.Controls.Add(logo);
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
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(161, 136, 127);
            Exit.Dock = DockStyle.Bottom;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(0, 852);
            Exit.Name = "Exit";
            Exit.Size = new Size(277, 56);
            Exit.TabIndex = 7;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // home_btn
            // 
            home_btn.BackColor = Color.FromArgb(161, 136, 127);
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.FlatStyle = FlatStyle.Flat;
            home_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            home_btn.Location = new Point(0, 345);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(277, 56);
            home_btn.TabIndex = 6;
            home_btn.Text = "Home";
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_Click;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.None;
            logo.Location = new Point(0, 0);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(277, 277);
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // configuration_btn
            // 
            configuration_btn.BackColor = Color.FromArgb(161, 136, 127);
            configuration_btn.FlatAppearance.BorderSize = 0;
            configuration_btn.FlatStyle = FlatStyle.Flat;
            configuration_btn.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            configuration_btn.Location = new Point(0, 769);
            configuration_btn.Name = "configuration_btn";
            configuration_btn.Size = new Size(277, 56);
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
            scheduled_tasks_btn.Location = new Point(0, 591);
            scheduled_tasks_btn.Name = "scheduled_tasks_btn";
            scheduled_tasks_btn.Size = new Size(277, 56);
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
            scheduler_btn.Location = new Point(0, 510);
            scheduler_btn.Name = "scheduler_btn";
            scheduler_btn.Size = new Size(277, 56);
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
            fast_task_btn.Location = new Point(0, 427);
            fast_task_btn.Name = "fast_task_btn";
            fast_task_btn.Size = new Size(277, 56);
            fast_task_btn.TabIndex = 1;
            fast_task_btn.Text = "Fast task";
            fast_task_btn.UseVisualStyleBackColor = false;
            fast_task_btn.Click += fast_task_btn_Click;
            // 
            // desktop
            // 
            desktop.BackColor = Color.FromArgb(227, 221, 210);
            desktop.Dock = DockStyle.Fill;
            desktop.Location = new Point(277, 0);
            desktop.Name = "desktop";
            desktop.Size = new Size(1168, 908);
            desktop.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(1445, 908);
            Controls.Add(desktop);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clarity";
            Load += Form1_Load;
            menu.ResumeLayout(false);
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
    }
}