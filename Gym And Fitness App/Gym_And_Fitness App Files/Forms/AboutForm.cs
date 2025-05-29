using GymAndFitness.Classes;
using GymAndFitness.Forms;
using System;
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
            await AboutFormClass.AboutFormLoadEvents(lblPurpose, lblVersion, pbMembershipStatus, pbProfilePicture);
        }
        public async void ReloadAboutFormData()
        {
            await AboutFormClass.AboutFormLoadEvents(lblPurpose, lblVersion, pbMembershipStatus, pbProfilePicture);
        }

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
            Features.FormClosedEvent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
