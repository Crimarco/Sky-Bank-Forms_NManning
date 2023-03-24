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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Sky_Bank_Forms
{
    public partial class FrmClientAccessPortal : Form
    {
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
            string filePath = @"C:\Users\Nathaniel Manning\Desktop\Sky Bank\Registration.txt";
            bool duplicateRecordFound = false;

            bool validEmail = IsValidEmail(txtBx_email.Text);
            bool validContactNumber = ValidatePhoneNumber(txtBx_tele.Text);
            SetFocusToNextEmptyField(this.Controls);

            // checks whether any text field has data
            if (!string.IsNullOrEmpty(txtBx_firstname.Text) && !string.IsNullOrEmpty(txtBx_lastname.Text)
                && !string.IsNullOrEmpty(txtBx_username.Text) && !string.IsNullOrEmpty(txtBx_email.Text)
                && !string.IsNullOrEmpty(txtBx_conemail.Text) && !string.IsNullOrEmpty(txtBx_password.Text)
                && !string.IsNullOrEmpty(txtBx_conpassword.Text) && !string.IsNullOrEmpty(txtBx_tele.Text))
            {
                // checks that email and password confirmations match
                if (txtBx_password.Text == txtBx_conpassword.Text && txtBx_email.Text == txtBx_conemail.Text && validEmail
                    && validContactNumber)
                {
                    // Check for duplicate records in the file
                    string[] lines = File.Exists(filePath) ? File.ReadAllLines(filePath) : new string[0];
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data[3] == txtBx_email.Text)
                        {
                            duplicateRecordFound = true;
                            MessageBox.Show("Email already exists. Please try another email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (data[2] == txtBx_username.Text)
                        {
                            duplicateRecordFound = true;
                            MessageBox.Show("Username already exists. Please try another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (!duplicateRecordFound)
                    {
                        // Add new user record to the file
                        using (StreamWriter writer = File.AppendText(filePath))
                        {
                            writer.WriteLine($"{txtBx_firstname.Text},{txtBx_lastname.Text},{txtBx_username.Text},{txtBx_email.Text},{txtBx_password.Text},{txtBx_tele.Text}");
                            MessageBox.Show("Your account was successfully created. You may now login.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormData(this.Controls);
                            pnl_clsignin.Show();
                            pnl_clsignin.BringToFront();
                        }
                    }
                }

                // checks and shows an error message if the email is invalid
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
            pnl_clsignup.Enabled = true;
        }


        // this method loads with preset behaviors for other methods with the class 
        private void FrmClientAccessPortal_Load(object sender, EventArgs e)
        {
            txtBx_password.UseSystemPasswordChar = true;
            txtBx_conpassword.UseSystemPasswordChar = true;
            TxtBxSignInPassword.UseSystemPasswordChar = true;
        }

        // this method signs in the client to the system's database
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Nathaniel Manning\Desktop\Sky Bank\Registration.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No registration records found. Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // checks whether the fields password or username are empty
            if (!string.IsNullOrEmpty(TxtBxSignInPassword.Text) && !string.IsNullOrEmpty(TxtBxSignInUserName.Text))
            {
                bool loginSuccess = false;

                // reads all lines from the text file and loops through them to find a matching record
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    if (fields[2] == TxtBxSignInUserName.Text && fields[4] == TxtBxSignInPassword.Text)
                    {
                        loginSuccess = true;
                        break;
                    }
                }

                // if the login is successful, hide the login form and show the client profile form
                if (loginSuccess)
                {
                    this.Hide();
                    Client_Profile clientProfile = new Client_Profile();
                    clientProfile.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFormData(this.Controls);
                }
            }
            else
            {
                MessageBox.Show("Empty fields are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnl_clsignin.Enabled = true;
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
