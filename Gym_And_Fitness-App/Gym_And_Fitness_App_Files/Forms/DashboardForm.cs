using GymAndFitness.Classes;
using GymAndFitness.Forms;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class DashboardForm : BaseForm
    {
        private static DashboardForm instance;
        private DashboardForm()
        {
            InitializeComponent();
        }
        public static DashboardForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DashboardForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesDashboardForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
            DashboardFormClass.PremiumFeatureDashboardForm(lblPremiumMembers, pnlWaterIntake, btnAddWater, lblWaterIntake, lblGlasses, progressBarWater, toolTip, pbwaterintake);

        }

        public void RefreshProgressBarWeight()
        {
            DashboardFormClass.ProgressBarWeight(progressBarWeight, lblWeightProgess);
        }


        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }


        //LOAD
        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await DashboardFormClass.DasboardFormLoadEvents(timerTime, timerQuote, lblDate, pbProfilePicture, pbMembershipStatus, btnLogout, btnLogin, lblWaterIntake, progressBarWater, progressBarWeight, lblWeightProgess, lblPremiumMembers, pnlWaterIntake, btnAddWater, lblGlasses, toolTip, pbwaterintake);

        }


        public async void ReloadDashboardFormData()
        {
            await DashboardFormClass.DasboardFormLoadEvents(timerTime, timerQuote, lblDate, pbProfilePicture, pbMembershipStatus, btnLogout, btnLogin, lblWaterIntake, progressBarWater, progressBarWeight, lblWeightProgess, lblPremiumMembers, pnlWaterIntake, btnAddWater, lblGlasses, toolTip, pbwaterintake);
        }

        //code for clock
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DashboardFormClass.GetQoutes(lblQuote);
        }

        private void btnChallenge_Click_1(object sender, EventArgs e)
        {
            DashboardFormClass.GetChallenges(lblChallenge);
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            DashboardFormClass.SetWaterIntake(lblWaterIntake, progressBarWater);
        }

        private void progressBarWeight_MouseEnter(object sender, EventArgs e)
        {
            DashboardFormClass.ToolTipProgBarWeight(toolTip, progressBarWeight);
        }

        private void progressBarWater_MouseEnter(object sender, EventArgs e)
        {
            DashboardFormClass.ToolTipProgBarWater(toolTip, progressBarWater);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Features.BtnLogout();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
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
            Features.TooltipProfilePic(toolTip, pbProfilePicture);
        }


    }
}
