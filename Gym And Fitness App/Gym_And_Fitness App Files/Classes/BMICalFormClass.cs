using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class BMICalFormClass
    {
        public static async Task BMICalculatorFormLoadEvents(System.Windows.Forms.TextBox txtHeight, System.Windows.Forms.TextBox txtWeight, PictureBox pbBMIChart, PictureBox pbMembershipStatus, PictureBox pbProfilePicture)
        {
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtHeight, "Your height in cm..");
            Features.SetTextBoxPlaceholder(txtWeight, "Your weight in kg..");

            // Loading behavior of BMI scale/chart
            pbBMIChart.Image = await Task.Run(() => Properties.Resources.bmiChartUnderW8);

            // Accessing current user
            if (UserDataManager.CurrentUser != null)
            {
                // Load membership plan pics asynchronously
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());

                // Apply profile picture asynchronously
                await Task.Run(() => UserDataManager.ApplyProfilePicture(pbProfilePicture));
            }
        }

        public static void btnCalculateEvent(System.Windows.Forms.TextBox txtHeight, System.Windows.Forms.TextBox txtWeight, ErrorProvider error, System.Windows.Forms.Label lblBMI, System.Windows.Forms.Label lblBMICategory, PictureBox pbBMIChart, System.Windows.Forms.Label lblTargetWeightRange)
        {
            //if (string.IsNullOrEmpty(txtHeight.Text))
            //{
            //    txtHeight.Focus(); //isi pr focus!
            //    error.SetError(txtHeight, "Please Enter your height");
            //}
            //else if (string.IsNullOrEmpty(txtWeight.Text))
            //{
            //    txtWeight.Focus(); //isi pr focus!
            //    error.SetError(txtWeight, "Please Enter your Weight");
            //}
           
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

        public static void txtHeightAndWeightValidation(ErrorProvider error, KeyPressEventArgs e)
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
    }
}
