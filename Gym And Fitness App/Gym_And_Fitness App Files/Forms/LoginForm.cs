﻿using System;
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
                error.SetError(this.txtUsername, "Please Enter your Username ");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus(); //isi pr focus!
                error.SetError(this.txtPassword, "Please Enter your Password");
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (UserDataManager.IsValidLogin(username, password))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    User user = UserDataManager.GetUserDetails(txtUsername.Text);
                    if (user != null && user.Password == txtPassword.Text)
                    {
                        // calling ReloadFormData(); in btnLogin in order to reload form data, at  the time when a user logs in..
                        AboutForm.GetInstance().ReloadAboutFormData();
                        BMICalculatorForm.GetInstance().ReloadBMICalculatorFormData();
                        DashboardForm.GetInstance().ReloadDashboardFormData();
                        DietPlansForm.GetInstance().ReloadDietPlansFormData();
                        MainForm.GetInstance().ReloadMainFormData();
                        ProfileForm.GetInstance().ReloadProfileFormData();
                        WorkoutPlansForm.GetInstance().ReloadWorkoutPlansData();

                        UserDataManager.CurrentUser = user;
                        MessageBox.Show($"Welcome, {UserDataManager.CurrentUser.Username}!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate to MainForm
                        Features.OpenMainForm();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }
    }
}
