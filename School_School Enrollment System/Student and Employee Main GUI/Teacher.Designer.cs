namespace School_School_Enrollment_System
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            sidebar = new Panel();
            teachersloaddropdown = new Panel();
            newload = new Button();
            teachersloadbutton = new Button();
            logoutbutton = new Button();
            menubutton = new Button();
            seestudentsbutton = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            dropdowntimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            teachersloaddropdown.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Blue;
            sidebar.Controls.Add(teachersloaddropdown);
            sidebar.Controls.Add(logoutbutton);
            sidebar.Controls.Add(menubutton);
            sidebar.Controls.Add(seestudentsbutton);
            sidebar.Location = new Point(1, -1);
            sidebar.MaximumSize = new Size(145, 449);
            sidebar.MinimumSize = new Size(51, 449);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(145, 449);
            sidebar.TabIndex = 0;
            // 
            // teachersloaddropdown
            // 
            teachersloaddropdown.BackColor = Color.Blue;
            teachersloaddropdown.Controls.Add(newload);
            teachersloaddropdown.Controls.Add(teachersloadbutton);
            teachersloaddropdown.Location = new Point(0, 50);
            teachersloaddropdown.MaximumSize = new Size(145, 87);
            teachersloaddropdown.MinimumSize = new Size(145, 41);
            teachersloaddropdown.Name = "teachersloaddropdown";
            teachersloaddropdown.Size = new Size(145, 41);
            teachersloaddropdown.TabIndex = 1;
            // 
            // newload
            // 
            newload.FlatAppearance.BorderSize = 0;
            newload.FlatStyle = FlatStyle.Flat;
            newload.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newload.ForeColor = Color.White;
            newload.Image = (Image)resources.GetObject("newload.Image");
            newload.ImageAlign = ContentAlignment.MiddleLeft;
            newload.Location = new Point(0, 43);
            newload.Name = "newload";
            newload.Size = new Size(155, 34);
            newload.TabIndex = 2;
            newload.Text = "New load";
            newload.UseVisualStyleBackColor = true;
            // 
            // teachersloadbutton
            // 
            teachersloadbutton.FlatAppearance.BorderSize = 0;
            teachersloadbutton.FlatStyle = FlatStyle.Flat;
            teachersloadbutton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teachersloadbutton.ForeColor = Color.White;
            teachersloadbutton.Image = (Image)resources.GetObject("teachersloadbutton.Image");
            teachersloadbutton.ImageAlign = ContentAlignment.MiddleLeft;
            teachersloadbutton.Location = new Point(0, 3);
            teachersloadbutton.MinimumSize = new Size(155, 34);
            teachersloadbutton.Name = "teachersloadbutton";
            teachersloadbutton.Size = new Size(155, 34);
            teachersloadbutton.TabIndex = 1;
            teachersloadbutton.Text = "        Teacher's Load";
            teachersloadbutton.UseVisualStyleBackColor = true;
            teachersloadbutton.Click += teachersloadbutton_Click;
            // 
            // logoutbutton
            // 
            logoutbutton.AllowDrop = true;
            logoutbutton.FlatAppearance.BorderSize = 0;
            logoutbutton.FlatStyle = FlatStyle.Flat;
            logoutbutton.ForeColor = Color.White;
            logoutbutton.Image = (Image)resources.GetObject("logoutbutton.Image");
            logoutbutton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutbutton.Location = new Point(0, 385);
            logoutbutton.MinimumSize = new Size(155, 34);
            logoutbutton.Name = "logoutbutton";
            logoutbutton.Size = new Size(155, 34);
            logoutbutton.TabIndex = 5;
            logoutbutton.Text = "Log-out\r\n";
            logoutbutton.UseVisualStyleBackColor = true;
            // 
            // menubutton
            // 
            menubutton.FlatAppearance.BorderSize = 0;
            menubutton.FlatStyle = FlatStyle.Flat;
            menubutton.ForeColor = Color.White;
            menubutton.Image = (Image)resources.GetObject("menubutton.Image");
            menubutton.ImageAlign = ContentAlignment.MiddleLeft;
            menubutton.Location = new Point(0, 325);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(155, 34);
            menubutton.TabIndex = 4;
            menubutton.Text = "Menu";
            menubutton.UseVisualStyleBackColor = true;
            menubutton.Click += menubutton_Click;
            // 
            // seestudentsbutton
            // 
            seestudentsbutton.FlatAppearance.BorderSize = 0;
            seestudentsbutton.FlatStyle = FlatStyle.Flat;
            seestudentsbutton.ForeColor = Color.White;
            seestudentsbutton.Image = (Image)resources.GetObject("seestudentsbutton.Image");
            seestudentsbutton.ImageAlign = ContentAlignment.MiddleLeft;
            seestudentsbutton.Location = new Point(0, 115);
            seestudentsbutton.Name = "seestudentsbutton";
            seestudentsbutton.Size = new Size(155, 34);
            seestudentsbutton.TabIndex = 3;
            seestudentsbutton.Text = "      See Students";
            seestudentsbutton.UseVisualStyleBackColor = true;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // dropdowntimer
            // 
            dropdowntimer.Interval = 10;
            dropdowntimer.Tick += dropdowntimer_Tick;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sidebar);
            Name = "Teacher";
            Text = "Teacher";
            sidebar.ResumeLayout(false);
            teachersloaddropdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Button teachersloadbutton;
        private Button logoutbutton;
        private Button menubutton;
        private System.Windows.Forms.Timer sidebartimer;
        private Button seestudentsbutton;
        private Panel teachersloaddropdown;
        private Button newload;
        private System.Windows.Forms.Timer dropdowntimer;
    }
}
