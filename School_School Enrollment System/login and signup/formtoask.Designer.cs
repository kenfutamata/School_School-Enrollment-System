namespace School_School_Enrollment_System.login_and_signup
{
    partial class formtoask
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
            rbemployee = new RadioButton();
            rbstudent = new RadioButton();
            submitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 20);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Are you a?";
            // 
            // rbemployee
            // 
            rbemployee.AutoSize = true;
            rbemployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbemployee.Location = new Point(107, 157);
            rbemployee.Name = "rbemployee";
            rbemployee.Size = new Size(104, 25);
            rbemployee.TabIndex = 1;
            rbemployee.TabStop = true;
            rbemployee.Text = "Employee";
            rbemployee.UseVisualStyleBackColor = true;
            // 
            // rbstudent
            // 
            rbstudent.AutoSize = true;
            rbstudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbstudent.Location = new Point(107, 101);
            rbstudent.Name = "rbstudent";
            rbstudent.Size = new Size(92, 25);
            rbstudent.TabIndex = 2;
            rbstudent.TabStop = true;
            rbstudent.Text = "Student ";
            rbstudent.UseVisualStyleBackColor = true;
            // 
            // submitbutton
            // 
            submitbutton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitbutton.Location = new Point(90, 235);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(140, 30);
            submitbutton.TabIndex = 3;
            submitbutton.Text = "Submit";
            submitbutton.UseVisualStyleBackColor = true;
            submitbutton.Click += submitbutton_Click;
            // 
            // formtoask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(submitbutton);
            Controls.Add(rbstudent);
            Controls.Add(rbemployee);
            Controls.Add(label1);
            Name = "formtoask";
            Text = "formtoask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbemployee;
        private RadioButton rbstudent;
        private Button submitbutton;
    }
}