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
            PremiumFeatureWorkoutPlan();
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }


        //load
        private async void WorkoutPlansForm_Load(object sender, EventArgs e)
        {
            await WorkoutPlansFormLoadEvents();

            //old logic..

            ////workoutpics
            //timerForPics.Start();

            ////  accessing current user 
            //if (UserDataManager.CurrentUser != null)
            //{
            //    //load membership plan pics
            //    pbMembershipStatus.Image = Features.MembershipStatusPic();

            //    UserDataManager.ApplyProfilePicture(btnProfilePicture1);
            //    int userId = UserDataManager.CurrentUser.UserID; // Replace with logic to get the logged-in user's ID
            //    UserDataManager.LoadWorkoutPlan(dgvWorkoutPlan, userId);

            //    if (UserDataManager.CurrentUser.MembershipStatus == "Free")
            //    {
            //        btnSaveWorkoutPlan.BackColor = Color.Gray;
            //    }
            //}

            ////combobox text align center..
            //Features.AlignComboBoxTextCenter(cmbExercise);
            //Features.AlignComboBoxTextCenter(cmbWorkoutType);


        }

        private async Task WorkoutPlansFormLoadEvents()
        {
            // Start the timer for workout pictures
            timerForPics.Start();

            // Access the current user
            if (UserDataManager.CurrentUser != null)
            {
                // Load membership plan pictures asynchronously
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());

                // Apply profile picture asynchronously
                await Task.Run(() => UserDataManager.ApplyProfilePicture(pbProfilePicture));

                // Retrieve user ID and load workout plan asynchronously
                int userId = UserDataManager.CurrentUser.UserID; // Replace with logic to get the logged-in user's ID
                await Task.Run(() => UserDataManager.LoadWorkoutPlan(dgvWorkoutPlan, userId));

                PremiumFeatureWorkoutPlan();

            }

            // Align combo box text to center
            Features.AlignComboBoxTextCenter(cmbExercise);
            Features.AlignComboBoxTextCenter(cmbWorkoutType);
        }

        public async void ReloadWorkoutPlansData()
        {
            await WorkoutPlansFormLoadEvents();
        }

        public void PremiumFeatureWorkoutPlan()
        {
            // Update save workout plan button for free members
            if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
            {
                btnSaveWorkoutPlan.BackColor = Color.Gray;
            }
            else
            {
                btnSaveWorkoutPlan.BackColor = Color.MediumSpringGreen;
            }
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


        private void btnSaveWorkoutPlan_Click(object sender, EventArgs e)
        {
            // Validate user
            if (UserDataManager.CurrentUser != null)
            {
                if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
                {
                    MessageBox.Show("Upgrade to premium to save your custom workout plan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserDataManager.SaveWorkoutPlan(dgvWorkoutPlan);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in or User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private async void cmbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExercise.SelectedItem == null)
                return;

            string targetMuscle = cmbExercise.SelectedItem.ToString().ToLower(); // Ensure lowercase for API compatibility
            lblExerciseInfo.Text = "Searching online, please wait...";

            try
            {
                string muscleExerciseInfo = await GetExerciseInfo(targetMuscle);

                if (!string.IsNullOrEmpty(muscleExerciseInfo) && !muscleExerciseInfo.StartsWith("Error"))
                {
                    lblExerciseInfo.Text = muscleExerciseInfo;
                }
                else
                {
                    lblExerciseInfo.Text = "No exercise data found.";
                    //pbExerciseGif.Image = null;  // Clear image if no data
                }
            }
            catch (Exception ex)
            {
                lblExerciseInfo.Text = $"Error: {ex.Message}";
            }
        }

        //ExerciseDB API..
        private async Task<string> GetExerciseInfo(string targetMuscle)
        {
            // Dictionary to map user-friendly muscle names to API-expected format
            var muscleMapping = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "Lower Back", "spine" },
        { "Middle Back", "upper back" },
        { "Neck", "levator scapulae" },
        { "Chest", "pectorals" },
        { "Quadriceps (Quads)", "quads"}, // API might accept "quads"
        { "Serratus Anterior", "serratus anterior" },
        { "Traps (Trapezius)", "traps" },//working
        { "Deltoids (Shoulders)", "delts" }, // API might accept "delts" instead of "deltoids"//working
        { "Abdominals (Abs)", "abs" } // API might accept "abs"
    };

            // Convert selected muscle name to API-friendly format
            if (muscleMapping.ContainsKey(targetMuscle))
            {
                targetMuscle = muscleMapping[targetMuscle];
            }

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://exercisedb.p.rapidapi.com/exercises/target/{targetMuscle}"),
                    Headers =
            {
                { "x-rapidapi-key", "38f96468b6mshb087ba14b2972dfp172ae1jsn5d0c94ebf973" },
                { "x-rapidapi-host", "exercisedb.p.rapidapi.com" },
            },
                };

                try
                {
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var jsonResponse = await response.Content.ReadAsStringAsync();

                        // Parse JSON and format output
                        return FormatExerciseInfo(jsonResponse);
                    }
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }



        //for formatted json output
        private string FormatExerciseInfo(string jsonResponse)
        {
            var exercises = JsonConvert.DeserializeObject<JArray>(jsonResponse);
            if (exercises == null || exercises.Count == 0)
                return "No exercises found for this muscle group.";

            StringBuilder formattedOutput = new StringBuilder();

            foreach (var exercise in exercises)
            {
                string name = exercise["name"]?.ToString() ?? "Unknown Exercise";
                string instructions = exercise["instructions"]?.ToString() ?? "No instructions available.";
                //string gifUrl = exercise["gifUrl"]?.ToString();

                formattedOutput.AppendLine($"🔹 **{name.ToUpper()}**\n");
                formattedOutput.AppendLine($"📖 Instructions: {instructions}\n");

                //if (!string.IsNullOrEmpty(gifUrl))
                //{
                //    formattedOutput.AppendLine($"🖼️ Image: {gifUrl}\n");
                //}

                formattedOutput.AppendLine("----------------------\n");
            }

            return formattedOutput.ToString();
        }
        private void WorkoutPlansForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
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
