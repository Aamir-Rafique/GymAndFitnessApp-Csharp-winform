using GymAndFitness.Classes;
using GymAndFitness.Forms;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MainForm : BaseForm
    {
        private static MainForm instance;
        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesMainForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }

        //form1 i.e. main
        private void Form1_Load(object sender, EventArgs e)
        {
            MainFormClass.MainFormLoadEvents(pbProfilePicture, btnLogout, btnLogin, pbMembershipStatus);
        }

        public void ReloadMainFormData()
        {
            MainFormClass.MainFormLoadEvents(pbProfilePicture, btnLogout, btnLogin, pbMembershipStatus);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Features.BtnLogout();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
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


    }
}
