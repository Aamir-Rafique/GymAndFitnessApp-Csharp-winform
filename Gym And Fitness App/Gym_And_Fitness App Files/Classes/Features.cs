using System;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;


namespace GymAndFitness
{
    public static class Features
    {

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

        //To open each form...
        private static bool hasDietPlanReloaded = false, hasMainReloaded = false, hasDashboardReloaded = false, hasWorkoutPlanReloaded = false, hasProfileReloaded = false, hasAboutReloaded = false, hasBMIReloaded = false;

        public static void OpenAboutForm()
        {
            if (UserDataManager.CurrentUser != null && !hasAboutReloaded)
            {
                AboutForm.GetInstance().ReloadAboutFormData();
                hasAboutReloaded = true; // Set the flag to true after the method is called
            }
            AboutForm.GetInstance().Show();
            AboutForm.GetInstance().BringToFront();

        }

        public static void OpenBMICalculatorForm()
        {
            if (UserDataManager.CurrentUser != null && !hasBMIReloaded)
            {
                BMICalculatorForm.GetInstance().ReloadBMICalculatorFormData();
                hasBMIReloaded = true; // Set the flag to true after the method is called
            }
            BMICalculatorForm.GetInstance().Show();
            BMICalculatorForm.GetInstance().BringToFront();
        }

        public static void OpenDashboardForm()
        {
            if (UserDataManager.CurrentUser != null && !hasDashboardReloaded)
            {
                DashboardForm.GetInstance().ReloadDashboardFormData();
                hasDashboardReloaded = true; // Set the flag to true after the method is called
            }
            DashboardForm.GetInstance().Show();
            DashboardForm.GetInstance().BringToFront();
        }

        

        public static void OpenDietPlansForm()
        {
            //using this condition so this method refreshes data in form load event only when the user is logged in ...
            if (UserDataManager.CurrentUser != null && !hasDietPlanReloaded)
            {
                DietPlansForm.GetInstance().ReloadDietPlansFormData();
                hasDietPlanReloaded = true; // Set the flag to true after the method is called
            }
            DietPlansForm.GetInstance().Show();
            DietPlansForm.GetInstance().BringToFront();
        }

        public static void OpenLoginForm()
        {
            LoginForm.GetInstance().Show();
            LoginForm.GetInstance().BringToFront();
        }

        public static void OpenMainForm()
        {
            if (UserDataManager.CurrentUser != null && !hasMainReloaded)
            {
                MainForm.GetInstance().ReloadMainFormData();
                hasMainReloaded = true; // Set the flag to true after the method is called
            }
            MainForm.GetInstance().Show();
            MainForm.GetInstance().BringToFront();
        }
        public static void OpenMembershipForm()
        {
            MembershipForm membershipForm = new MembershipForm();
            membershipForm.ShowDialog();
        }
        public static void OpenPaymentForm()
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }
        public static void OpenPremiumForm()
        {
            PremiumForm premiumForm = new PremiumForm();
            premiumForm.Show();
        }
        public static void OpenProfileForm()
        {
            if (UserDataManager.CurrentUser != null && !hasProfileReloaded)
            {
                ProfileForm.GetInstance().ReloadProfileFormData();
                hasProfileReloaded = true; // Set the flag to true after the method is called
            }
            ProfileForm.GetInstance().Show();
            ProfileForm.GetInstance().BringToFront();
        }
        public static void OpenSignUpForm()
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }
        public static void OpenWorkoutPlansForm()
        {
            if (UserDataManager.CurrentUser != null && !hasWorkoutPlanReloaded)
            {
                WorkoutPlansForm.GetInstance().ReloadWorkoutPlansData();
                hasWorkoutPlanReloaded = true; // Set the flag to true after the method is called
            }
            WorkoutPlansForm.GetInstance().Show();
            WorkoutPlansForm.GetInstance().BringToFront();
        }

        public static void LogoutNow()
        {
            UserDataManager.CurrentUser = null;
            Application.Restart(); // Restarts the entire application
        }


    }
}
