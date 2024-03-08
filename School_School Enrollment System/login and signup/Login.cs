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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordinput.Text = "";
            passwordinput.PasswordChar = '*';
            passwordinput.MaxLength = 20;
        }

        private void tr_fromtoask_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formtoask fta = new formtoask();
            fta.Show();
            this.Hide(); 
        }
    }
}
