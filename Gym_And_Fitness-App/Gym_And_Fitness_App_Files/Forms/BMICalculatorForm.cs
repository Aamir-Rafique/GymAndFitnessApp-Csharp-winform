using GymAndFitness.Classes;
using GymAndFitness.Forms;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class BMICalculatorForm : BaseForm
    {
        private static BMICalculatorForm instance;
        private BMICalculatorForm()
        {
            InitializeComponent();
        }

        public static BMICalculatorForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BMICalculatorForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesBMIForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }

        //load
        private async void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            await BMICalFormClass.BMICalculatorFormLoadEvents(txtHeight, txtWeight, pbBMIChart, pbMembershipStatus, pbProfilePicture);
        }

        public async void ReloadBMICalculatorFormData()
        {
            await BMICalFormClass.BMICalculatorFormLoadEvents(txtHeight, txtWeight, pbBMIChart, pbMembershipStatus, pbProfilePicture);
        }

        //button event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            BMICalFormClass.btnCalculateEvent(txtHeight, txtWeight, error, lblBMI, lblBMICategory, pbBMIChart, lblTargetWeightRange);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            BMICalFormClass.txtHeightAndWeightValidation(error, e);
        }
        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            BMICalFormClass.txtHeightAndWeightValidation(error, e);
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnCalculate.PerformClick(); // Trigger the button's click event
            }
        }

        private void BMICalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
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

        //unitconvertor
        private void pbUnitConverter_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/search?q=inch+to+cm&oq=inch+to+cm&gs_lcrp=EgRlZGdlKgYIABBFGDkyBggAEEUYOdIBCDgyMzhqMGoxqAIAsAIA&sourceid=chrome&ie=UTF-8";
            Features.OpenExternalLink(url);
        }

    }
}
