using System;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class PaymentFormClass
    {
        public static void PaymentFormLoadEvents(System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox txtEmail)
        {
            textBox1.Focus();
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtEmail, "Enter Your Email...");
        }

        public static void ActivatePremium(ErrorProvider error, System.Windows.Forms.GroupBox groupBoxRadioButtons, System.Windows.Forms.TextBox txtEmail, System.Windows.Forms.RadioButton rbtnEasyPaisa, System.Windows.Forms.RadioButton rbtnJazzCash, System.Windows.Forms.RadioButton rbtnVisa, System.Windows.Forms.RadioButton rbtnPayPal)
        {

            if (UserDataManager.CurrentUser != null)
            {
                // Check if any radio button is selected
                if (!IsAnyRadioButtonChecked(rbtnEasyPaisa, rbtnJazzCash, rbtnVisa, rbtnPayPal))
                {
                    error.SetError(groupBoxRadioButtons, "Please select a payment method.");
                }

                // Check if email is empty or invalid
                else if (string.IsNullOrEmpty(txtEmail.Text) || !txtEmail.Text.Contains("@"))
                {
                    error.SetError(txtEmail, "Please enter a valid email address. for eg. someone@gmail.com ");
                }
                else
                {
                    // Determine the selected payment method
                    string paymentMethod = GetSelectedPaymentMethod(rbtnEasyPaisa, rbtnJazzCash, rbtnVisa, rbtnPayPal);

                    if (!string.IsNullOrEmpty(paymentMethod))
                    {
                        string username = UserDataManager.CurrentUser.Username;
                        // Generate a random license key
                        string licenseKey = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();

                        // Store the license key in the database
                        UserDataManager.StoreLicenseKey(licenseKey);

                        //method to verify licensekey..
                        UserDataManager.VerifyLicenseKey(username, licenseKey);

                        MessageBox.Show("You have a Premium membership now!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //since the premium membership has been activated now, so updating premium features of the forms..
                        AboutForm.GetInstance().RefreshPremiumFeaturesAboutForm();
                        BMICalculatorForm.GetInstance().RefreshPremiumFeaturesBMIForm();
                        DashboardForm.GetInstance().RefreshPremiumFeaturesDashboardForm();
                        DietPlansForm.GetInstance().RefreshPremiumFeaturesDietForm();
                        MainForm.GetInstance().RefreshPremiumFeaturesMainForm();
                        ProfileForm.GetInstance().RefreshPremiumFeaturesProfileForm();
                        WorkoutPlansForm.GetInstance().RefreshPremiumFeaturesWorkoutForm();


                        //open profile form and close this one..
                        Features.OpenProfileForm();
                        PaymentForm.GetInstance().Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select a payment method.", "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private static bool IsAnyRadioButtonChecked(System.Windows.Forms.RadioButton rbtnEasyPaisa, System.Windows.Forms.RadioButton rbtnJazzCash, System.Windows.Forms.RadioButton rbtnVisa, System.Windows.Forms.RadioButton rbtnPayPal)
        {
            return rbtnEasyPaisa.Checked || rbtnJazzCash.Checked || rbtnVisa.Checked || rbtnPayPal.Checked;
        }

        private static string GetSelectedPaymentMethod(System.Windows.Forms.RadioButton rbtnEasyPaisa, System.Windows.Forms.RadioButton rbtnJazzCash, System.Windows.Forms.RadioButton rbtnVisa, System.Windows.Forms.RadioButton rbtnPayPal)
        {
            if (rbtnEasyPaisa.Checked)
                return "EasyPaisa";
            if (rbtnJazzCash.Checked)
                return "JazzCash";
            if (rbtnVisa.Checked)
                return "Visa";
            if (rbtnPayPal.Checked)
                return "PayPal";

            return null; // No payment method selected
        }


        public static void KeyValidationForGenKey(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 3)     //represents Ctrl+C
            {
                e.Handled = false;
            }
            else if (ch == 1)   //represents Ctrl+A
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
