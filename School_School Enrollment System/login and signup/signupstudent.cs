using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace School_School_Enrollment_System.login_and_signup
{
    public partial class signupstudent : Form
    {
       
        public signupstudent()
        {
            InitializeComponent();
            passwordinput.Text = "";
            passwordinput.PasswordChar = '*';
            passwordinput.MaxLength = 20;
            inputconfirmpassword.Text = "";
            inputconfirmpassword.PasswordChar = '*';
            inputconfirmpassword.MaxLength = 20;
        }

        private void signupstudent_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int idnumberrandom = random.Next(1000, 9999);
            inputidnumber.Text = "24-" + idnumberrandom; 
        }

        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        public String sqlconnection = @"Data Source=DESKTOP-SSKLAH7\SQLEXPRESS;Initial Catalog=SCHROLL_ENROLLMENT_SYSTEM_SIGNUP_AND_LOGIN;Integrated Security=True;";
       
        private void submitbutton_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection con = new SqlConnection(sqlconnection))
            {
                try
                {
                    if(passwordinput.Text != inputconfirmpassword.Text)
                    {
                        MessageBox.Show("Password not Matched"); 
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT"+" INTO Signup_Student values (@Last_name, @First_name, @Middle_initial, @suffix, @Birth_date, @Birth_place, " +
                            "@Age, @Gender, @Address, @Incoming_grade_level, @Contact_no ,@ID_Number, @Password,@Email, @incoe_Last_Name, @incoe_First_Name, @Incoe_Contact_no, @incoe_Address)", con);
                        cmd.Parameters.AddWithValue("@Last_name", inputlastname.Text);
                        cmd.Parameters.AddWithValue("@First_name", inputfirstname.Text);
                        cmd.Parameters.AddWithValue("@Middle_initial", inputmiddleinitial.Text);
                        cmd.Parameters.AddWithValue("@suffix", inputsuffix.Text);
                        cmd.Parameters.AddWithValue("@Age", inputage.Text);
                        cmd.Parameters.AddWithValue("@Birth_date", birthdateinput.Text);
                        cmd.Parameters.AddWithValue("@Birth_place", inputbirthplace.Text);
                        cmd.Parameters.AddWithValue("@Gender", inputgender.Text);
                        cmd.Parameters.AddWithValue("@Address", inputaddress.Text);
                        cmd.Parameters.AddWithValue("@Incoming_grade_level", inputgradelevel.Text);
                        cmd.Parameters.AddWithValue("@Contact_no", inputcontactnumber.Text);
                        cmd.Parameters.AddWithValue("@ID_Number", inputidnumber.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordinput.Text);
                        cmd.Parameters.AddWithValue("@Email", inputemail.Text);
                        cmd.Parameters.AddWithValue("@incoe_Last_Name", inputincoelastname.Text);
                        cmd.Parameters.AddWithValue("@incoe_First_Name", inputincoefirstname.Text);
                        cmd.Parameters.AddWithValue("@Incoe_Contact_no", inputincoecontactno.Text);
                        cmd.Parameters.AddWithValue("@incoe_Address", inputincoeaddress.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sign-up Successful");
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input blank credentials"); 
                }
               
            }
                
          

        }
    }
}
