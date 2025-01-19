using System;
using System.Configuration;
using System.Data.OleDb; //for ms access
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class LoginForm : Form
    {
        //connection string
        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
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
                errorUsername.SetError(this.txtUsername, "Please Enter your Username ");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus(); //isi pr focus!
                errorPassword.SetError(this.txtPassword, "Please Enter your Password");
            }
            else
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (IsValidLogin(username, password))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    User user = UserDataManager.GetUserDetails(txtUsername.Text);
                    if (user != null && user.Password == txtPassword.Text)
                    {
                        UserDataManager.CurrentUser = user;
                        MessageBox.Show($"Welcome, {UserDataManager.CurrentUser.Username}!");


                        // Open main form

                        // Navigate to MainForm
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = ? AND Password = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
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
            MainForm mainForm = new MainForm();
            mainForm.Show();
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
    }
}
