using System;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class LoginFormClass
    {

        public static void CheckPassword(System.Windows.Forms.CheckBox chkShowPassword, System.Windows.Forms.TextBox txtPassword)
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

        //validate login info
        public static void LoginNow(System.Windows.Forms.TextBox txtUsername, System.Windows.Forms.TextBox txtPassword, ErrorProvider error)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Focus(); //isi pr focus!
                    error.SetError(txtUsername, "Please Enter your Username ");
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus(); //isi pr focus!
                    error.SetError(txtPassword, "Please Enter your Password");
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

                            //opening main form and close login form in forms...btnlogin method event..
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
