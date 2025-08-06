using GymAndFitness.Classes;
using GymAndFitness.Forms;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class ProfileForm : BaseForm
    {
        private static ProfileForm instance;
        private ProfileForm()
        {
            InitializeComponent();
        }
        public static ProfileForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProfileForm();
            }
            return instance;
        }


        //LOAD
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            ProfileFormClass.ProfileFormLoadEvents(pbProfilePicture, nudCurrentHeight, nudCurrentWeight, btnLogout, btnLogin, lblUsername, lblAge, lblGender, lblHeight, lblStartingWeight, lblCurrentWeight, lblBMI, lblTargetWeight, lblFitnessGoal, lblFitnessLevel, lblTargetWeightRange, pbMembershipStatus, lblMembershipStatus, btnChangeProfilePicture, btnGetMembershipPlan, pbPremiumVerified);
        }


        public void ReloadProfileFormData()
        {
            ProfileFormClass.ProfileFormLoadEvents(pbProfilePicture, nudCurrentHeight, nudCurrentWeight, btnLogout, btnLogin, lblUsername, lblAge, lblGender, lblHeight, lblStartingWeight, lblCurrentWeight, lblBMI, lblTargetWeight, lblFitnessGoal, lblFitnessLevel, lblTargetWeightRange, pbMembershipStatus, lblMembershipStatus, btnChangeProfilePicture, btnGetMembershipPlan, pbPremiumVerified);
        }


        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesProfileForm()
        {
            lblHeight.Text = $"{UserDataManager.CurrentUser.Height} cm";
            lblCurrentWeight.Text = $"{UserDataManager.CurrentUser.CurrentWeight} kg";
            lblBMI.Text = UserDataManager.CurrentUser.BMI.ToString("F2");
            ProfileFormClass.LoadMembershipStatus_Pic(pbMembershipStatus, lblMembershipStatus);
            ProfileFormClass.PremiumFeaturesProfileForm(btnChangeProfilePicture, btnGetMembershipPlan, pbMembershipStatus, lblMembershipStatus, pbPremiumVerified);
        }

        private void btnGetMembershipPlan_Click(object sender, EventArgs e)
        {
            ProfileFormClass.GetMembershipPlan(pbMembershipStatus, lblMembershipStatus);
        }

        //change profile pic
        private void btnChangeProfilePicture_Click(object sender, EventArgs e)
        {
            ProfileFormClass.ChangeProfilePic(pbProfilePicture);
        }

        private void lblBMI_TextChanged(object sender, EventArgs e)
        {
            ProfileFormClass.BMIValueChanged(lblBMI, lblBMICategory);
        }

        private void btnSaveCurrentHeightAndWeight_Click(object sender, EventArgs e)
        {
            ProfileFormClass.SaveHeightAndWeight(nudCurrentWeight, nudCurrentHeight, lblHeight, lblCurrentWeight, lblBMI, pbMembershipStatus, lblMembershipStatus, btnChangeProfilePicture, btnGetMembershipPlan);
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

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            ProfileFormClass.DeleteAccount();
        }

        private void nudCurrentWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnSaveCurrentHeightAndWeight.PerformClick(); // Trigger the button's click event
            }
        }

        private void nudCurrentHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnSaveCurrentHeightAndWeight.PerformClick(); // Trigger the button's click event
            }
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }

        private void pbProfilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
