using GymAndFitness.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class ProfileForm : BaseForm
    {
        private static ProfileForm instance;
        private ProfileForm()
        {
            InitializeComponent();
        }
        public static ProfileForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProfileForm();
            }
            return instance;
        }



        //LOAD
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            ProfileFormLoadEvents();
        }

        private void ProfileFormLoadEvents()
        {
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
                    lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.CurrentWeight} kg";
                    lblBMI.Text = UserDataManager.CurrentUser.BMI.ToString("F2");
                    lblTargetWeight.Text = $"{UserDataManager.CurrentUser.TargetWeight} kg";
                    lblFitnessGoal.Text = $"💪 {UserDataManager.CurrentUser.FitnessGoal}";
                    lblFitnessLevel.Text = $"🏋️‍♀️ {UserDataManager.CurrentUser.FitnessLevel}";
                    lblTargetWeightRange.Text = UserDataManager.CurrentUser.TargetWeightRange;

                    LoadMembershipStatus_Pic();
                    PremiumFeaturesProfileForm();
                }
                else
                {
                    MessageBox.Show("Error fetching user data.", "Error");
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

        private void LoadMembershipStatus_Pic()
        {
            //load membership plan pics
            pbMembershipStatus.Image = Features.MembershipStatusPic();
            if (UserDataManager.CurrentUser.MembershipStatus == "Free")
            {
                lblMembershipStatus.Text = $"{UserDataManager.CurrentUser.MembershipStatus}";
            }
            else
            {
                lblMembershipStatus.Text = $"{UserDataManager.CurrentUser.MembershipStatus}";
                lblMembershipStatus.ForeColor = Color.Purple;
            }
        }

        public void PremiumFeaturesProfileForm()
        {
            if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
            {
                btnChangeProfilePicture.BackColor = Color.Gray;
            }
            else
            {
                btnChangeProfilePicture.BackColor = Color.DodgerBlue;
                btnGetMembershipPlan.Visible = false;
                pbMembershipStatus.Size = new System.Drawing.Size(55, 51);
                lblMembershipStatus.Location = new System.Drawing.Point(92, 63);
            }
        }

        //profile form.. async programming logic for load events..

        //private async Task ProfileFormLoadEvents()
        //{
        //    if (UserDataManager.CurrentUser != null)
        //    {
        //        // Apply profile picture asynchronously
        //        await Task.Run(() => UserDataManager.ApplyProfilePicture(pbProfilePicture));

        //        // Update numeric controls and user-related UI elements
        //        nudCurrentHeight.Value = (decimal)UserDataManager.CurrentUser.Height;
        //        nudCurrentWeight.Value = (decimal)UserDataManager.CurrentUser.CurrentWeight;

        //        btnLogout.Visible = true;
        //        btnLogout.Enabled = true;
        //        btnLogin.Visible = false;
        //        btnLogin.Enabled = false;

        //        lblUsername.Text = UserDataManager.CurrentUser.Username;
        //        lblAge.Text = UserDataManager.CurrentUser.Age.ToString();
        //        lblGender.Text = UserDataManager.CurrentUser.Gender;
        //        lblHeight.Text = $"{UserDataManager.CurrentUser.Height} cm";
        //        lblStartingWeight.Text = $"{UserDataManager.CurrentUser.StartingWeight} kg";
        //        lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.CurrentWeight} kg";
        //        lblBMI.Text = UserDataManager.CurrentUser.BMI.ToString("F2");
        //        lblTargetWeight.Text = $"{UserDataManager.CurrentUser.TargetWeight} kg";
        //        lblFitnessGoal.Text = UserDataManager.CurrentUser.FitnessGoal;
        //        lblFitnessLevel.Text = UserDataManager.CurrentUser.FitnessLevel;
        //        lblTargetWeightRange.Text = UserDataManager.CurrentUser.TargetWeightRange;

        //        // Membership status handling
        //        lblMembershipStatus.Text = $"{UserDataManager.CurrentUser.MembershipStatus}";

        //        // Load membership plan pictures asynchronously
        //        await Task.Run(() =>
        //        {
        //            pbMembershipStatus.Image = UserDataManager.CurrentUser.MembershipStatus == "Free"
        //                ? Properties.Resources.free3
        //                : UserDataManager.CurrentUser.MembershipStatus == "Premium"
        //                ? Properties.Resources.crown1
        //                : null;
        //        });

        //        if (UserDataManager.CurrentUser.MembershipStatus == "Premium")
        //        {
        //            lblMembershipStatus.ForeColor = Color.Purple;
        //        }
        //        else if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
        //        {
        //            btnChangeProfilePicture.BackColor = Color.Gray;
        //        }
        //    }
        //    else
        //    {

        //        btnLogout.Visible = false;
        //        btnLogout.Enabled = false;
        //        btnLogin.Visible = true;
        //        btnLogin.Enabled = true;

        //        MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        public void ReloadProfileFormData()
        {
            ProfileFormLoadEvents();
        }





        private void btnGetMembershipPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if (UserDataManager.CurrentUser.MembershipStatus == "Premium")
                {
                    MessageBox.Show("You are already a premium Member!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Features.OpenMembershipForm();
                    this.Hide();
                }
                LoadMembershipStatus_Pic();
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    UserDataManager.ChangeProfilePicture(pbProfilePicture);

                    //calling this method: (to refresh profile pictures in each form..)
                    AboutForm.GetInstance().RefreshProfilePictureInForms();
                    BMICalculatorForm.GetInstance().RefreshProfilePictureInForms();
                    DashboardForm.GetInstance().RefreshProfilePictureInForms();
                    DietPlansForm.GetInstance().RefreshProfilePictureInForms();
                    MainForm.GetInstance().RefreshProfilePictureInForms();
                    WorkoutPlansForm.GetInstance().RefreshProfilePictureInForms();


                    MessageBox.Show("Profile Picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DialogResult res = MessageBox.Show("Restart now to see effect? \n\nClick 'Ok' to restart now or 'Cancel' to do this later.", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    //if (res == DialogResult.OK)
                    //{
                    //    Application.Restart();
                    //}
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
                    UserDataManager.UpdateHeightAndWeight(UserDataManager.CurrentUser.Height, UserDataManager.CurrentUser.CurrentWeight, UserDataManager.CurrentUser.BMI);
                    MessageBox.Show("Height and weight updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshPremiumFeaturesProfileForm();
                    DashboardForm.GetInstance().RefreshProgressBarWeight();//to refresh progress bar, everytime the weight/height is updated..
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


        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesProfileForm()
        {
            lblHeight.Text = $"{UserDataManager.CurrentUser.Height} cm";
            lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.CurrentWeight} kg";
            lblBMI.Text = UserDataManager.CurrentUser.BMI.ToString("F2");
            LoadMembershipStatus_Pic();
            PremiumFeaturesProfileForm();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Features.BtnLogout();
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
                        if (UserDataManager.DeleteAccount(UserDataManager.CurrentUser.UserID))
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

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }

    }
}
