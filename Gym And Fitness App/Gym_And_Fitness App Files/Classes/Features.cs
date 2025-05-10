using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace GymAndFitness
{
    public class Features
    {

        //helper method for tooltip at pbProfilePicture

        public static void TooltipProfilePic(ToolTip toolTip,PictureBox picture)
        {
            if (UserDataManager.CurrentUser != null)
            {
                toolTip.SetToolTip(picture, $"{UserDataManager.CurrentUser.Username}'s Profile");
            }
            else
            {
                toolTip.SetToolTip(picture, "Profile");
            }
        }

        //helper method to open external links..
        public static void OpenExternalLink(string url)
        {
            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //method for combo box.. so it could be selected using enter and arrow keys..
        public static void ComboBoxValidation(object sender, KeyPressEventArgs e)
        {
            if (sender is ComboBox cmb)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    cmb.DroppedDown = !cmb.DroppedDown; // Toggle dropdown
                    e.Handled = true; // Prevent default behavior
                }
                else
                {
                    e.Handled = true; // Block typing
                }
            }
        }

        //method to fetch publish version of application (updates with each clickonce deployment)
        public static string GetCurrentVersion()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            return "1.0.0.0";
        }


        //Method to load membership plan status picture

        public static Image MembershipStatusPic()
        {
            if (UserDataManager.CurrentUser.MembershipStatus == "Free")
            {
                return Properties.Resources.free3;
            }
            else if (UserDataManager.CurrentUser.MembershipStatus == "Premium")
            {
                return Properties.Resources.crown1;
            }
            else
            {
                return null;
            }
        }


        // Method to set a placeholder for ComboBox
        //public static void SetComboBoxPlaceholder(ComboBox comboBox, string placeholder)
        //{
        //    comboBox.Items.Insert(0, placeholder);
        //    comboBox.SelectedIndex = 0;
        //    comboBox.ForeColor = Color.Gray;

        //    comboBox.SelectedIndexChanged += (s, e) =>
        //    {
        //        comboBox.ForeColor = comboBox.SelectedIndex == 0 ? Color.Gray : Color.Black;
        //    };
        //}

        // Method to align ComboBox text in center
        public static void AlignComboBoxTextCenter(ComboBox comboBox)
        {
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DrawItem += (s, e) =>
            {
                e.DrawBackground();
                if (e.Index >= 0)
                {
                    string text = comboBox.Items[e.Index].ToString();
                    using (SolidBrush brush = new SolidBrush(comboBox.ForeColor))
                    {
                        e.Graphics.DrawString(text, comboBox.Font, brush,
                            new PointF(e.Bounds.Left + (e.Bounds.Width - e.Graphics.MeasureString(text, comboBox.Font).Width) / 2, e.Bounds.Top));
                    }
                }
            };
        }

        // Method to set a placeholder for TextBox
        public static void SetTextBoxPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }


        //Suggested target weight range..
        public static string SuggestTargetWeightRange(double height)
        {
            double lowerTargetWeight = 18.5 * Math.Pow((height / 100), 2); // BMI 18.5
            double upperTargetWeight = 24.9 * Math.Pow((height / 100), 2); // BMI 24.9
            return $"{Math.Round(lowerTargetWeight)}kg - {Math.Round(upperTargetWeight)}kg";
        }


        //bmi chart needle control
        public static Image GetBMIChartUpdate(double bmi)
        {
            if (bmi < 18.5)
            {
                return Properties.Resources.bmiChartUnderW8;
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return Properties.Resources.bmiChartNormal;
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                return Properties.Resources.bmiChartOverW8;
            }
            else if (bmi >= 30 && bmi <= 35)
            {
                return Properties.Resources.bmiChartObese;
            }
            else
            {
                return Properties.Resources.bmiChartExtremeObese;
            }
        }

        //calculate bmi
        public static double CalculateBMI(double weight, double height)
        {
            height = height / 100; // Convert height from cm to meters
            return weight / (height * height);
        }

        //BMI color code
        public static Color GetBMIColor(double bmi)
        {
            if (bmi < 18.5)
                return Color.DeepSkyBlue;
            else if (bmi >= 18.5 && bmi <= 24.9)
                return Color.SpringGreen;
            else if (bmi >= 25 && bmi <= 29.9)
                return Color.Gold;
            else if (bmi >= 30 && bmi <= 35)
                return Color.Orange;
            else
                return Color.Red;
        }


        //BMI category..
        public static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight!";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal.";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                return "Overweight!";
            }
            else if (bmi >= 30 && bmi <= 35)
            {
                return "Obese!!";
            }
            else
            {
                return "Extremely Obese!!!";
            }
        }

        //variable.. To open each form after login, it must reload it's formload event to reload the data from database...
        //private static bool hasDietPlanReloaded = false, hasMainReloaded = false, hasDashboardReloaded = false, hasWorkoutPlanReloaded = false, hasProfileReloaded = false, hasAboutReloaded = false, hasBMIReloaded = false;

        ////Variables for PRemium features, so that premium features should only be refreshed at the time when user upgrades to premium membership (which can happen only once..) otherwise in "free" , version the method shouldn't be invoked..
        //private static bool hasWorkoutPremRefreshed = false;

        public static void OpenAboutForm()
        {
            AboutForm.GetInstance().Show();
        }

        public static void OpenBMICalculatorForm()
        {
            BMICalculatorForm.GetInstance().Show();
        }

        public static void OpenDashboardForm()
        {
            DashboardForm.GetInstance().Show();
        }



        public static void OpenDietPlansForm()
        {
            ////using this condition so this method refreshes data in form load event only when the user is logged in ...
            //if (UserDataManager.CurrentUser != null && !hasDietPlanReloaded)
            //{
            //    DietPlansForm.GetInstance().ReloadDietPlansFormData();
            //    hasDietPlanReloaded = true; // Set the flag to true after the method is called
            //}
            DietPlansForm.GetInstance().Show();
        }

        public static void OpenLoginForm()
        {
            LoginForm.GetInstance().Show();
        }

        public static void OpenMainForm()
        {
            MainForm.GetInstance().Show();
        }
        public static void OpenMembershipForm()
        {
            MembershipForm.GetInstance().Show();
        }
        public static void OpenPaymentForm()
        {
            PaymentForm.GetInstance().Show();
        }

        public static void OpenProfileForm()
        {
            ProfileForm.GetInstance().Show();
        }

        public static void OpenSignUpForm()
        {
            SignupForm.GetInstance().Show();
        }

        public static void OpenWorkoutPlansForm()
        {
            WorkoutPlansForm.GetInstance().Show();
        }

        public static void LogoutNow()
        {
            UserDataManager.CurrentUser = null;
            Application.Restart(); // Restarts the entire application
        }


    }
}
