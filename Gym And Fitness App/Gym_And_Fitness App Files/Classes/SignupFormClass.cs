using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class SignupFormClass
    {
        private static double height = 0;

        public static void SignupNow(TextBox txtUsername, TextBox txtAge, TextBox txtHeight, TextBox txtWeight, TextBox txtTargetWeight, TextBox txtPassword, TextBox txtConfirmPassword, ErrorProvider error, ComboBox cmbGender, ComboBox cmbFitnessGoal, ComboBox cmbFitnessLevel, Label lblTargetWeightRange, Label lblProfilePicturePath, Button btnUploadPicture)
        {

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus(); //isi pr focus!
                error.SetError(txtUsername, "Please Enter your name");


            }
            else if (!UserDataManager.IsUsernameAvailable(txtUsername.Text))
            {
                txtUsername.Focus(); //isi pr focus!
                error.SetError(txtUsername, "This username is already taken!");
            }
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                txtAge.Focus(); //isi pr focus!
                error.SetError(txtAge, "Please Enter your Age");
            }
            else if ((int.Parse(txtAge.Text) < 14) || (int.Parse(txtAge.Text) > 100))
            {
                error.SetError(txtAge, "Incorrect age value!");
            }
            else if (cmbGender.SelectedItem == null)
            {
                cmbGender.Focus(); //isi pr focus!
                error.SetError(cmbGender, "Please Enter your Gender");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus(); //isi pr focus!
                error.SetError(txtPassword, "Please Enter your password");
            }
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must contain atleast 6 characters");
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                error.SetError(txtConfirmPassword, "Please Confirm your password");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password and Confirm password must be same!");
            }
            else if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Focus(); //isi pr focus!
                error.SetError(txtHeight, "Please Enter your height");
            }
            else if ((double.Parse(txtHeight.Text) < 54.64) || (double.Parse(txtHeight.Text) > 272))
            {
                error.SetError(txtHeight, "Incorrect Height info!");
            }
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                error.SetError(txtWeight, "Please Enter your Weight");
            }
            else if ((double.Parse(txtWeight.Text) < 10) || (double.Parse(txtWeight.Text) > 600))
            {
                error.SetError(txtWeight, "Incorrect Weight info!");
            }
            else if (string.IsNullOrEmpty(txtTargetWeight.Text))
            {
                txtTargetWeight.Focus(); //isi pr focus!
                error.SetError(txtTargetWeight, "Please Enter your Weight");
            }
            else if (cmbFitnessGoal.SelectedItem == null)
            {
                cmbFitnessGoal.Focus(); //isi pr focus!
                error.SetError(cmbFitnessGoal, "Please Enter your Fitness Goal ");
            }

            else if ((cmbFitnessGoal.SelectedItem.ToString() == "Muscle Gain") && (double.Parse(txtWeight.Text) > double.Parse(txtTargetWeight.Text)))
            {
                MessageBox.Show("For muscle gain, Target Weight must be greater than Current Weight.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWeight.Focus();
            }

            else if ((cmbFitnessGoal.SelectedItem.ToString() == "Fat Loss") && (double.Parse(txtWeight.Text) < double.Parse(txtTargetWeight.Text)))
            {
                MessageBox.Show("For Fat loss, Target Weight must be smaller than Current Weight.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWeight.Focus();
            }

            else if (cmbFitnessLevel.SelectedItem == null)
            {
                cmbFitnessLevel.Focus(); //isi pr focus!
                error.SetError(cmbFitnessLevel, "Please Enter your Fitness Level");
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
                double targetWeight = double.Parse(txtTargetWeight.Text);
                string targetWeightRange = lblTargetWeightRange.Text;
                string fitnessGoal = cmbFitnessGoal.SelectedItem.ToString();
                string fitnessLevel = cmbFitnessLevel.SelectedItem.ToString();
                string membershipStatus = "Free";
                double currentWeight = weight;

                // Handle profile picture // Convert Profile Picture to byte array
                byte[] profilePicture = null;
                if (!string.IsNullOrEmpty(lblProfilePicturePath.Text))
                {
                    profilePicture = File.ReadAllBytes(lblProfilePicturePath.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to upload profile picture?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        btnUploadPicture.Focus();
                        return;
                    }
                    else
                    {
                        // Convert the resource image to a byte array
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Properties.Resources.usernew.Save(ms, ImageFormat.Png); // Save the image to a memory stream
                            profilePicture = ms.ToArray(); // Convert the memory stream to a byte array
                        }
                    }
                }

                UserDataManager.SignUpUser(username, password, age, gender, height, weight, bmi, targetWeight, targetWeightRange, fitnessGoal, fitnessLevel, profilePicture, membershipStatus, currentWeight);

            }
        }



        public static void SignupFormLoadEvents(ComboBox cmbGender, ComboBox cmbFitnessGoal, ComboBox cmbFitnessLevel)
        {
            // Align ComboBox text in center
            Features.AlignComboBoxTextCenter(cmbGender);
            Features.AlignComboBoxTextCenter(cmbFitnessGoal);
            Features.AlignComboBoxTextCenter(cmbFitnessLevel);
        }

        public static void SetProfilPic(ErrorProvider error, Label lblProfilePicturePath, PictureBox pbProfilePicture)
        {
            error.Clear();
            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblProfilePicturePath.Text = openFileDialog.FileName;
                pbProfilePicture.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }


        public static void TxtAgeKeyValidation(ErrorProvider error, KeyPressEventArgs e)
        {
            error.Clear();
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

        public static void TxtHeightKeyValidation(ErrorProvider error, KeyPressEventArgs e)
        {
            error.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 08)  //08 represents backspace , ASCII code 08, BS or Backspace
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

        public static void TxtWeightKeyValidation(ErrorProvider error, KeyPressEventArgs e, TextBox txtHeight)
        {
            e.Handled = true;
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                MessageBox.Show("For Suggested Target weight range, Please input Height first!");
            }
            error.Clear();
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

        public static void TxtTargetWeightKeyValidation(ErrorProvider error, KeyPressEventArgs e)
        {
            error.Clear();
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

        public static void TxtUsernameKeyValidation(ErrorProvider error, KeyPressEventArgs e)
        {
            error.Clear();
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
            else if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        public static void CheckUsernameAvailability(TextBox txtUsername, Label lblUsernameStatus)
        {
            if (!UserDataManager.IsUsernameAvailable(txtUsername.Text))
            {
                if (!String.IsNullOrEmpty(txtUsername.Text))
                {
                    lblUsernameStatus.ForeColor = Color.Red;
                    lblUsernameStatus.Text = "Username already taken!";
                }
                else
                {
                    lblUsernameStatus.Text = "";
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(txtUsername.Text))
                {
                    lblUsernameStatus.ForeColor = Color.MediumBlue;
                    lblUsernameStatus.Text = "Username available!";
                }
                else
                {
                    lblUsernameStatus.Text = "";
                }
            }
        }


        public static void ResetValuesNow(TextBox txtUsername, TextBox txtAge, TextBox txtHeight, TextBox txtWeight, TextBox txtTargetWeight, TextBox txtPassword, TextBox txtConfirmPassword, ErrorProvider error, ComboBox cmbGender, ComboBox cmbFitnessGoal, ComboBox cmbFitnessLevel, Label lblProfilePicturePath, PictureBox pbProfilePicture)
        {
            DialogResult result = MessageBox.Show("All the input data will be erased!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
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
                lblProfilePicturePath.Text = string.Empty;
                txtTargetWeight.Clear();

                pbProfilePicture.Image = Properties.Resources.usernew;

                //to clear erorrs
                error.Clear();
                error.Clear();
                error.Clear();
                error.Clear();
                error.Clear();
                error.Clear();
                error.Clear();
                error.Clear();
                error.Clear();

                txtUsername.Focus();
            }

        }

        public static void ConfirmPasswordValidation(TextBox txtPassword, TextBox txtConfirmPassword, ErrorProvider error)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                txtConfirmPassword.Focus();
                error.SetError(txtConfirmPassword, "Password must be same");
            }
            else
            {
                error.Clear();
            }
        }


        //txtheight cannot be empty..
        public static void TxtHeightValidation(TextBox txtHeight)
        {
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                MessageBox.Show("Please input your height first");
            }
            else
            {
                height = double.Parse(txtHeight.Text);
            }
        }

        public static void TxtWeightValidation(Label lblTargetWeightRange)
        {
            lblTargetWeightRange.Text = Features.SuggestTargetWeightRange(height);
        }

    }
}
