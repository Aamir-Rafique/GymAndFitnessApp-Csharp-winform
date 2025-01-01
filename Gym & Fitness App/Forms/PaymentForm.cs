using System;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Gym___Fitness_App
{
    public partial class PaymentForm : Form
    {
        public PaymentForm() // Accept username as a parameter
        {
            InitializeComponent();
        }

        //connection string...
        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;


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

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "UPDATE Users SET LicenseKey = @LicenseKey, MembershipStatus = 'Premium' WHERE Username = @Username";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@LicenseKey", licenseKey);
                            command.Parameters.AddWithValue("@Username", UserDataManager.CurrentUser.Username); // Use the currentUsername variable

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Your license key has been generated. Please copy it and close this this form, then paste it in license key feild! ", "Key Generated");
                }
                else
                {
                    MessageBox.Show("Please select a payment method.", "Payment Required");
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
    }

}
