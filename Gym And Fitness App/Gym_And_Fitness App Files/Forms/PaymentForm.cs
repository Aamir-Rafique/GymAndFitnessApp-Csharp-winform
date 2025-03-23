using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class PaymentForm : Form
    {
        public PaymentForm() // Accept username as a parameter
        {
            InitializeComponent();
        }


        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)



        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtEmail, "Enter Your Email...");
            Features.SetTextBoxPlaceholder(txtGeneratedKey, "Your Key Appears here...");
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            // Check if any radio button is selected
            if (!IsAnyRadioButtonChecked())
            {
                errorGroupBoxRadioButtons.SetError(groupBoxRadioButtons, "Please select a payment method.");
            }

            // Check if email is empty or invalid
            else if (string.IsNullOrEmpty(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorEmail.SetError(txtEmail, "Please enter a valid email address.");
            }

            else
            {
                // Determine the selected payment method
                string paymentMethod = GetSelectedPaymentMethod();

                if (!string.IsNullOrEmpty(paymentMethod))
                {
                    // Generate a random license key
                    string licenseKey = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();

                    // Display the license key to the user
                    txtGeneratedKey.Text = licenseKey;

                    // Store the license key in the database
                    userDataManager.StoreLicenseKey(licenseKey);

                    MessageBox.Show("Your license key has been generated.\nPlease copy it and close this form, then paste it in license key feild! ", "Key Generated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a payment method.", "Payment Required",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
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
            errorEmail.Clear();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnGenerateKey.PerformClick(); // Trigger the button's click event
            }
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }
    }

}
