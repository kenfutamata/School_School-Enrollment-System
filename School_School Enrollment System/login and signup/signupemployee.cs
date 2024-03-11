using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace School_School_Enrollment_System.login_and_signup
{
    public partial class signupemployee : Form
    {
        public signupemployee()
        {
            InitializeComponent();
            passwordinput.Text = "";
            passwordinput.PasswordChar = '*';
            passwordinput.MaxLength = 20;
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
                con.Open();
                SqlCommand cmdEmployee = new SqlCommand("INSERT INTO Signup_Employee VALUES (@Last_name, @First_name, @Middle_initial,  @suffix, @Birth_date, @Birth_place, " +
                    "@Age, @Gender, @Address, @Current_position, @Contact_no, @ID_number, @password, @Email, @incoe_Last_name, @incoe_First_name, @incoe_Contact_no, @incoe_Address)", con);
               




                cmdEmployee.Parameters.AddWithValue("@Last_name", inputlastname.Text);
                cmdEmployee.Parameters.AddWithValue("@First_name", inputfirstname.Text);
                cmdEmployee.Parameters.AddWithValue("@Middle_initial", inputmiddleinitial.Text);
                cmdEmployee.Parameters.AddWithValue("@suffix", inputsuffix.Text);
                cmdEmployee.Parameters.AddWithValue("@Birth_date", birthdateinput.Text);
                cmdEmployee.Parameters.AddWithValue("@Birth_place", inputbirthplace.Text);
                cmdEmployee.Parameters.AddWithValue("@Age", inputage.Text);
                cmdEmployee.Parameters.AddWithValue("@Gender", inputgender.Text);
                cmdEmployee.Parameters.AddWithValue("@Address", inputaddress.Text);
                cmdEmployee.Parameters.AddWithValue("@Current_position", inputcurrentposition.Text);
                cmdEmployee.Parameters.AddWithValue("@Contact_no", inputcontactnumber.Text);
                cmdEmployee.Parameters.AddWithValue("@ID_number", inputidnumber.Text);
                cmdEmployee.Parameters.AddWithValue("@password", passwordinput.Text);
                cmdEmployee.Parameters.AddWithValue("@Email", inputemail.Text);
                cmdEmployee.Parameters.AddWithValue("@incoe_Last_name", inputincoelastname.Text);
                cmdEmployee.Parameters.AddWithValue("@incoe_First_name", inputincoefirstname.Text);
                cmdEmployee.Parameters.AddWithValue("@incoe_Contact_no", inputincoecontactno.Text);
                cmdEmployee.Parameters.AddWithValue("@incoe_Address", inputincoeaddress.Text);
                cmdEmployee.ExecuteNonQuery();
                con.Close(); 
                MessageBox.Show("Sign-up Successful");
            }
               
                
            
           



        }

        private void signupemployee_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int idnumberrandom = random.Next(100, 999);
            inputidnumber.Text = "24-" + idnumberrandom;
        }
    }
}
