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

        //Load
        private void SignupForm_Load(object sender, EventArgs e)
        {
            // Set placeholder for ComboBox
            //Features.SetComboBoxPlaceholder(cmbFitnessGoal, "Select an option...");
            //Features.SetComboBoxPlaceholder(cmbFitnessLevel, "Select an option...");
            //Features.SetComboBoxPlaceholder(cmbGender, "Select an option...");

            // Align ComboBox text in center
            Features.AlignComboBoxTextCenter(cmbGender);
            Features.AlignComboBoxTextCenter(cmbFitnessGoal);
            Features.AlignComboBoxTextCenter(cmbFitnessLevel);

            // Set placeholder for TextBox


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
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                error.SetError(this.txtWeight, "Please Enter your Weight");
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
            else if (cmbFitnessLevel.SelectedItem == null)
            {
                cmbFitnessLevel.Focus(); //isi pr focus!
                error.SetError(this.cmbFitnessLevel, "Please Enter your Fitness Level");
            }

            //else if (string.IsNullOrEmpty(lblProfilePicturePath.Text))
            //{
            //    lblProfilePicturePath.Focus(); //isi pr focus!
            //    error.SetError(this.lblProfilePicturePath, "Please upload a Profile picture by clicking the Upload Button!");
            //}

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
            DialogResult result = MessageBox.Show("All the input data will be erased!", "Warning", MessageBoxButtons.OKCancel);
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


                ////again k Set placeholder for TextBox b/c reset krne se remove hojate...
                //Features.SetTextBoxPlaceholder(txtUsername, "Enter your name..");
                //Features.SetTextBoxPlaceholder(txtAge, "Enter your Age..");
                //Features.SetTextBoxPlaceholder(txtHeight, "Your height in cm..");
                //Features.SetTextBoxPlaceholder(txtWeight, "Your weight in kg..");
                //Features.SetTextBoxPlaceholder(txtPassword, "Enter your Password..");


                //again Set placeholder for ComboBox b/c reset krne se remove hojate...
                Features.SetComboBoxPlaceholder(cmbFitnessGoal, "Select an option...");
                Features.SetComboBoxPlaceholder(cmbFitnessLevel, "Select an option...");
                Features.SetComboBoxPlaceholder(cmbGender, "Select an option...");

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










    }



}
