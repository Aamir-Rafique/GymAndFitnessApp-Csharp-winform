using System;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class PremiumForm : Form
    {
        public PremiumForm()
        {
            InitializeComponent();
        }

        //connection string...
        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;

        private void btnVerifyKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseKey.Text))
            {
                errorLicenseKey.SetError(txtLicenseKey, "Please Enter a License Key!");
            }

            else
            {

                if (UserDataManager.CurrentUser != null)
                {

                    string username = UserDataManager.CurrentUser.Username; // Replace with the logged-in user's username
                    string enteredKey = txtLicenseKey.Text;

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "SELECT LicenseKey FROM Users WHERE Username = @Username";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);

                            connection.Open();
                            object result = command.ExecuteScalar();

                            if (result != null && result.ToString() == enteredKey)
                            {
                                MessageBox.Show("License key validated successfully! You now have premium membership.", "Validation Success");

                                UserDataManager.CurrentUser.MembershipStatus = "Premium";
                                UpdateMembershipInDatabase("Premium");
                                this.Close();
                                ProfileForm profile = new ProfileForm();
                                profile.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid license key. Please try again.", "Validation Failed");
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No user is logged in.");
                }
            }
        }






        // Method to update membership status in the database
        private void UpdateMembershipInDatabase(string membershipStatus)
        {
            string query = "UPDATE Users SET MembershipStatus = @MembershipStatus WHERE Username = @Username";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MembershipStatus", membershipStatus);
                    command.Parameters.AddWithValue("@Username", UserDataManager.CurrentUser.Username);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnGetNewKey_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                MessageBox.Show($"Welcome, {UserDataManager.CurrentUser.Username}!");
                PaymentForm paymentForm = new PaymentForm();
                paymentForm.ShowDialog();
                paymentForm.Focus();

            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

        private void txtLicenseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorLicenseKey.Clear();
        }

        private void txtLicenseKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnVerifyKey.PerformClick(); // Trigger the button's click event
            }
        }
    }
}
