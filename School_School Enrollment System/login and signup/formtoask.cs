using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_School_Enrollment_System.login_and_signup
{
    public partial class formtoask : Form
    {
        public formtoask()
        {
            InitializeComponent();
        }

        
        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (rbstudent.Checked)
            {
                signupstudent sus = new signupstudent();
                sus.Show();
                this.Hide();
            }
            else if (rbemployee.Checked)
            {
                signupemployee sue = new signupemployee();
                sue.Show();
                this.Hide();
            }
        }
    }
}
