namespace School_School_Enrollment_System
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            sidebar = new Panel();
            logoutbutton = new Button();
            menubutton = new Button();
            seestudentsbutton = new Button();
            classschedulebutton = new Button();
            newschedulebutton = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Blue;
            sidebar.Controls.Add(logoutbutton);
            sidebar.Controls.Add(menubutton);
            sidebar.Controls.Add(seestudentsbutton);
            sidebar.Controls.Add(classschedulebutton);
            sidebar.Controls.Add(newschedulebutton);
            sidebar.Location = new Point(1, -1);
            sidebar.MaximumSize = new Size(145, 449);
            sidebar.MinimumSize = new Size(51, 449);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(145, 449);
            sidebar.TabIndex = 0;
            // 
            // logoutbutton
            // 
            logoutbutton.AllowDrop = true;
            logoutbutton.FlatAppearance.BorderSize = 0;
            logoutbutton.FlatStyle = FlatStyle.Flat;
            logoutbutton.ForeColor = Color.White;
            logoutbutton.Image = (Image)resources.GetObject("logoutbutton.Image");
            logoutbutton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutbutton.Location = new Point(11, 385);
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
            menubutton.Location = new Point(11, 325);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(155, 34);
            menubutton.TabIndex = 4;
            menubutton.Text = "Menu";
            menubutton.UseVisualStyleBackColor = true;
            menubutton.Click += this.menubutton_Click;
            // 
            // seestudentsbutton
            // 
            seestudentsbutton.FlatAppearance.BorderSize = 0;
            seestudentsbutton.FlatStyle = FlatStyle.Flat;
            seestudentsbutton.ForeColor = Color.White;
            seestudentsbutton.Image = (Image)resources.GetObject("seestudentsbutton.Image");
            seestudentsbutton.ImageAlign = ContentAlignment.MiddleLeft;
            seestudentsbutton.Location = new Point(11, 241);
            seestudentsbutton.Name = "seestudentsbutton";
            seestudentsbutton.Size = new Size(155, 34);
            seestudentsbutton.TabIndex = 3;
            seestudentsbutton.Text = "See Students";
            seestudentsbutton.UseVisualStyleBackColor = true;
            // 
            // classschedulebutton
            // 
            classschedulebutton.FlatAppearance.BorderSize = 0;
            classschedulebutton.FlatStyle = FlatStyle.Flat;
            classschedulebutton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classschedulebutton.ForeColor = Color.White;
            classschedulebutton.Image = (Image)resources.GetObject("classschedulebutton.Image");
            classschedulebutton.ImageAlign = ContentAlignment.MiddleLeft;
            classschedulebutton.Location = new Point(11, 185);
            classschedulebutton.Name = "classschedulebutton";
            classschedulebutton.Size = new Size(155, 34);
            classschedulebutton.TabIndex = 2;
            classschedulebutton.Text = " Class Schedule";
            classschedulebutton.UseVisualStyleBackColor = true;
            // 
            // newschedulebutton
            // 
            newschedulebutton.FlatAppearance.BorderSize = 0;
            newschedulebutton.FlatStyle = FlatStyle.Flat;
            newschedulebutton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newschedulebutton.ForeColor = Color.White;
            newschedulebutton.Image = (Image)resources.GetObject("newschedulebutton.Image");
            newschedulebutton.ImageAlign = ContentAlignment.MiddleLeft;
            newschedulebutton.Location = new Point(11, 126);
            newschedulebutton.Name = "newschedulebutton";
            newschedulebutton.Size = new Size(155, 34);
            newschedulebutton.TabIndex = 1;
            newschedulebutton.Text = "New Schedule";
            newschedulebutton.UseVisualStyleBackColor = true;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += this.sidebartimer_Tick;
            // 
            // StudentMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sidebar);
            Name = "StudentMain";
            Text = "Student";
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Button newschedulebutton;
        private Button logoutbutton;
        private Button menubutton;
        private Button seestudentsbutton;
        private Button classschedulebutton;
        private System.Windows.Forms.Timer sidebartimer;
    }
}
