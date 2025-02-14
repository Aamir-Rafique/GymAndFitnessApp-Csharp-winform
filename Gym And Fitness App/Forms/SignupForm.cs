using System;
using System.IO;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)


        private string targetWeightRange = "";
        private double height = 0;

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
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must contain atleast 6 characters");
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                errorConfirmPassword.SetError(this.txtConfirmPassword, "Please Confirm your password");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password and Confirm password must be same!");
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
            else if (string.IsNullOrEmpty(txtTargetWeight.Text))
            {
                txtTargetWeight.Focus(); //isi pr focus!
                errorTargetWeight.SetError(this.txtTargetWeight, "Please Enter your Weight");
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

            //else if (string.IsNullOrEmpty(lblProfilePicturePath.Text))
            //{
            //    lblProfilePicturePath.Focus(); //isi pr focus!
            //    errorProfilePicturePath.SetError(this.lblProfilePicturePath, "Please upload a Profile picture by clicking the Upload Button!");
            //}

            else
            {
                // Collect user inputs
                string username = txtUsername.Text;
                string password = txtPassword.Text; // Consider hashing this
                int age = int.Parse(txtAge.Text);
                string gender = cmbGender.SelectedItem.ToString();
                height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                double bmi = weight / ((height / 100) * (height / 100)); // Assuming height is in cm
                double targetWeight = double.Parse(txtTargetWeight.Text);

                // Calculate Target Weight Range
                double lowerTargetWeight = 18.5 * Math.Pow((height / 100), 2); // BMI 18.5
                double upperTargetWeight = 24.9 * Math.Pow((height / 100), 2); // BMI 24.9
                targetWeightRange = $"{Math.Round(lowerTargetWeight)}kg - {Math.Round(upperTargetWeight)}kg";

                string fitnessGoal = cmbFitnessGoal.SelectedItem.ToString();
                string fitnessLevel = cmbFitnessLevel.SelectedItem.ToString();

                // Handle profile picture // Convert Profile Picture to byte array
                byte[] profilePicture = null;
                if (!string.IsNullOrEmpty(lblProfilePicturePath.Text))
                {
                    profilePicture = File.ReadAllBytes(lblProfilePicturePath.Text);
                }


                userDataManager.SignUpUser(username, password, age, gender, height, weight, bmi, targetWeight, targetWeightRange, fitnessGoal, fitnessLevel, profilePicture);

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
                lblProfilePicturePath.Text = openFileDialog.FileName;
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
            e.Handled = true;
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                MessageBox.Show("For Suggested Target weight range, Please input Height first!");

            }
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
            else if(char.IsDigit(ch)==true)
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
        private void lblProfilePicturePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTargetWeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            errorTargetWeight.Clear();
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


        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the input data will be erased!");
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

        //private void lblProfilePicturePath_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(lblProfilePicturePath.Text))
        //    {
        //        lblProfilePicturePath.Focus(); //isi pr focus!
        //        errorProfilePicturePath.SetError(this.lblProfilePicturePath, "Please upload a Profile picture by clicking the Upload Button!");
        //    }
        //    else
        //    {
        //        errorProfilePicturePath.Clear();
        //    }
        //}

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                MessageBox.Show("Please input your height first");
            }
            else
            {
                height = double.Parse(txtHeight.Text);
            }
            SuggestTargetWeightRange();

        }

        private void SuggestTargetWeightRange()
        {
            double lowerTargetWeight = 18.5 * Math.Pow((height / 100), 2); // BMI 18.5
            double upperTargetWeight = 24.9 * Math.Pow((height / 100), 2); // BMI 24.9
            targetWeightRange = $"{Math.Round(lowerTargetWeight)}kg - {Math.Round(upperTargetWeight)}kg";
            lblTargetWeightRange.Text = targetWeightRange;
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            SuggestTargetWeightRange();
        }


    }
}
