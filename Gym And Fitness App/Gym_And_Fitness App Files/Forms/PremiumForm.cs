using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class PremiumForm : Form
    {
        public PremiumForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)

        private void PremiumForm_Load(object sender, EventArgs e)
        {
            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtLicenseKey, "Enter Licence key here...");
        }

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

                    userDataManager.VerifyLicenseKey(username, enteredKey);

                }
                else
                {
                    MessageBox.Show("No user is logged in.");
                }
            }
        }






        private void btnGetNewKey_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                MessageBox.Show($"Welcome, {UserDataManager.CurrentUser.Username}!");
                Features.OpenPaymentForm();

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

        private void PremiumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }
    }
}
