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
    public partial class signupemployee : Form
    {
        public signupemployee()
        {
            InitializeComponent();
        }

        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide(); 
        }
    }
}
