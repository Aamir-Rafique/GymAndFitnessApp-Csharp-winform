using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MembershipForm : Form
    {
        private MembershipForm()
        {
            InitializeComponent();
        }

        private static MembershipForm instance;
        public static MembershipForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MembershipForm();
            }
            return instance;
        }
        private void btnFreePlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                MessageBox.Show("You are already using a free plan!", "Attention");
                Features.OpenProfileForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnPremiumPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if (UserDataManager.CurrentUser.MembershipStatus == "Premium")
                {
                    MessageBox.Show("You are already a Premium member!");
                }
                else
                {
                    Features.OpenPaymentForm();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void MembershipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Close();
        }
    }
}