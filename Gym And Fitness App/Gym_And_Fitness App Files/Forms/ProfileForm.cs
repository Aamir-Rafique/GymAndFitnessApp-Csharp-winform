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

        //LOAD
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed



            if (UserDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(pbProfilePicture);

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
                    if (UserDataManager.CurrentUser.CurrentWeight.ToString() == null)
                    {
                        lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.StartingWeight} kg";
                    }
                    else
                    {
                        lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.CurrentWeight} kg";
                    }
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

                if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
                {
                    btnChangeProfilePicture.BackColor = Color.Gray;
                }

            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            Features.OpenDashboardForm();
            this.Hide();
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Features.OpenMainForm();
            this.Hide();
        }
        private void btnBMICalculator_Click_1(object sender, EventArgs e)
        {
            Features.OpenBMICalculatorForm();
            this.Hide();
        }
        private void btnDietPlans_Click_1(object sender, EventArgs e)
        {
            Features.OpenDietPlansForm();
            this.Hide();
        }
        private void btnWorkoutPlans_Click_1(object sender, EventArgs e)
        {
            Features.OpenWorkoutPlansForm();
            this.Hide();
        }
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            Features.OpenAboutForm();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }

        private void btnGetMembershipPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                this.Close();

                Features.OpenMembershipForm();
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
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        //change profile pic

        private void btnChangeProfilePicture_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {

                if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
                {
                    MessageBox.Show("Upgrade to Premium to set your desired Profile Picture!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    userDataManager.ChangeProfilePicture(pbProfilePicture);
                }
            }
            else
            {
                MessageBox.Show("You need to login First !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void lblBMI_TextChanged(object sender, EventArgs e)
        {
            double bmi = Double.Parse(lblBMI.Text);
            lblBMI.ForeColor = Features.GetBMIColor(bmi);
            lblBMICategory.ForeColor = Features.GetBMIColor(bmi);
            lblBMICategory.Text = Features.GetBMICategory(bmi);
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

                    UserDataManager.CurrentUser.BMI = Features.CalculateBMI(weight, height);
                    userDataManager.UpdateHeightAndWeight(UserDataManager.CurrentUser.Height, UserDataManager.CurrentUser.CurrentWeight, UserDataManager.CurrentUser.BMI);
                    MessageBox.Show("Height and weight updated successfully! Click on the refresh icon to see the updated records. ", "Success!");
                }
                else
                {
                    MessageBox.Show("Please input correct values for height and weight!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You need to login First !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            Features.OpenLoginForm();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserDataManager.CurrentUser = null;
            Features.OpenLoginForm();
            this.Close();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                string userInput = ShowInputDialog("Confirmation", "Type the word 'Confirm' to confirm account deletion:");
                if (userInput == "Confirm")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (userDataManager.DeleteAccount(UserDataManager.CurrentUser.UserID))
                        {
                            MessageBox.Show("Your account has been deleted successfully.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Features.OpenLoginForm();
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
                    MessageBox.Show("Action canceled or incorrect input.");
                }

            }
            else
            {
                MessageBox.Show("You need to login first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //dialog box for account delete confirmation..
        public static string ShowInputDialog(string title, string message)
        {
            // Create a new form for the input dialog
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Add label to display the message
            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Width = 340,
                Text = message,
                AutoSize = true
            };

            // Add textbox for user input
            TextBox inputBox = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 340
            };

            // Create OK button with DialogResult.OK
            Button confirmationButton = new Button()
            {
                Text = "OK",
                Left = 120,
                Top = 90,
                Width = 80,
                DialogResult = DialogResult.OK
            };

            // Create Cancel button with DialogResult.Cancel
            Button cancelButton = new Button()
            {
                Text = "Cancel",
                Left = 220,
                Top = 90,
                Width = 80,
                DialogResult = DialogResult.Cancel
            };

            // Add event handlers to close the dialog
            confirmationButton.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
            cancelButton.Click += (sender, e) => { prompt.DialogResult = DialogResult.Cancel; prompt.Close(); };

            // Add controls to the form
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmationButton);
            prompt.Controls.Add(cancelButton);

            // Set AcceptButton and CancelButton for keyboard interactions
            prompt.AcceptButton = confirmationButton;
            prompt.CancelButton = cancelButton;

            // Show the dialog and return user input or an empty string if canceled
            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
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
