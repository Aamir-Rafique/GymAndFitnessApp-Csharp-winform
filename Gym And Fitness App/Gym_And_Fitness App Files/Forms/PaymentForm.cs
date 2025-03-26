using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class PaymentForm : Form
    {
        private PaymentForm()
        {
            InitializeComponent();
        }


        private static PaymentForm instance;
        public static PaymentForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PaymentForm();
            }
            return instance;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtEmail, "Enter Your Email...");
        }

        private void btnActivatePremium_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {

                // Check if any radio button is selected
                if (!IsAnyRadioButtonChecked())
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
                    string paymentMethod = GetSelectedPaymentMethod();

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

                        Features.OpenProfileForm();
                        this.Close();
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

        private bool IsAnyRadioButtonChecked()
        {
            return rbtnEasyPaisa.Checked || rbtnJazzCash.Checked || rbtnVisa.Checked || rbtnPayPal.Checked;
        }

        private string GetSelectedPaymentMethod()
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


        private void txtGeneratedKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 3)
            {
                e.Handled = false;
            }
            else if (ch == 1)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnActivatePremium.PerformClick(); // Trigger the button's click event
            }
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Features.OpenMembershipForm();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Features.OpenMembershipForm();
            this.Hide();
        }


    }

}
