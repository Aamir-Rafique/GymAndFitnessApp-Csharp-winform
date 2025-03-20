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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click()
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click()
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click()
        {

        }
    }
}