using GymAndFitness.Forms;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class AboutForm : BaseForm
    {
        private static AboutForm instance;

        private AboutForm()
        {
            InitializeComponent();
        }

        public static AboutForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AboutForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesAboutForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }

        private async void AboutForm_Load(object sender, EventArgs e)
        {
            await AboutFormLoadEvents();
        }
        public async void ReloadAboutFormData()
        {
            await AboutFormLoadEvents();
        }

        private async Task AboutFormLoadEvents()
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

        //old logic (without async..)
        //private void AboutFormLoadEvents()
        //{
        //    lblPurpose.Text = "The Gym && Fitness App is designed to help users achieve their fitness goals by providing personalized workout plans, nutritional guidance, and progress tracking. Whether you're looking to build muscle, lose weight, or improve overall fitness, this app offers a comprehensive solution to support your journey. Our mission is to make fitness accessible, convenient, and enjoyable for everyone. Stay fit, stay healthy!";

        //    //  accessing current user 
        //    if (UserDataManager.CurrentUser != null)
        //    {
        //        //load membership plan pics
        //        pbMembershipStatus.Image = Features.MembershipStatusPic();
        //        UserDataManager.ApplyProfilePicture(pbProfilePicture);
        //    }


        //    // Assign the version to the label
        //    lblVersion.Text = Features.GetCurrentVersion();
        //}

        //YOutube
        private void pbYoutube_Click(object sender, EventArgs e)
        {
            string url = "https://www.example.com";
            Features.OpenExternalLink(url);

        }

        //facebook
        private void pbFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.example.com";
            Features.OpenExternalLink(url);

        }


        //linkedin
        private void pbLinkedin_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/aamir-rafique-7a5bb1336/";
            Features.OpenExternalLink(url);

        }


        //twitter
        private void pbTwitter_Click(object sender, EventArgs e)
        {
            string url = "https://www.example.com";
            Features.OpenExternalLink(url);
        }


        //github
        private void pbGithub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Aamir-Rafique";
            Features.OpenExternalLink(url);
        }


        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }

        private void pbProfilePicture_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }

        private void pbProfilePicture_MouseEnter(object sender, EventArgs e)
        {
            Features.TooltipProfilePic(toolTip1, pbProfilePicture);
        }

    }
}
