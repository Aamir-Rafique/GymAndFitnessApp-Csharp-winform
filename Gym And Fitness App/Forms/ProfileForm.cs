using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)
        Features features = new Features(); //instance of the class: (Features)



        //LOAD
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed



            if (userDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(pbProfilePicture);

                nudCurrentHeight.Value = (decimal)userDataManager.CurrentUser.Height;
                nudCurrentWeight.Value = (decimal)userDataManager.CurrentUser.CurrentWeight;

                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                if (userDataManager.CurrentUser != null)
                {
                    lblUsername.Text = userDataManager.CurrentUser.Username;
                    lblAge.Text = userDataManager.CurrentUser.Age.ToString();
                    lblGender.Text = userDataManager.CurrentUser.Gender;
                    lblHeight.Text = $"{userDataManager.CurrentUser.Height} cm";
                    lblStartingWeight.Text = $"{userDataManager.CurrentUser.StartingWeight} kg";
                    lblCurrentWeight.Text = lblStartingWeight.Text;
                    lblBMI.Text = userDataManager.CurrentUser.BMI.ToString("F2");
                    lblTargetWeight.Text = $"{userDataManager.CurrentUser.TargetWeight} kg";
                    lblFitnessGoal.Text = userDataManager.CurrentUser.FitnessGoal;
                    lblFitnessLevel.Text = userDataManager.CurrentUser.FitnessLevel;
                    lblTargetWeightRange.Text = userDataManager.CurrentUser.TargetWeightRange;


                    //membership status
                    lblMembershipStatus.Text = $"{userDataManager.CurrentUser.MembershipStatus}";
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





        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            features.OpenDashboardForm();
            this.Hide();
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            features.OpenMainForm();
            this.Hide();
        }
        private void btnBMICalculator_Click_1(object sender, EventArgs e)
        {
            features.OpenBMICalculatorForm();
            this.Hide();
        }
        private void btnDietPlans_Click_1(object sender, EventArgs e)
        {
            features.OpenDietPlansForm();
            this.Hide();
        }
        private void btnWorkoutPlans_Click_1(object sender, EventArgs e)
        {
            features.OpenWorkoutPlansForm();
            this.Hide();
        }
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            features.OpenAboutForm();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            features.OpenDashboardForm();
            this.Hide();
        }

        private void btnGetMembershipPlan_Click(object sender, EventArgs e)
        {
            if (userDataManager.CurrentUser != null)
            {
                this.Close();

                features.OpenMembershipForm();
                lblMembershipStatus.Text = $"{userDataManager.CurrentUser.MembershipStatus}";

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
            if (userDataManager.CurrentUser != null)
            {
                userDataManager.ChangeProfilePicture(pbProfilePicture);
            }
            else
            {
                MessageBox.Show("You need to login First !");
            }
        }


      
        private void lblBMI_TextChanged(object sender, EventArgs e)
        {
            double bmi = Double.Parse(lblBMI.Text);
            lblBMI.ForeColor = features.GetBMIColor(bmi);
            lblBMICategory.Text = features.GetBMICategory(bmi);
        }

        private void btnSaveCurrentHeightAndWeight_Click(object sender, EventArgs e)
        {
            if (userDataManager.CurrentUser != null)
            {
                if ((nudCurrentWeight.Value >= 0 && nudCurrentWeight.Value <= 250) && (nudCurrentHeight.Value >= 0 && nudCurrentHeight.Value <= 270))
                {
                    userDataManager.CurrentUser.CurrentWeight = (double)nudCurrentWeight.Value;
                    userDataManager.CurrentUser.Height = (double)nudCurrentHeight.Value;

                    double height = (double)nudCurrentHeight.Value;
                    double weight = (double)nudCurrentWeight.Value;

                    userDataManager.CurrentUser.BMI = features.CalculateBMI(height, weight);
                    userDataManager.UpdateHeightAndWeight(userDataManager.CurrentUser.Height, userDataManager.CurrentUser.CurrentWeight, userDataManager.CurrentUser.BMI);
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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (userDataManager.CurrentUser != null)
            {
                lblHeight.Text = $"{userDataManager.CurrentUser.Height} cm";
                lblCurrentWeight.Text = $"{userDataManager.CurrentUser.CurrentWeight} kg";
                lblBMI.Text = userDataManager.CurrentUser.BMI.ToString("F2");
                lblMembershipStatus.Text = $"{userDataManager.CurrentUser.MembershipStatus}";

            }
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            toolTipRefresh.SetToolTip(btnRefresh, "Refresh");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            features.OpenLoginForm();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            userDataManager.CurrentUser = null;
            features.OpenLoginForm();
            this.Close();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (userDataManager.CurrentUser != null)
            {
                // Confirmation dialog
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to delete your account? This action cannot be undone.",
                    "Delete Account",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    if (userDataManager.DeleteAccount(userDataManager.CurrentUser.UserID))
                    {
                        MessageBox.Show("Your account has been deleted successfully.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        features.OpenLoginForm();
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

        private void nudCurrentWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnSaveCurrentHeightAndWeight.PerformClick(); // Trigger the button's click event
            }
        }

        private void nudCurrentHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnSaveCurrentHeightAndWeight.PerformClick(); // Trigger the button's click event
            }
        }
    }
}
