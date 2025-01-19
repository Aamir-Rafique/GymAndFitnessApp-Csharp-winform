using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        //load
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed



            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.ApplyProfilePicture(btnProfilePicture);
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







        //calculate bmi
        private double CalculateBMI(double weight, double height)
        {
            height = height / 100; // Convert height from cm to meters
            return weight / (height * height);

        }

        //color code
        private Color GetBMIColor(double bmi)
        {
            if (bmi < 18.5)
                return Color.Blue;
            else if (bmi >= 18.5 && bmi <= 24.9)
                return Color.Green;
            else if (bmi >= 25 && bmi <= 29.9)
                return Color.Yellow;
            else if (bmi >= 30 && bmi <= 35)
                return Color.Orange;
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

        //button event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Focus(); //isi pr focus!
                errorHeight.SetError(this.txtHeight, "Please Enter your height");
            }
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                errorWeight.SetError(this.txtWeight, "Please Enter your Weight");
            }
            else
            {
                double height = 0;
                try
                {
                    double weight = double.Parse(txtWeight.Text);
                    height = double.Parse(txtHeight.Text);
                    double bmi = CalculateBMI(weight, height);
                    lblBMI.Text = $"Your BMI is {bmi:F2}";
                    lblBMI.ForeColor = GetBMIColor(bmi);
                    lblBMICategory.Text = GetBMICategory(bmi);
                }
                catch (FormatException ex) { MessageBox.Show("Please enter valid numeric values for height and weight: " + ex.Message); }
                catch (Exception ex) { MessageBox.Show("An error occurred while calculating BMI: " + ex.Message); }

                // Calculate target weight range

                BMICalculator bmiCalculator = new BMICalculator();
                (double minWeight, double maxWeight) targetWeightRange = bmiCalculator.CalculateTargetWeightRange(height);
                lblTargetWeightRange.Text = $"{targetWeightRange.minWeight:F2} kg - {targetWeightRange.maxWeight:F2} kg";
            }
        }

        //Target Weight
        public class BMICalculator
        {
            public double CalculateTargetWeight(double heightInCm, double targetBMI)
            {
                double heightInMeters = heightInCm / 100;
                double targetWeight = targetBMI * Math.Pow(heightInMeters, 2);
                return targetWeight;
            }

            public (double minWeight, double maxWeight) CalculateTargetWeightRange(double heightInCm)
            {
                double minBMI = 18.5;
                double maxBMI = 24.9;
                double minWeight = CalculateTargetWeight(heightInCm, minBMI);
                double maxWeight = CalculateTargetWeight(heightInCm, maxBMI);
                return (minWeight, maxWeight);
            }
        }



        //menu
        private void btnToggle_Click(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
            slidePanel.BringToFront();  //to remove glitches while sliding
        }




        //profile button
        private void btnProfilePicture_Click_1(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
        }
        //home Button
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
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


        //dashboard form
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnProfilePicture, "Profile");
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorHeight.Clear();
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
            errorWeight.Clear();
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






        private void btnProfilePicture_MouseEnter_1(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                toolTip1.SetToolTip(btnProfilePicture, $"{UserDataManager.CurrentUser.Username}'s Profile");
            }
            else
            {
                toolTip1.SetToolTip(btnProfilePicture, "Profile");
            }
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnCalculate.PerformClick(); // Trigger the button's click event
            }
        }
    }
}
