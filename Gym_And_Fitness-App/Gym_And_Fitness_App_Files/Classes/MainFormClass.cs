using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class MainFormClass
    {
        public static void MainFormLoadEvents(PictureBox pbProfilePicture, Button btnLogout, Button btnLogin, PictureBox pbMembershipStatus)
        {
            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.ApplyProfilePicture(pbProfilePicture);
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                //load membership plan pics
                pbMembershipStatus.Image = Features.MembershipStatusPic();
            }
            else
            {
                btnLogout.Visible = false;
                btnLogout.Enabled = false;
                btnLogin.Visible = true;
                btnLogin.Enabled = true;

                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




    }
}
