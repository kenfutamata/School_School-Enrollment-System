namespace School_School_Enrollment_System.login_and_signup
{
    partial class Login
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
            tr_fromtoask = new LinkLabel();
            idnumberinput = new TextBox();
            passwordinput = new TextBox();
            lblidnumber = new Label();
            lblpassword = new Label();
            loginbutton = new Button();
            SuspendLayout();
            // 
            // tr_fromtoask
            // 
            tr_fromtoask.AutoSize = true;
            tr_fromtoask.Location = new Point(116, 275);
            tr_fromtoask.Name = "tr_fromtoask";
            tr_fromtoask.Size = new Size(144, 15);
            tr_fromtoask.TabIndex = 0;
            tr_fromtoask.TabStop = true;
            tr_fromtoask.Text = "If new to the app, Sign-up";
            tr_fromtoask.LinkClicked += tr_fromtoask_LinkClicked;
            // 
            // idnumberinput
            // 
            idnumberinput.BorderStyle = BorderStyle.None;
            idnumberinput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idnumberinput.Location = new Point(53, 70);
            idnumberinput.Name = "idnumberinput";
            idnumberinput.Size = new Size(263, 22);
            idnumberinput.TabIndex = 1;
            // 
            // passwordinput
            // 
            passwordinput.BorderStyle = BorderStyle.None;
            passwordinput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordinput.Location = new Point(53, 146);
            passwordinput.Name = "passwordinput";
            passwordinput.Size = new Size(263, 22);
            passwordinput.TabIndex = 2;
            // 
            // lblidnumber
            // 
            lblidnumber.AutoSize = true;
            lblidnumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblidnumber.Location = new Point(53, 41);
            lblidnumber.Name = "lblidnumber";
            lblidnumber.Size = new Size(63, 15);
            lblidnumber.TabIndex = 3;
            lblidnumber.Text = "ID number";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(53, 119);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(57, 15);
            lblpassword.TabIndex = 4;
            lblpassword.Text = "Password";
            // 
            // loginbutton
            // 
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(135, 215);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(110, 34);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Log-in";
            loginbutton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 311);
            Controls.Add(loginbutton);
            Controls.Add(lblpassword);
            Controls.Add(lblidnumber);
            Controls.Add(passwordinput);
            Controls.Add(idnumberinput);
            Controls.Add(tr_fromtoask);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel tr_fromtoask;
        private TextBox idnumberinput;
        private TextBox passwordinput;
        private Label lblidnumber;
        private Label lblpassword;
        private Button loginbutton;
    }
}