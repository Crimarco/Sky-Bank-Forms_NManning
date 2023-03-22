using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Sky_Bank_Forms
{
    public partial class FrmClientAccessPortal : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dataReader;

        public FrmClientAccessPortal()
        {
            InitializeComponent();
    
        }
        // searches form for blank fields using a recursive call
        public void ClearFormData(Control.ControlCollection ctrlCol)
        {
            // traverses through each control on the form
            foreach(Control ctrl in ctrlCol)
            {
                // checks whether the control is a textbox
                if(ctrl is TextBoxBase) 
                {
                    // clears the textbox
                    ctrl.Text = String.Empty;
                }
                else
                {
                    //repeats the action above 
                    ClearFormData(ctrl.Controls);
                }    
            }
        }
        // this method uses regular expression to set the range of valid email characters
        public bool IsValidEmail(string emailAddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailAddress);
            return match.Success;  // returns true or false if email matches regular expression
        }

        // this method uses regular expression to set the range of valid contact number characters
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            Regex reg = new Regex(@"^\(\d{3}\)\d{3}-\d{4}$");
            return reg.IsMatch(phoneNumber);
        }

        private void SetFocusToNextEmptyField(Control.ControlCollection ctrlCol)
        {
            // traverses through each control on the form
            foreach (Control ctrl in ctrlCol)
            {
                // checks whether the control is a textbox
                if (ctrl is TextBoxBase && ctrl.Text != String.Empty)
                {
                    // clears the textbox
                   ctrl.Focus();
                }
                else
                {
                    //repeats the action above 
                   SetFocusToNextEmptyField(ctrl.Controls);
                }
            }
        }
        // this method shows the signUp form above the signIn form
        private void btn_signup_Click(object sender, EventArgs e)
        {
            pnl_clsignup.BringToFront();
        }

        // this method hides the clientSignin form, brings the clientSignUp form to front and shows it
        private void btn_clsignup_Click(object sender, EventArgs e)
        {
            pnl_clsignin.Hide();
            pnl_clsignup.Show();
            pnl_clsignup.BringToFront();
        }
        // this method hides the clientSignUp form, brings the clientSignIn form to front and shows it
        private void btn_signin_Click(object sender, EventArgs e)
        {
            pnl_clsignup.Hide();
            pnl_clsignin.Show();
            pnl_clsignin.BringToFront();
        }

        // this method show the  welcome window when the back button is clicked
        private void btn_back_Click(object sender, EventArgs e)
        {
            Welcome_Page objwelcome = new Welcome_Page();
            objwelcome.Show();
            this.Close();
        }
      
        // this method toggles between showing and hiding the password fields when checked
        private void CkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_ShowPassword.Checked)
            {
                txtBx_password.UseSystemPasswordChar = false;
                txtBx_conpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBx_password.UseSystemPasswordChar = true;
                txtBx_conpassword.UseSystemPasswordChar = true;
            }
        }
        // this method validates all fields before registering the user
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string cmdString1 = "select * from LoginTable where Username='" + txtBx_username.Text + "'";
            string cmdString2 = "insert into LoginTable values (@FirstName, @LastName, @Username, @EmailAddress, @TelephoneNumber, @Password)";

            bool validEmail = IsValidEmail(txtBx_email.Text);
            bool validContactNumber = ValidatePhoneNumber(txtBx_tele.Text);
            SetFocusToNextEmptyField(this.Controls);

            // checks whether any text field has data
            if (!string.IsNullOrEmpty(txtBx_firstname.Text) && !string.IsNullOrEmpty(txtBx_lastname.Text)
                        && !string.IsNullOrEmpty(txtBx_username.Text) && !string.IsNullOrEmpty(txtBx_email.Text)
                        && !string.IsNullOrEmpty(txtBx_conemail.Text) && !string.IsNullOrEmpty(txtBx_password.Text)
                        && !string.IsNullOrEmpty(txtBx_conpassword.Text) && !string.IsNullOrEmpty(txtBx_tele.Text))
            {
                // checks whether the email and the password entered are identical when confirmed
                if (txtBx_password.Text == txtBx_conpassword.Text && txtBx_email.Text == txtBx_conemail.Text && validEmail
                    && validContactNumber)
                {
                    cmd = new SqlCommand(cmdString1, conn);
                    dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        dataReader.Close();
                        MessageBox.Show("Username already exists. Please try another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        dataReader.Close();
                        cmd = new SqlCommand(cmdString2, conn);
                        cmd.Parameters.AddWithValue("FirstName", txtBx_firstname.Text);
                        cmd.Parameters.AddWithValue("LastName", txtBx_lastname.Text);
                        cmd.Parameters.AddWithValue("Username", txtBx_username.Text);
                        cmd.Parameters.AddWithValue("EmailAddress", txtBx_email.Text);
                        cmd.Parameters.AddWithValue("TelephoneNumber", txtBx_email.Text);
                        cmd.Parameters.AddWithValue("Password", txtBx_password.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Your account was successfully created. You may now login.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // invokes the method the clears all fields on the form
                        ClearFormData(this.Controls);
                        pnl_clsignin.Show();
                        pnl_clsignin.BringToFront();
                    }

                }
                // checks and showsan error message if the email is invalid
                if (!validEmail) MessageBox.Show("Invalid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // checks and shows an error message for unmatched passwords;
                if (txtBx_password.Text != txtBx_conpassword.Text)
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // checks and shows an error message for unmatched emails
                if (txtBx_email.Text != txtBx_conemail.Text)
                    MessageBox.Show("emails do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!validContactNumber)
                    MessageBox.Show("Invalid Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Empty fields are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // this method loads with preset behaviors for other methods with the class 
        private void FrmClientAccessPortal_Load(object sender, EventArgs e)
        {
            // creates connection to local database
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Nathaniel Manning\Desktop\Sky Bank\ClientDatabase.mdf"";Integrated Security=True");
            conn.Open();
            txtBx_password.UseSystemPasswordChar = true;
            txtBx_conpassword.UseSystemPasswordChar = true;
            TxtBxSignInPassword.UseSystemPasswordChar = true;

        }
        // this method signs in the client to the system's database
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            // checks whether the fields password or username are empty
            if(TxtBxSignInPassword.Text != string.Empty || TxtBxSignInUserName.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from LoginTable where username='" + TxtBxSignInUserName.Text + "' and password='" + txtBx_password.Text + "'", conn);
                dataReader = cmd.ExecuteReader();
                if(dataReader.Read())
                {
                    dataReader.Close();
                    this.Hide();
                    Client_Profile clientProfile = new Client_Profile();
                    clientProfile.Show();
    
                }
                else
                {
                    dataReader.Close();
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFormData(this.Controls);

                }

            }
            else
            {
                MessageBox.Show("Empty fields are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CkbxSignInShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbxSignInShowPassword.Checked)
            {
                TxtBxSignInPassword.UseSystemPasswordChar = false;
                TxtBxSignInPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtBxSignInPassword.UseSystemPasswordChar = true;
                TxtBxSignInPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
