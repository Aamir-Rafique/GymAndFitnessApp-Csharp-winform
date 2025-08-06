using GymAndFitness.Classes;
using GymAndFitness.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class DietPlansForm : BaseForm
    {
        private static DietPlansForm instance;
        private DietPlansForm()
        {
            InitializeComponent();
        }
        public static DietPlansForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DietPlansForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesDietForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
            DietPlansFormClass.PremiumFeatureDietPlanForm(rbtnOnline);
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }

        //LOAD
        private async void DietPlansForm_Load(object sender, EventArgs e)
        {
            await DietPlansFormClass.DietPlansFormLoadEvents(timerForPics, pbProfilePicture, pbMembershipStatus, lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput, richTextBoxNotesInput, cmbDietType, txtFoodItem, rbtnOnline);
        }

        public async void ReloadDietPlansFormData()
        {
            await DietPlansFormClass.DietPlansFormLoadEvents(timerForPics, pbProfilePicture, pbMembershipStatus, lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput, richTextBoxNotesInput, cmbDietType, txtFoodItem, rbtnOnline);
        }

        //Diet types  recipes
        private void cmbDietType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedDietType = cmbDietType.SelectedItem.ToString();
            DietPlansFormClass.DynamLoadDietPlans(selectedDietType, pnlDietPlans);
            pbDiet.Visible = false;
        }


        private void timerForPics_Tick_1(object sender, EventArgs e)
        {
            DietPlansFormClass.GetRecipesBanners(pbDiet);
        }


        // Search for FoodItem nutrition info
        //helper method.. when enter key pressed, while txtFoodItem focused, search for item..
        private void txtFoodItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnSearchFoodItem.PerformClick(); // Trigger the button's click event
            }
        }

        //button search
        private void btnSearchFoodItem_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.GetSearchButtonResponse(txtFoodItem, error, groupBoxRadioButtons, rbtnOffline, lblNutritionInfo, rbtnOnline);
        }

        // Add Food items to custom plan
        // Breakfast
        private void btnAddToBreakfast_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.SetBreakfastItems(txtFoodItem, lstBreakfastInput);
        }

        // Lunch
        private void btnAddToLunch_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.SetLunchItems(txtFoodItem, lstLunchInput);
        }

        // Snacks
        private void btnAddToSnacks_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.SetSnacksItems(txtFoodItem, lstSnacksInput);
        }

        // Dinner
        private void btnAddToDinner_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.SetDinnerItems(txtFoodItem, lstDinnerInput);
        }


        //remove from plan
        // Remove selected item from diet plan
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.RemoveFoodItemsFromLists(lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput);
        }


        private void btnCalculateTotalNutrition_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.CalculateTotalNutrition(lblTotalNutrition, lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput);
        }

        //Save plan to Database
        private void btnSaveDietPlan_Click(object sender, EventArgs e)
        {
            DietPlansFormClass.SaveDietPlan(richTextBoxNotesInput, lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput);
        }

        //adding placeholder in txt box
        private void txtFoodItem_Enter(object sender, EventArgs e)
        {
            txtFoodItem.Text = "";
            txtFoodItem.ForeColor = Color.Black;
        }

        private void txtFoodItem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoodItem.Text))
            {
                txtFoodItem.Text = "Type here";
                txtFoodItem.ForeColor = Color.Gray;
            }
        }

        private void DietPlansForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }

        private void cmbDietType_KeyPress(object sender, KeyPressEventArgs e)
        {
            Features.ComboBoxValidation(sender, e);
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
