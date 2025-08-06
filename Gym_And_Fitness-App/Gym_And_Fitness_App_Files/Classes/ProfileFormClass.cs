using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class ProfileFormClass
    {
        public static void ProfileFormLoadEvents(PictureBox pbProfilePicture, NumericUpDown nudCurrentHeight, NumericUpDown nudCurrentWeight, Button btnLogout, Button btnLogin, Label lblUsername, Label lblAge, Label lblGender, Label lblHeight, Label lblStartingWeight, Label lblCurrentWeight, Label lblBMI, Label lblTargetWeight, Label lblFitnessGoal, Label lblFitnessLevel, Label lblTargetWeightRange, PictureBox pbMembershipStatus, Label lblMembershipStatus, Button btnChangeProfilePicture, Button btnGetMembershipPlan, PictureBox pbPremiumVerified)
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

                    LoadMembershipStatus_Pic(pbMembershipStatus, lblMembershipStatus);
                    PremiumFeaturesProfileForm(btnChangeProfilePicture, btnGetMembershipPlan, pbMembershipStatus, lblMembershipStatus, pbPremiumVerified);
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

        public static void LoadMembershipStatus_Pic(PictureBox pbMembershipStatus, Label lblMembershipStatus)
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

        public static void PremiumFeaturesProfileForm(Button btnChangeProfilePicture, Button btnGetMembershipPlan, PictureBox pbMembershipStatus, Label lblMembershipStatus, PictureBox pbPremiumVerified)
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
                pbPremiumVerified.Visible = true;
            }
        }


        public static void GetMembershipPlan(PictureBox pbMembershipStatus, Label lblMembershipStatus)
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
                    ProfileForm.GetInstance().Hide();
                }

                LoadMembershipStatus_Pic(pbMembershipStatus, lblMembershipStatus);
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        public static void ChangeProfilePic(PictureBox pbProfilePicture)
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

                }
            }
            else
            {
                MessageBox.Show("You need to login First !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public static void BMIValueChanged(Label lblBMI, Label lblBMICategory)
        {
            double bmi = Double.Parse(lblBMI.Text);
            lblBMI.ForeColor = Features.GetBMIColor(bmi);
            lblBMICategory.ForeColor = Features.GetBMIColor(bmi);
            lblBMICategory.Text = Features.GetBMICategory(bmi);
        }


        public static void SaveHeightAndWeight(NumericUpDown nudCurrentWeight, NumericUpDown nudCurrentHeight, Label lblHeight, Label lblCurrentWeight, Label lblBMI, PictureBox pbMembershipStatus, Label lblMembershipStatus, Button btnChangeProfilePicture, Button btnGetMembershipPlan)
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

                    ProfileForm.GetInstance().RefreshPremiumFeaturesProfileForm();
                    DashboardForm.GetInstance().RefreshProgressBarWeight();
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




        public static void DeleteAccount()
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
                            ProfileForm.GetInstance().Hide();
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





    }
}
