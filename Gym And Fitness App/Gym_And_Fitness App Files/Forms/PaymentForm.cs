using GymAndFitness.Classes;
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
            PaymentFormClass.PaymentFormLoadEvents(textBox1, txtEmail);
        }

        private void btnActivatePremium_Click(object sender, EventArgs e)
        {
            PaymentFormClass.ActivatePremium(error, groupBoxRadioButtons, txtEmail, rbtnEasyPaisa, rbtnJazzCash, rbtnVisa, rbtnPayPal);
        }

        private void txtGeneratedKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            PaymentFormClass.KeyValidationForGenKey(e);
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
            Features.FormClosedEvent();
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
