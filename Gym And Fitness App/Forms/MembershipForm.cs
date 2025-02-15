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


        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)
        Features features = new Features(); //instance of the class: (Features)


        private void btnFreePlan_Click(object sender, EventArgs e)
        {
            if (userDataManager.CurrentUser != null)
            {
                userDataManager.CurrentUser.MembershipStatus = "Free";
                userDataManager.UpdateMembershipInDatabase("Free");
                MessageBox.Show("Membership updated to Free!", "Success");
                this.Close();
                features.OpenProfileForm();
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

        private void btnPremiumPlan_Click(object sender, EventArgs e)
        {
            if (userDataManager.CurrentUser != null)
            {
                ProfileForm profile = new ProfileForm();
                profile.Close();
                if (userDataManager.CurrentUser.MembershipStatus == "Premium")
                {
                    MessageBox.Show("You are already a Premium member!");

                }
                else
                {
                    features.OpenPremiumForm();
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