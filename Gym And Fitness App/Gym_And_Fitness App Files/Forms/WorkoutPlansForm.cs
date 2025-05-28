using GymAndFitness.Classes;
using GymAndFitness.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class WorkoutPlansForm : BaseForm
    {
        private static WorkoutPlansForm instance;
        private WorkoutPlansForm()
        {
            InitializeComponent();
        }
        public static WorkoutPlansForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WorkoutPlansForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesWorkoutForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
            WorkoutPlansFormClass.PremiumFeatureWorkoutPlan(btnSaveWorkoutPlan);
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }

        //load
        private async void WorkoutPlansForm_Load(object sender, EventArgs e)
        {
            await WorkoutPlansFormClass.WorkoutPlansFormLoadEvents(timerForPics, pbMembershipStatus, pbProfilePicture, dgvWorkoutPlan, cmbExercise, cmbWorkoutType, btnSaveWorkoutPlan);
        }

        public async void ReloadWorkoutPlansData()
        {
            await WorkoutPlansFormClass.WorkoutPlansFormLoadEvents(timerForPics, pbMembershipStatus, pbProfilePicture, dgvWorkoutPlan, cmbExercise, cmbWorkoutType, btnSaveWorkoutPlan);
        }


        private void timerForPics_Tick(object sender, EventArgs e)
        {
            WorkoutPlansFormClass.WorkoutPicsBanner(pbWorkout);
        }

        //type of workout
        private void cmbWorkoutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWorkoutType = cmbWorkoutType.SelectedItem.ToString();
            WorkoutPlansFormClass.DynamLoadExercises(selectedWorkoutType, pnlExercises);
            pbWorkout.Visible = false;
        }

        private void btnSaveWorkoutPlan_Click(object sender, EventArgs e)
        {
            WorkoutPlansFormClass.SaveWorkoutPlan(dgvWorkoutPlan);
        }

        private void cmbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkoutPlansFormClass.SelectExercise(cmbExercise, lblExerciseInfo);
        }

        private void WorkoutPlansForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }

        private void cmbWorkoutType_KeyPress(object sender, KeyPressEventArgs e)
        {
            Features.ComboBoxValidation(sender, e);
        }

        private void cmbExercise_KeyPress(object sender, KeyPressEventArgs e)
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
