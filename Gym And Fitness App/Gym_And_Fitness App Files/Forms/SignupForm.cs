using System;
using System.Drawing.Imaging;
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

        //Load
        private void SignupForm_Load(object sender, EventArgs e)
        {
            // Align ComboBox text in center
            Features.AlignComboBoxTextCenter(cmbGender);
            Features.AlignComboBoxTextCenter(cmbFitnessGoal);
            Features.AlignComboBoxTextCenter(cmbFitnessLevel);

        }

        //private string targetWeightRange = "";
        private double height = 0;


        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus(); //isi pr focus!
                error.SetError(this.txtUsername, "Please Enter your name");
            }
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                txtAge.Focus(); //isi pr focus!
                error.SetError(this.txtAge, "Please Enter your Age");
            }
            else if ((int.Parse(txtAge.Text) < 14) || (int.Parse(txtAge.Text) > 100))
            {
                error.SetError(this.txtAge, "Incorrect age value!");
            }
            else if (cmbGender.SelectedItem == null)
            {
                cmbGender.Focus(); //isi pr focus!
                error.SetError(this.cmbGender, "Please Enter your Gender");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus(); //isi pr focus!
                error.SetError(this.txtPassword, "Please Enter your password");
            }
            else if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must contain atleast 6 characters");
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                error.SetError(this.txtConfirmPassword, "Please Confirm your password");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password and Confirm password must be same!");
            }
            else if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Focus(); //isi pr focus!
                error.SetError(this.txtHeight, "Please Enter your height");
            }
            else if ((double.Parse(txtHeight.Text) < 54.64) || (double.Parse(txtHeight.Text) > 272))
            {
                error.SetError(this.txtHeight, "Incorrect Height info!");
            }
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                error.SetError(this.txtWeight, "Please Enter your Weight");
            }
            else if ((double.Parse(txtWeight.Text) < 10) || (double.Parse(txtWeight.Text) > 600))
            {
                error.SetError(this.txtWeight, "Incorrect Weight info!");
            }
            else if (string.IsNullOrEmpty(txtTargetWeight.Text))
            {
                txtTargetWeight.Focus(); //isi pr focus!
                error.SetError(this.txtTargetWeight, "Please Enter your Weight");
            }
            else if (cmbFitnessGoal.SelectedItem == null)
            {
                cmbFitnessGoal.Focus(); //isi pr focus!
                error.SetError(this.cmbFitnessGoal, "Please Enter your Fitness Goal ");
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
                error.SetError(this.cmbFitnessLevel, "Please Enter your Fitness Level");
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

                userDataManager.SignUpUser(username, password, age, gender, height, weight, bmi, targetWeight, targetWeightRange, fitnessGoal, fitnessLevel, profilePicture, membershipStatus, currentWeight);

            }
        }

        //upload btn
        private void btnUploadPicture_Click(object sender, EventArgs e)
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




        //jab textbox leave krne lage

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnReset_Click(object sender, EventArgs e)
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



        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
        }


        //to remove error from combo boxes

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem != null)
            {
                error.Clear();
            }
        }

        private void cmbFitnessGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFitnessGoal.SelectedItem != null)
            {
                error.Clear();
            }
        }

        private void cmbFitnessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFitnessLevel.SelectedItem != null)
            {
                error.Clear();
            }
        }


        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
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
            //SuggestTargetWeightRange();

        }



        private void txtWeight_Leave(object sender, EventArgs e)
        {
            lblTargetWeightRange.Text = Features.SuggestTargetWeightRange(height);
        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }
    }



}
