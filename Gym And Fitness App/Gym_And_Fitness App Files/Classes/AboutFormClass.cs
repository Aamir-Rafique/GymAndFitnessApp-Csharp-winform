using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class AboutFormClass
    {

        public static async Task AboutFormLoadEvents(System.Windows.Forms.Label lblPurpose, System.Windows.Forms.Label lblVersion, PictureBox pbMembershipStatus, PictureBox pbProfilePicture)
        {
            lblPurpose.Text = "The Gym && Fitness App is designed to help users achieve their fitness goals by providing personalized workout plans, nutritional guidance, and progress tracking. Whether you're looking to build muscle, lose weight, or improve overall fitness, this app offers a comprehensive solution to support your journey. Our mission is to make fitness accessible, convenient, and enjoyable for everyone. Stay fit, stay healthy!";

            // Assign the version to the label
            lblVersion.Text = Features.GetCurrentVersion();

            // Accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                // Load membership plan pics asynchronously
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());

                // Apply profile picture (assuming this method is lightweight)
                UserDataManager.ApplyProfilePicture(pbProfilePicture);
            }
        }



    }
}
