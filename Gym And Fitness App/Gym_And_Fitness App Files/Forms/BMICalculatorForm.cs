using GymAndFitness.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class BMICalculatorForm : BaseForm
    {
        private static BMICalculatorForm instance;
        private BMICalculatorForm()
        {
            InitializeComponent();
        }

        public static BMICalculatorForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BMICalculatorForm();
            }
            return instance;
        }

        //method to update profile picture in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesBMIForm()
        {

            pbMembershipStatus.Image = Features.MembershipStatusPic();
        }


        //load
        private async void BMICalculatorForm_Load(object sender, EventArgs e)
        {

            await BMICalculatorFormLoadEvents();

            //old logic..

            //// Set placeholder for TextBox
            //Features.SetTextBoxPlaceholder(txtHeight, "Your height in cm..");
            //Features.SetTextBoxPlaceholder(txtWeight, "Your weight in kg..");

            ////loading behaviour of bmi scale/chart
            //pbBMIChart.Image = Properties.Resources.bmiChartUnderW8;


            ////  accessing current user 
            //if (UserDataManager.CurrentUser != null)
            //{
            //    UserDataManager.ApplyProfilePicture(btnProfilePicture);
            //    //load membership plan pics
            //    pbMembershipStatus.Image = Features.MembershipStatusPic();

            //}
        }


        private async Task BMICalculatorFormLoadEvents()
        {
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtHeight, "Your height in cm..");
            Features.SetTextBoxPlaceholder(txtWeight, "Your weight in kg..");

            // Loading behavior of BMI scale/chart
            pbBMIChart.Image = Properties.Resources.bmiChartUnderW8;

            // Accessing current user
            if (UserDataManager.CurrentUser != null)
            {
                // Load membership plan pics asynchronously
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());

                // Apply profile picture asynchronously
                await Task.Run(() => UserDataManager.ApplyProfilePicture(btnProfilePicture));
            }
        }

        public async void ReloadBMICalculatorFormData()
        {
            await BMICalculatorFormLoadEvents();
        }








        //button event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Focus(); //isi pr focus!
                error.SetError(this.txtHeight, "Please Enter your height");
            }
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                error.SetError(this.txtWeight, "Please Enter your Weight");
            }
            else
            {
                double height = 0;
                try
                {
                    double weight = double.Parse(txtWeight.Text);
                    height = double.Parse(txtHeight.Text);
                    double bmi = Features.CalculateBMI(weight, height);
                    lblBMI.Text = $"{bmi:F2}";
                    lblBMI.ForeColor = Features.GetBMIColor(bmi);
                    lblBMICategory.ForeColor = Features.GetBMIColor(bmi);
                    lblBMICategory.Text = Features.GetBMICategory(bmi);
                    pbBMIChart.Image = Features.GetBMIChartUpdate(bmi);
                    lblTargetWeightRange.Text = Features.SuggestTargetWeightRange(height);
                }
                catch (FormatException ex) { MessageBox.Show("Please enter valid numeric values for height and weight: " + ex.Message); }
                catch (Exception ex) { MessageBox.Show("An error occurred while calculating BMI: " + ex.Message); }

            }
        }






        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
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
            error.Clear();
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


        private void BMICalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }

    }
}
