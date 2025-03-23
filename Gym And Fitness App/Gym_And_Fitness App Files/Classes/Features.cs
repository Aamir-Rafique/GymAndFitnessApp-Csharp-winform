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
        public static void OpenAboutForm()
        {
            //AboutForm aboutForm = new AboutForm();
            //aboutForm.Show();

            AboutForm.GetInstance().Show();
            AboutForm.GetInstance().BringToFront();
        }

        public static void OpenBMICalculatorForm()
        {
            BMICalculatorForm.GetInstance().Show();
            BMICalculatorForm.GetInstance().BringToFront();
        }

        public static void OpenDashboardForm()
        {
            DashboardForm.GetInstance().Show();
            DashboardForm.GetInstance().BringToFront();
        }

        public static void OpenDietPlansForm()
        {
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
            WorkoutPlansForm.GetInstance().Show();
            WorkoutPlansForm.GetInstance().BringToFront();
        }

        public static void LogoutNow()
        {
            UserDataManager.CurrentUser = null;
            Application.Restart(); // Restarts the entire application
        }

        //this code ensures, only one instance of the form is created at a time..

        //private static AboutForm _aboutForm;
        //private static BMICalculatorForm _bmiCalculatorForm;
        //private static DashboardForm _dashboardForm;
        //private static DietPlansForm _dietPlansForm;
        //private static LoginForm _loginForm;
        //private static MainForm _mainForm;
        //private static MembershipForm _membershipForm;
        //private static PaymentForm _paymentForm;
        //private static PremiumForm _premiumForm;
        //private static ProfileForm _profileForm;
        //private static SignupForm _signupForm;
        //private static WorkoutPlansForm _workoutPlansForm;

        //public static void OpenAboutForm()
        //{
        //    if (_aboutForm == null || _aboutForm.IsDisposed)
        //    {
        //        _aboutForm = new AboutForm();
        //        _aboutForm.FormClosed += (s, e) => _aboutForm = null; // Reset instance when closed
        //    }
        //    _aboutForm.Show();
        //    _aboutForm.Focus();
        //}


        //public static void OpenBMICalculatorForm()
        //{
        //    if (_bmiCalculatorForm == null || _bmiCalculatorForm.IsDisposed)
        //    {
        //        _bmiCalculatorForm = new BMICalculatorForm();
        //        _bmiCalculatorForm.FormClosed += (s, e) => _bmiCalculatorForm = null;
        //    }
        //    _bmiCalculatorForm.Show();
        //    _bmiCalculatorForm.Focus();
        //}

        //public static void OpenDashboardForm()
        //{
        //    if (_dashboardForm == null || _dashboardForm.IsDisposed)
        //    {
        //        _dashboardForm = new DashboardForm();
        //        _dashboardForm.FormClosed += (s, e) => _dashboardForm = null;
        //    }
        //    _dashboardForm.Show();
        //    _dashboardForm.Focus();
        //}

        //public static void OpenDietPlansForm()
        //{
        //    if (_dietPlansForm == null || _dietPlansForm.IsDisposed)
        //    {
        //        _dietPlansForm = new DietPlansForm();
        //        _dietPlansForm.FormClosed += (s, e) => _dietPlansForm = null;
        //    }
        //    _dietPlansForm.Show();
        //    _dietPlansForm.Focus();
        //}

        //public static void OpenLoginForm()
        //{
        //    if (_loginForm == null || _loginForm.IsDisposed)
        //    {
        //        _loginForm = new LoginForm();
        //        _loginForm.FormClosed += (s, e) => _loginForm = null;
        //    }
        //    _loginForm.Show();
        //    _loginForm.Focus();
        //}

        //public static void OpenMainForm()
        //{
        //    if (_mainForm == null || _mainForm.IsDisposed)
        //    {
        //        _mainForm = new MainForm();
        //        _mainForm.FormClosed += (s, e) => _mainForm = null;
        //    }
        //    _mainForm.Show();
        //    _mainForm.Focus();
        //}

        //public static void OpenMembershipForm()
        //{
        //    if (_membershipForm == null || _membershipForm.IsDisposed)
        //    {
        //        _membershipForm = new MembershipForm();
        //        _membershipForm.FormClosed += (s, e) => _membershipForm = null;
        //    }
        //    _membershipForm.Show();
        //    _membershipForm.Focus();
        //}

        //public static void OpenPaymentForm()
        //{
        //    if (_paymentForm == null || _paymentForm.IsDisposed)
        //    {
        //        _paymentForm = new PaymentForm();
        //        _paymentForm.FormClosed += (s, e) => _paymentForm = null;
        //    }
        //    _paymentForm.Show();
        //    _paymentForm.Focus();
        //}

        //public static void OpenPremiumForm()
        //{
        //    if (_premiumForm == null || _premiumForm.IsDisposed)
        //    {
        //        _premiumForm = new PremiumForm();
        //        _premiumForm.FormClosed += (s, e) => _premiumForm = null;
        //    }
        //    _premiumForm.Show();
        //    _premiumForm.Focus();
        //}


        //public static void OpenProfileForm()
        //{
        //    if (_profileForm == null || _profileForm.IsDisposed)
        //    {
        //        _profileForm = new ProfileForm();
        //        _profileForm.FormClosed += (s, e) => _profileForm = null;
        //    }
        //    _profileForm.Show();
        //    _profileForm.Focus();
        //}

        //public static void OpenSignUpForm()
        //{
        //    if (_signupForm == null || _signupForm.IsDisposed)
        //    {
        //        _signupForm = new SignupForm();
        //        _signupForm.FormClosed += (s, e) => _signupForm = null;
        //    }
        //    _signupForm.Show();
        //    _signupForm.Focus();
        //}

        //public static void OpenWorkoutPlansForm()
        //{
        //    if (_workoutPlansForm == null || _workoutPlansForm.IsDisposed)
        //    {
        //        _workoutPlansForm = new WorkoutPlansForm();
        //        _workoutPlansForm.FormClosed += (s, e) => _workoutPlansForm = null;
        //    }
        //    _workoutPlansForm.Show();
        //    _workoutPlansForm.Focus();
        //}




    }
}
