using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class MembershipFormClass
    {
        public static void GetFreePlan()
        {
            if (UserDataManager.CurrentUser != null)
            {
                MessageBox.Show("You are already using a free plan!", "Attention");
                Features.OpenProfileForm();
                MembershipForm.GetInstance().Close();
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public static void GetPremiumPlan()
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
                    MembershipForm.GetInstance().Close();
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
