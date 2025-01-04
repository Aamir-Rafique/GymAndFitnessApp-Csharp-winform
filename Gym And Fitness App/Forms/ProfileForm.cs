using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }


        //LOAD
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed



            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.ApplyProfilePicture(pbProfilePicture);

                nudCurrentHeight.Value = (decimal)UserDataManager.CurrentUser.Height;
                nudCurrentWeight.Value = (decimal)UserDataManager.CurrentUser.CurrentWeight;

                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                if (UserDataManager.CurrentUser != null)
                {
                    lblUsername.Text = UserDataManager.CurrentUser.Username;
                    lblAge.Text = UserDataManager.CurrentUser.Age.ToString();
                    lblGender.Text = UserDataManager.CurrentUser.Gender;
                    lblHeight.Text = $"{UserDataManager.CurrentUser.Height} cm";
                    lblStartingWeight.Text = $"{UserDataManager.CurrentUser.StartingWeight} kg";
                    lblCurrentWeight.Text = lblStartingWeight.Text;
                    lblBMI.Text = UserDataManager.CurrentUser.BMI.ToString("F2");
                    lblTargetWeight.Text = $"{UserDataManager.CurrentUser.TargetWeight} kg";
                    lblFitnessGoal.Text = UserDataManager.CurrentUser.FitnessGoal;
                    lblFitnessLevel.Text = UserDataManager.CurrentUser.FitnessLevel;
                    lblTargetWeightRange.Text = UserDataManager.CurrentUser.TargetWeightRange;


                    //membership status
                    lblMembershipStatus.Text = $"{UserDataManager.CurrentUser.MembershipStatus}";
                }
                else
                {
                    MessageBox.Show("Error fetching user data.", "Error");
                }


                //load membership plan pics
                if (lblMembershipStatus.Text == "Free")
                {
                    pbMembershipStatus.Image = Properties.Resources.free3;
                }
                else if (lblMembershipStatus.Text == "Premium")
                {
                    lblMembershipStatus.ForeColor = Color.Purple;
                    pbMembershipStatus.Image = Properties.Resources.crown1;
                }
                else
                {
                    pbMembershipStatus.Image = null;
                }


            }
            else
            {
                MessageBox.Show("No user is logged in.");

                btnLogout.Visible = false;
                btnLogout.Enabled = false;
                btnLogin.Visible = true;
                btnLogin.Enabled = true;

            }

        }




        //for slide panel
        private bool isPanelCollapsed = true; // Track panel state
        private int panelWidth; // Store the panel's default width


        //slide  panel timer 
        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelCollapsed)
            {
                //pnlMain.BackColor = Color.LimeGreen; //change the color of main panel
                slidePanel.Width += 7; // Expand the panel
                if (slidePanel.Width >= panelWidth)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = false; // Panel is now expanded
                }
            }
            else
            {
                //pnlMain.BackColor = Color.LightGreen; //change the color of main panel
                slidePanel.Width -= 7; // Collapse the panel
                if (slidePanel.Width <= 45)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = true; // Panel is now collapsed
                }
            }
        }

        //menu
        private void btnToggle_Click_1(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
            slidePanel.BringToFront();  //to remove glitches while sliding
        }





        //go back to dashboard
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }


        //home Button
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        //bmi calculator button
        private void btnBMICalculator_Click_1(object sender, EventArgs e)
        {
            BMICalculatorForm bmiCalculator = new BMICalculatorForm();
            bmiCalculator.Show();
            this.Hide();
        }

        //dietplan form
        private void btnDietPlans_Click_1(object sender, EventArgs e)
        {
            DietPlansForm dietPlans = new DietPlansForm();
            dietPlans.Show();
            this.Hide();
        }

        //WorkoutPlan form
        private void btnWorkoutPlans_Click_1(object sender, EventArgs e)
        {
            WorkoutPlansForm workoutPlans = new WorkoutPlansForm();
            workoutPlans.Show();
            this.Hide();
        }




        // About Form
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnGetMembershipPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                this.Close();

                MembershipForm membershipForm = new MembershipForm();
                membershipForm.ShowDialog();

                lblMembershipStatus.Text = $"{UserDataManager.CurrentUser.MembershipStatus}";

                //membership pln pic
                //load membership plan pics
                if (lblMembershipStatus.Text == "Free")
                {
                    pbMembershipStatus.Image = Properties.Resources.free3;
                }
                else if (lblMembershipStatus.Text == "Premium")
                {
                    pbMembershipStatus.Image = Properties.Resources.crown1;
                    lblMembershipStatus.ForeColor = Color.Purple;
                }
                else
                {
                    pbMembershipStatus.Image = null;
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }

        }


        //change profile pic

        private void btnChangeProfilePicture_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.ChangeProfilePicture(pbProfilePicture);

                //using (OpenFileDialog openFileDialog = new OpenFileDialog())
                //{
                //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; if (openFileDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        string selectedFilePath = openFileDialog.FileName; byte[] profilePicture = File.ReadAllBytes(selectedFilePath);
                //        // Update the profile picture in the PictureBox
                //        using (MemoryStream ms = new MemoryStream(profilePicture))
                //        {
                //            pbProfilePicture.Image = Image.FromStream(ms);
                //        }
                //        // Save the new profile picture
                //        UserDataManager.UpdateProfilePictureInDatabase(profilePicture);
                //    }
                //}
            }
            else
            {
                MessageBox.Show("You need to login First !");
            }
        }


        private Color GetBMIColor(double bmi)
        {
            if (bmi < 18.5)
                return Color.Blue;
            else if (bmi >= 18.5 && bmi <= 24.9)
                return Color.Green;
            else if (bmi >= 25 && bmi <= 29.9)
                return Color.YellowGreen;
            else if (bmi >= 30 && bmi <= 35)
                return Color.DarkOrange;
            else
                return Color.Red;
        }


        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight!";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "Normal.";
            else if (bmi >= 25 && bmi <= 29.9)
                return "Overweight!";
            else if (bmi >= 30 && bmi <= 35)
                return "Obese!!";
            else
                return "Extremely Obese!!!";
        }

        private void lblBMI_TextChanged(object sender, EventArgs e)
        {
            double bmi = Double.Parse(lblBMI.Text);
            lblBMI.ForeColor = GetBMIColor(bmi);
            lblBMICategory.Text = GetBMICategory(bmi);
        }

        private void btnSaveCurrentHeightAndWeight_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if ((nudCurrentWeight.Value >= 0 && nudCurrentWeight.Value <= 250) && (nudCurrentHeight.Value >= 0 && nudCurrentHeight.Value <= 270))
                {
                    UserDataManager.CurrentUser.CurrentWeight = (double)nudCurrentWeight.Value;
                    UserDataManager.CurrentUser.Height = (double)nudCurrentHeight.Value;

                    double height = (double)nudCurrentHeight.Value;
                    double weight = (double)nudCurrentWeight.Value;

                    UserDataManager.CurrentUser.BMI = CalculateBMI(height, weight);
                    UserDataManager.UpdateHeightAndWeight(UserDataManager.CurrentUser.Height, UserDataManager.CurrentUser.CurrentWeight, UserDataManager.CurrentUser.BMI);
                    MessageBox.Show("Height and weight updated successfully!", "Success!");
                }
                else
                {
                    MessageBox.Show("Aree Bhai height or weight ki correct values put karo!");
                }
            }
            else
            {
                MessageBox.Show("You need to login First !");
            }
        }


        private double CalculateBMI(double height, double weight)
        {
            height = height / 100; // Convert height from cm to meters
            return weight / (height * height);

        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                lblHeight.Text = $"{UserDataManager.CurrentUser.Height} cm";
                lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.CurrentWeight} kg";
                lblBMI.Text = UserDataManager.CurrentUser.BMI.ToString("F2");
                lblMembershipStatus.Text = $"{UserDataManager.CurrentUser.MembershipStatus}";

            }
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            toolTipRefresh.SetToolTip(btnRefresh, "Refresh");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserDataManager.CurrentUser = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                // Confirmation dialog
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to delete your account? This action cannot be undone.",
                    "Delete Account",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {


                    if (UserDataManager.DeleteAccount(UserDataManager.CurrentUser.UserID))
                    {


                        MessageBox.Show("Your account has been deleted successfully.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting your account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // User canceled password input
                    MessageBox.Show("Account deletion aborted.", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Wah bhai Login kia nahi, or chle account ko delete krne 😒");
            }
        }

     
    }
}
