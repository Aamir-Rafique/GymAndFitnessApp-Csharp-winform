using GymAndFitness.Classes;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class SignupForm : Form
    {
        private static SignupForm instance;

        public SignupForm()
        {
            InitializeComponent();
        }

        public static SignupForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SignupForm();
            }
            return instance;
        }

        //Load
        private void SignupForm_Load(object sender, EventArgs e)
        {
            SignupFormClass.SignupFormLoadEvents(cmbGender, cmbFitnessGoal, cmbFitnessLevel);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupFormClass.SignupNow(txtUsername, txtAge, txtHeight, txtWeight, txtTargetWeight, txtPassword, txtConfirmPassword, error, cmbGender, cmbFitnessGoal, cmbFitnessLevel, lblTargetWeightRange, lblProfilePicturePath, btnUploadPicture);
        }

        //upload btn
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            SignupFormClass.SetProfilPic(error, lblProfilePicturePath, pbProfilePicture);
        }

        //jab textbox leave krne lage
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            SignupFormClass.TxtAgeKeyValidation(error, e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            SignupFormClass.TxtHeightKeyValidation(error, e);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            SignupFormClass.TxtWeightKeyValidation(error, e, txtHeight);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            SignupFormClass.TxtUsernameKeyValidation(error, e);
        }

        private void txtTargetWeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SignupFormClass.TxtTargetWeightKeyValidation(error, e);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            SignupFormClass.CheckUsernameAvailability(txtUsername, lblUsernameStatus);
        }

        private void cmbGender_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Features.ComboBoxValidation(sender, e);
        }

        private void cmbFitnessGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Features.ComboBoxValidation(sender, e);
        }

        private void cmbFitnessLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Features.ComboBoxValidation(sender, e);
        }
        private void lblProfilePicturePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            SignupFormClass.ResetValuesNow(txtUsername, txtAge, txtHeight, txtWeight, txtTargetWeight, txtPassword, txtConfirmPassword, error, cmbGender, cmbFitnessGoal, cmbFitnessLevel, lblProfilePicturePath, pbProfilePicture);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            SignupFormClass.ConfirmPasswordValidation(txtPassword, txtConfirmPassword, error);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
        }

        //to remove error from combo boxes
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem != null)
            {
                error.Clear();
            }
        }

        private void cmbFitnessGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFitnessGoal.SelectedItem != null)
            {
                error.Clear();
            }
        }

        private void cmbFitnessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFitnessLevel.SelectedItem != null)
            {
                error.Clear();
            }
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            SignupFormClass.TxtHeightValidation(txtHeight);
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            SignupFormClass.TxtWeightValidation(lblTargetWeightRange);
        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }

        private void btnBackToLogin_Click_1(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Close();
        }

        //unit converter
        private void pbUnitConverter_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/search?q=inch+to+cm&oq=inch+to+cm&gs_lcrp=EgRlZGdlKgYIABBFGDkyBggAEEUYOdIBCDgyMzhqMGoxqAIAsAIA&sourceid=chrome&ie=UTF-8";
            Features.OpenExternalLink(url);
        }
    }
}
