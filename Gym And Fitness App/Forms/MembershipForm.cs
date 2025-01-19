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
                UserDataManager.CurrentUser.MembershipStatus = "Free";
                UserDataManager.UpdateMembershipInDatabase("Free");
                MessageBox.Show("Membership updated to Free!", "Success");
                this.Close();
                ProfileForm profile = new ProfileForm();
                profile.Show();
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
                    PremiumForm premiumForm = new PremiumForm();
                    premiumForm.Show();
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