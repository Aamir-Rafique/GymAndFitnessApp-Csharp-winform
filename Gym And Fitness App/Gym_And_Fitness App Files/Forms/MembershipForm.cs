using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MembershipForm : Form
    {
        public MembershipForm()
        {
            InitializeComponent();
        }

        private void btnFreePlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                MessageBox.Show("You are already using a free plan!", "Attention");
                this.Close();
                Features.OpenProfileForm();
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

        private void btnPremiumPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                ProfileForm profile = new ProfileForm();
                profile.Close();
                if (UserDataManager.CurrentUser.MembershipStatus == "Premium")
                {
                    MessageBox.Show("You are already a Premium member!");

                }
                else
                {
                    Features.OpenPremiumForm();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

    }
}