using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class WorkoutPlansForm : Form
    {
        public WorkoutPlansForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)

        //load
        private void WorkoutPlansForm_Load(object sender, EventArgs e)
        {
            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed

            //workoutpics
            timerForPics.Start();

            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(btnProfilePicture);
                int userId = UserDataManager.CurrentUser.UserID; // Replace with logic to get the logged-in user's ID
                userDataManager.LoadWorkoutPlan(dgvWorkoutPlan, userId);
            }
        }



        //for slide panel
        private bool isPanelCollapsed = true; // Track panel state
        private int panelWidth; // Store the panel's default width


        //slide  panel timer 
        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelCollapsed)
            {
                //pnlMain.BackColor = Color.LimeGreen; //change the color of main panel
                slidePanel.Width += 7; // Expand the panel
                if (slidePanel.Width >= panelWidth)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = false; // Panel is now expanded
                }
            }
            else
            {
                //pnlMain.BackColor = Color.LightGreen; //change the color of main panel
                slidePanel.Width -= 7; // Collapse the panel
                if (slidePanel.Width <= 45)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = true; // Panel is now collapsed
                }
            }
        }


        //menu
        private void btnToggle_Click_1(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
            slidePanel.BringToFront();  //to remove glitches while sliding
        }


        private int imageIndex = 0;

        private void timerForPics_Tick(object sender, EventArgs e)
        {
            // Array of workout images
            Image[] workoutImages = {
            Properties.Resources.workout1,
            Properties.Resources.workout2,
            Properties.Resources.workout3,
            Properties.Resources.workout4,
            Properties.Resources.workout5,
            Properties.Resources.workout6,
            Properties.Resources.workout7
              };

            // Generate a random index
            Random random = new Random();
            imageIndex = random.Next(0, workoutImages.Length);

            // Set the current image
            pbWorkout.Image = workoutImages[imageIndex];
        }



        //type of workout
        private void cmbWorkoutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWorkoutType = cmbWorkoutType.SelectedItem.ToString();
            LoadExercises(selectedWorkoutType);
            pbWorkout.Visible = false;
        }



        private void LoadExercises(string workoutType)
        {
            pnlExercises.Controls.Clear();
            List<Exercise> exercises = GetExercises(workoutType);
            int yOffset = 10;

            foreach (Exercise exercise in exercises)
            {
                Label lblExercise = new Label();
                lblExercise.Text = exercise.Name;
                lblExercise.Location = new Point(10, yOffset);
                lblExercise.AutoSize = true;
                lblExercise.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);

                Label lblInstructions = new Label();
                lblInstructions.Text = exercise.Instructions;
                lblInstructions.Location = new Point(10, yOffset + 20);
                lblInstructions.AutoSize = true;
                lblInstructions.Font = new Font("Arial", 14, FontStyle.Regular);

                PictureBox picExercise = new PictureBox();
                picExercise.Image = exercise.ExerciseImage; // Use the ExerciseImage property
                picExercise.SizeMode = PictureBoxSizeMode.StretchImage;
                picExercise.Size = new Size(500, 280);
                picExercise.Location = new Point(50, yOffset + 115);

                pnlExercises.Controls.Add(lblExercise);
                pnlExercises.Controls.Add(lblInstructions);
                pnlExercises.Controls.Add(picExercise);

                yOffset += 420; // Adjust spacing as needed
            }
        }



        //for labels

        private List<Exercise> GetExercises(string workoutType)
        {
            List<Exercise> exercises = new List<Exercise>();

            if (workoutType == "Gym Workout")
            {
                exercises.Add(new Exercise
                {
                    Name = "1. Bench Press",
                    Instructions = "- Lie on a bench\n- Grip the barbell\n- Lower it to your chest\n- Press it back up.",
                    ExerciseImage = Properties.Resources.BenchPressImage
                });

                exercises.Add(new Exercise
                {
                    Name = "2. Deadlifts",
                    Instructions = "- Stand with your feet hip-width apart\n- Grip the barbell\n- Lift it by extending your hips and knees.",
                    ExerciseImage = Properties.Resources.DeadliftsImage
                });

                exercises.Add(new Exercise
                {
                    Name = "3. Squats",
                    Instructions = "- Position the barbell on your upper back\n- Lower your hips until your thighs are parallel to the floor\n- Stand back up.",
                    ExerciseImage = Properties.Resources.SquatsImage
                });

                exercises.Add(new Exercise
                {
                    Name = "4. Pull-Ups",
                    Instructions = "- Hang from a pull-up bar with your palms facing away\n- Pull your body up until your chin is above the bar\n- Lower yourself back down.",
                    ExerciseImage = Properties.Resources.PullUpsImage
                });

                exercises.Add(new Exercise
                {
                    Name = "5. Shoulder Press",
                    Instructions = "- Sit on a bench with back support\n- Hold dumbbells at shoulder height\n- Press them overhead until your arms are fully extended\n- Lower them back to shoulder height.",
                    ExerciseImage = Properties.Resources.ShoulderPressImage
                });

                // Add more exercises as needed
            }



            else if (workoutType == "Home Workout")
            {
                exercises.Add(new Exercise
                {
                    Name = "1. Push-ups",
                    Instructions = "- Start in a plank position with your hands shoulder-width apart\n- Lower your body until your chest nearly touches the floor\n- Push back up.",
                    ExerciseImage = Properties.Resources.PushupsImage
                });

                exercises.Add(new Exercise
                {
                    Name = "2. Lunges",
                    Instructions = "- Step forward with one leg\n- Lower your hips until both knees are bent at about a 90-degree angle.",
                    ExerciseImage = Properties.Resources.LungesImage
                });

                exercises.Add(new Exercise
                {
                    Name = "3. Plank",
                    Instructions = "- Start in a push-up position\n- Hold your body in a straight line from head to heels\n- Keep your core tight.",
                    ExerciseImage = Properties.Resources.PlankImage
                });

                exercises.Add(new Exercise
                {
                    Name = "4. Burpees",
                    Instructions = "- Start in a standing position\n- Drop into a squat position with your hands on the ground\n- Kick your feet back into a plank position\n- Perform a push-up\n- Return to the squat position\n- Jump up with your arms overhead.",
                    ExerciseImage = Properties.Resources.BurpeesImage
                });

                exercises.Add(new Exercise
                {
                    Name = "5. Mountain Climbers",
                    Instructions = "- Start in a plank position\n- Bring one knee toward your chest\n- Quickly switch legs, bringing the other knee toward your chest\n- Continue alternating legs.",
                    ExerciseImage = Properties.Resources.MountainClimbersImage
                });

                // Add more exercises as needed
            }

            else if (workoutType == "Yoga")
            {
                exercises.Add(new Exercise
                {
                    Name = "1. Downward Dog",
                    Instructions = "- Start on all fours\n- Lift your hips toward the ceiling\n- Straighten your legs into an inverted V-shape.",
                    ExerciseImage = Properties.Resources.DownwardDogImage
                });

                exercises.Add(new Exercise
                {
                    Name = "2. Warrior Pose",
                    Instructions = "- Step one foot forward\n- Bend the front knee\n- Stretch your arms above your head.",
                    ExerciseImage = Properties.Resources.WarriorPoseImage
                });

                exercises.Add(new Exercise
                {
                    Name = "3. Tree Pose",
                    Instructions = "- Stand on one leg\n- Place the sole of the other foot on the inner thigh of the standing leg\n- Bring your hands together in front of your chest.",
                    ExerciseImage = Properties.Resources.TreePoseImage
                });

                exercises.Add(new Exercise
                {
                    Name = "4. Child's Pose",
                    Instructions = "- Kneel on the floor\n- Sit back on your heels\n- Stretch your arms forward and rest your forehead on the ground.",
                    ExerciseImage = Properties.Resources.ChildPoseImage
                });

                exercises.Add(new Exercise
                {
                    Name = "5. Cobra Pose",
                    Instructions = "- Lie face down on the floor\n- Place your hands under your shoulders\n- Lift your chest off the ground while keeping your hips on the floor.",
                    ExerciseImage = Properties.Resources.CobraPoseImage
                });

                // Add more exercises as needed
            }

            return exercises;
        }




        public class Exercise
        {
            public string Name { get; set; }
            public string Instructions { get; set; }
            public Image ExerciseImage { get; set; }
        }


        //to open each form...
        private void btnProfilePicture_Click_1(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Features.OpenMainForm();
            this.Hide();
        }
        private void btnBMICalculator_Click(object sender, EventArgs e)
        {
            Features.OpenBMICalculatorForm();
            this.Hide();
        }
        private void btnDietPlans_Click_1(object sender, EventArgs e)
        {
            Features.OpenDietPlansForm();
            this.Hide();
        }
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            Features.OpenAboutForm();
            this.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }

        private void btnSaveWorkoutPlan_Click(object sender, EventArgs e)
        {
            // Validate user
            if (UserDataManager.CurrentUser == null || UserDataManager.CurrentUser.UserID <= 0)
            {
                MessageBox.Show("No user is logged in or User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userDataManager.SaveWorkoutPlan(dgvWorkoutPlan);
        }




        private void btnProfilePicture_MouseEnter_1(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                toolTip1.SetToolTip(btnProfilePicture, $"{UserDataManager.CurrentUser.Username}'s Profile");
            }
            else
            {
                toolTip1.SetToolTip(btnProfilePicture, "Profile");
            }
        }

        private void btnAddToBreakfast_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToSnacks_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToLunch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToDinner_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFoodItem_Click(object sender, EventArgs e)
        {

        }

        private void txtFoodItem_Enter(object sender, EventArgs e)
        {

        }

        private void txtIngredient_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtFoodItem_Leave(object sender, EventArgs e)
        {

        }
    }
}
