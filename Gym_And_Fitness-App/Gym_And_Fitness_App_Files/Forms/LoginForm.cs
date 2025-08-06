using GymAndFitness.Classes;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class LoginForm : Form
    {

        private static LoginForm instance;
        public LoginForm()
        {
            InitializeComponent();
        }
        public static LoginForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginForm();
            }
            return instance;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            LoginFormClass.CheckPassword(chkShowPassword, txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginFormClass.LoginNow(txtUsername, txtPassword, error);

            if (UserDataManager.CurrentUser != null)
            {
                // Navigate to MainForm
                Features.OpenMainForm();
                this.Hide();
            }
        }



        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Features.OpenSignUpForm();
            this.Hide();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
        }

        private void lblGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Features.OpenMainForm();
            this.Hide();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }



    }
}
