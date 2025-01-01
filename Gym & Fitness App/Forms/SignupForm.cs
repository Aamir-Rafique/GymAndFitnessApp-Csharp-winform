using System;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gym___Fitness_App
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        //connection string...
        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;

       


        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus(); //isi pr focus!
                errorUsername.SetError(this.txtUsername, "Please Enter your name");
            }
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                txtAge.Focus(); //isi pr focus!
                errorAge.SetError(this.txtAge, "Please Enter your Age");
            }

            else if (cmbGender.SelectedItem == null)
            {
                cmbGender.Focus(); //isi pr focus!
                errorGender.SetError(this.cmbGender, "Please Enter your Gender");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus(); //isi pr focus!
                errorPassword.SetError(this.txtPassword, "Please Enter your password");
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                errorConfirmPassword.SetError(this.txtConfirmPassword, "Please Confirm your password");
            }

            else if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Focus(); //isi pr focus!
                errorHeight.SetError(this.txtHeight, "Please Enter your height");
            }
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                errorWeight.SetError(this.txtWeight, "Please Enter your Weight");
            }


            else if (cmbFitnessGoal.SelectedItem == null)
            {
                cmbFitnessGoal.Focus(); //isi pr focus!
                errorFitnessGoal.SetError(this.cmbFitnessGoal, "Please Enter your Fitness Goal ");
            }
            else if (cmbFitnessLevel.SelectedItem == null)
            {
                cmbFitnessLevel.Focus(); //isi pr focus!
                errorFitnessLevel.SetError(this.cmbFitnessLevel, "Please Enter your Fitness Level");
            }

            else if (string.IsNullOrEmpty(txtProfilePicturePath.Text))
            {
                txtProfilePicturePath.Focus(); //isi pr focus!
                errorProfilePicturePath.SetError(this.txtProfilePicturePath, "Please upload a Profile picture by clicking the Upload Button!");
            }

            else
            {
                // Collect user inputs
                string username = txtUsername.Text;
                string password = txtPassword.Text; // Consider hashing this
                int age = int.Parse(txtAge.Text);
                string gender = cmbGender.SelectedItem.ToString();
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                double bmi = weight / ((height / 100) * (height / 100)); // Assuming height is in cm

                // Calculate Target Weight Range
                double lowerTargetWeight = 18.5 * Math.Pow((height / 100), 2); // BMI 18.5
                double upperTargetWeight = 24.9 * Math.Pow((height / 100), 2); // BMI 24.9
                string targetWeight = $"{Math.Round(lowerTargetWeight)}kg - {Math.Round(upperTargetWeight)}kg";

                string fitnessGoal = cmbFitnessGoal.SelectedItem.ToString();
                string fitnessLevel = cmbFitnessLevel.SelectedItem.ToString();

                // Handle profile picture // Convert Profile Picture to byte array
                byte[] profilePicture = null;
                if (!string.IsNullOrEmpty(txtProfilePicturePath.Text))
                {
                    profilePicture = File.ReadAllBytes(txtProfilePicturePath.Text);
                }


                // Insert user details into the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SQL query to insert data
                        //Wrap all column names in square brackets to avoid conflicts with reserved keywords.
                        string query = "INSERT INTO Users ([Username], [Password], [Age], [Gender], [Height], [Weight], [BMI], [TargetWeight], [FitnessGoal], [FitnessLevel], [ProfilePicture]) " +
                "VALUES (@Username, @Password, @Age, @Gender, @Height, @Weight, @BMI, @TargetWeight, @FitnessGoal, @FitnessLevel, @ProfilePicture)";


                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Age", age);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Height", height);
                            command.Parameters.AddWithValue("@Weight", weight);
                            command.Parameters.AddWithValue("@BMI", bmi);
                            command.Parameters.AddWithValue("@TargetWeight", targetWeight);
                            command.Parameters.AddWithValue("@FitnessGoal", fitnessGoal);
                            command.Parameters.AddWithValue("@FitnessLevel", fitnessLevel);
                            command.Parameters.AddWithValue("@ProfilePicture", profilePicture ?? (object)DBNull.Value);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Sign-Up Successful!", "Success");

                            // Open the login form and close the current form
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Database Error");
                    }
                }


            }
        }

        //upload btn
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            errorProfilePicturePath.Clear();
            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtProfilePicturePath.Text = openFileDialog.FileName;
                pbProfilePicture.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }




        //jab textbox leave krne lage
        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorAge.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorHeight.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 46)  //ASCII code 46, for period(.)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorWeight.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 46)  //ASCII code 46, for period(.)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorBMI.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 46)  //ASCII code 46, for period(.)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorUsername.Clear();
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)        //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 32)        //ASCII code 46, for space bar
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void cmbFitnessGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void cmbFitnessLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
        private void txtProfilePicturePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtAge.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            cmbFitnessGoal.SelectedItem = null;
            cmbFitnessLevel.SelectedItem = null;
            cmbGender.SelectedItem = null;
            txtProfilePicturePath.Clear();

            pbProfilePicture.Image = Properties.Resources.usernew;

            //to clear erorrs
            errorUsername.Clear();
            errorConfirmPassword.Clear();
            errorPassword.Clear();
            errorAge.Clear();
            errorWeight.Clear();
            errorHeight.Clear();
            errorBMI.Clear();
            errorTargetWeight.Clear();
            errorProfilePicturePath.Clear();
        }



        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                txtConfirmPassword.Focus();
                errorConfirmPassword.SetError(txtConfirmPassword, "Password must be same");
            }
            else
            {
                errorConfirmPassword.Clear();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorPassword.Clear();
        }

        private void txtTargetWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorTargetWeight.Clear();
        }


        //to remove error from combo boxes

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem != null)
            {
                errorGender.Clear();
            }
        }

        private void cmbFitnessGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFitnessGoal.SelectedItem != null)
            {
                errorFitnessGoal.Clear();
            }
        }

        private void cmbFitnessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFitnessLevel.SelectedItem != null)
            {
                errorFitnessLevel.Clear();
            }
        }

        private void txtProfilePicturePath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProfilePicturePath.Text))
            {
                txtProfilePicturePath.Focus(); //isi pr focus!
                errorProfilePicturePath.SetError(this.txtProfilePicturePath, "Please upload a Profile picture by clicking the Upload Button!");
            }
            else
            {
                errorProfilePicturePath.Clear();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
