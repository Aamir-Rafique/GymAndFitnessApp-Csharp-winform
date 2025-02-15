using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)
        Features features = new Features(); //instance of the class: (Features)

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkShowPassword.Checked;

            switch (check)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    break;
                case false:
                    txtPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus(); //isi pr focus!
                errorUsername.SetError(this.txtUsername, "Please Enter your Username ");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus(); //isi pr focus!
                errorPassword.SetError(this.txtPassword, "Please Enter your Password");
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (userDataManager.IsValidLogin(username, password))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    User user = userDataManager.GetUserDetails(txtUsername.Text);
                    if (user != null && user.Password == txtPassword.Text)
                    {
                        userDataManager.CurrentUser = user;
                        MessageBox.Show($"Welcome, {userDataManager.CurrentUser.Username}!");


                        // Open main form

                        // Navigate to MainForm
                        features.OpenMainForm();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            features.OpenSignUpForm();
            this.Hide();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorUsername.Clear();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorPassword.Clear();
        }

        private void lblGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            features.OpenMainForm();
            this.Close();
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnLogin.PerformClick(); // Trigger the button's click event
            }
        }
    }
}
