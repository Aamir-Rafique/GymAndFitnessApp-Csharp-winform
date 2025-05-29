using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class PaymentFormClass
    {

        public static void PaymentFormLoadEvents(TextBox textBox1, TextBox txtEmail)
        {
            textBox1.Focus();
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtEmail, "Enter Your Email...");
        }



        public static void ActivatePremium(ErrorProvider error, GroupBox groupBoxRadioButtons, TextBox txtEmail, RadioButton rbtnEasyPaisa, RadioButton rbtnJazzCash, RadioButton rbtnVisa, RadioButton rbtnPayPal, TextBox txtOTP)
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

                if (string.IsNullOrWhiteSpace(txtOTP.Text))
                {
                    MessageBox.Show("Please enter verification OTP", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
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


        private static bool IsAnyRadioButtonChecked(RadioButton rbtnEasyPaisa, RadioButton rbtnJazzCash, RadioButton rbtnVisa, RadioButton rbtnPayPal)
        {
            return rbtnEasyPaisa.Checked || rbtnJazzCash.Checked || rbtnVisa.Checked || rbtnPayPal.Checked;
        }

        private static string GetSelectedPaymentMethod(RadioButton rbtnEasyPaisa, RadioButton rbtnJazzCash, RadioButton rbtnVisa, RadioButton rbtnPayPal)
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


        //For email-verification:
        private static string verificationOTP = "";  //Since its a simple WinForms desktop app for one user session, making it static is okay and won’t cause issues.


        //method to prevent multiple email submission, only one is allowed.. 
        private static bool isOTPSent = false;
        public static async Task SubmitEmail(TextBox txtEmail, Label lblOTP, TextBox txtOTP, Button btnVerifyOTP, PictureBox pbOTPVerified, RadioButton rbtnEasyPaisa, RadioButton rbtnJazzCash, RadioButton rbtnVisa, RadioButton rbtnPayPal, GroupBox groupBoxRadioButtons, Button btnActivatePremium)
        {

            // Check if any radio button is selected
            if (!IsAnyRadioButtonChecked(rbtnEasyPaisa, rbtnJazzCash, rbtnVisa, rbtnPayPal))
            {
                MessageBox.Show("Please select a payment method first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!txtEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only Gmail addresses are allowed for now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (isOTPSent == false)
            {
                SendOTP(txtEmail, lblOTP, txtOTP, btnVerifyOTP, pbOTPVerified, rbtnEasyPaisa, rbtnJazzCash, rbtnVisa, rbtnPayPal, groupBoxRadioButtons);

                isOTPSent = true;   //otp sent!

                // Wait for 1 minute before allowing another submission
                await Task.Delay(TimeSpan.FromSeconds(30));

                isOTPSent = false; // Reset flag after 1 minute

                if (btnActivatePremium.Visible == true)
                {
                    btnActivatePremium.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please wait for 30 seconds before resubmitting the OTP.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private static void SendOTP(TextBox txtEmail, Label lblOTP, TextBox txtOTP, Button btnVerifyOTP, PictureBox pbOTPVerified, RadioButton rbtnEasyPaisa, RadioButton rbtnJazzCash, RadioButton rbtnVisa, RadioButton rbtnPayPal, GroupBox groupBoxRadioButtons)
        {
            // Generate a 6-digit verification OTP
            Random rnd = new Random();
            verificationOTP = rnd.Next(100000, 999999).ToString();

            try
            {
                // Determine the selected payment method
                string paymentMethod = GetSelectedPaymentMethod(rbtnEasyPaisa, rbtnJazzCash, rbtnVisa, rbtnPayPal);

                // Replace with your Gmail and app password
                string senderEmail = "gymandfitnessapp@gmail.com";
                string senderPassword = "djuktqiihfawcxfw";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(txtEmail.Text.Trim());
                mail.Subject = "Your Verification OTP - Gym And Fitness";

                mail.IsBodyHtml = true;   //to write the email body in HTML format to use formatting (bold, italic, emojis, etc.)

                mail.Body = $@"
<p>Hey <strong>Fitness Enthusiast</strong>,</p>

<p>Welcome to <strong>Gym And Fitness App</strong>! 💪<br />
 We’re excited to have you on board to crush your fitness goals together.</p>

<p style='font-size: 18px;'>
🔒 <strong>Your Verification Code:</strong> 
<span style='color: green; font-weight: bold;'>{verificationOTP}</span>
</p>
    
<p>Don’t share this code with anyone. It’s valid for the next <strong>10 minutes</strong>.</p>

<p>💳 <strong>Selected Payment Method:</strong> 
<span style='color: blue; font-weight: bold;'>{paymentMethod}</span> ✅</p>

<p>Ready to <em>sweat</em>, <em>smile</em>, and <em>succeed</em>? Let’s go! 🚀</p>

<p>
Stay strong,<br />
— The <strong>Gym And Fitness App</strong> Team<br />
🏃‍♀️ <a href='https://github.com/Aamir-Rafique/GymAndFitnessApp'>https://github.com/Aamir-Rafique/GymAndFitnessApp</a>
</p>";


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Verification OTP sent to" + txtEmail.Text + " !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);


                lblOTP.Visible = true;
                txtOTP.Visible = true;
                btnVerifyOTP.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static void VerifyOTP(TextBox txtOTP, Button btnActivatePremium, PictureBox pbOTPVerified)
        {
            if (string.IsNullOrWhiteSpace(txtOTP.Text))
            {
                MessageBox.Show("Please enter verification OTP", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else if (txtOTP.Text == verificationOTP)
            {
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Allow user to proceed..

                pbOTPVerified.Visible = true;
                btnActivatePremium.Visible = true;

            }
            else
            {
                MessageBox.Show("Invalid OTP. Try again.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbOTPVerified.Visible = false;
                btnActivatePremium.Visible = false;
                btnActivatePremium.Focus();
            }
        }



        //key validation for txtOTP
        public static void TxtOTPKeyValidation(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 08)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 22)     //represents Ctrl+V
            {
                e.Handled = false;
            }
            else if (ch == 24)     //represents Ctrl+x
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
