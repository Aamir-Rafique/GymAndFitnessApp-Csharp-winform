using System;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;


namespace GymAndFitness
{
    public class Features
    {

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
        public static void SetComboBoxPlaceholder(ComboBox comboBox, string placeholder)
        {
            comboBox.Items.Insert(0, placeholder);
            comboBox.SelectedIndex = 0;
            comboBox.ForeColor = Color.Gray;

            comboBox.SelectedIndexChanged += (s, e) =>
            {
                comboBox.ForeColor = comboBox.SelectedIndex == 0 ? Color.Gray : Color.Black;
            };
        }

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
        public static void OpenAboutForm()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        public static void OpenBMICalculatorForm()
        {
            BMICalculatorForm bmiCalculator = new BMICalculatorForm();
            bmiCalculator.Show();
        }

        public static void OpenDashboardForm()
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
        }

        public static void OpenDietPlansForm()
        {
            DietPlansForm dietPlans = new DietPlansForm();
            dietPlans.Show();
        }

        public static void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.Focus();
        }
        public static void OpenMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        public static void OpenMembershipForm()
        {
            MembershipForm membershipForm = new MembershipForm();
            membershipForm.Show();
        }
        public static void OpenPaymentForm()
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            paymentForm.Focus();
        }
        public static void OpenPremiumForm()
        {
            PremiumForm premiumForm = new PremiumForm();
            premiumForm.Show();
        }
        public static void OpenProfileForm()
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
        }
        public static void OpenSignUpForm()
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }
        public static void OpenWorkoutPlansForm()
        {
            WorkoutPlansForm workoutPlans = new WorkoutPlansForm();
            workoutPlans.Show();
        }





    }
}
