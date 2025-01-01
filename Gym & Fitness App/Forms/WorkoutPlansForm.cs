using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Gym___Fitness_App
{
    public partial class WorkoutPlansForm : Form
    {
        public WorkoutPlansForm()
        {
            InitializeComponent();
        }


        //connection string...
        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;



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
                UserDataManager.ApplyProfilePicture(btnProfilePicture);

                //database
                int userId = UserDataManager.CurrentUser.UserID; // Replace with logic to get the logged-in user's ID
                LoadWorkoutPlan(userId);
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
            Properties.Resources.workout6
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
                // Create a new font with the desired family, size, and style
                Font newFont = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic); // Apply the font to a Label control
                lblExercise.Font = newFont;


                Label lblInstructions = new Label();
                lblInstructions.Text = exercise.Instructions;
                lblInstructions.Location = new Point(10, yOffset + 20);
                lblInstructions.AutoSize = true;
                Font newFont1 = new Font("Arial", 12, FontStyle.Regular); // Apply the font to a Label control
                lblInstructions.Font = newFont1;

                PictureBox picExercise = new PictureBox();
                picExercise.ImageLocation = exercise.GifUrl;
                picExercise.SizeMode = PictureBoxSizeMode.StretchImage;
                picExercise.Size = new Size(300, 260);
                picExercise.Location = new Point(13, yOffset + 50);
                pnlExercises.Controls.Add(lblExercise);

                pnlExercises.Controls.Add(lblInstructions);
                pnlExercises.Controls.Add(picExercise);
                yOffset += 330; // Adjust spacing as needed } }

            }
        }


        //for labels font 


        private List<Exercise> GetExercises(string workoutType)
        {
            List<Exercise> exercises = new List<Exercise>();

            if (workoutType == "Gym Workout")
            {
                exercises.Add(new Exercise { Name = "1. Bench Press", Instructions = "- Lie on a bench\n- Grip the barbell\n- Lower it to your chest\n- Press it back up.", GifUrl = "https://giphy.com/gifs/press-bench-chest-z1Suqc2f0GCPReDgUB.gif" });
                exercises.Add(new Exercise { Name = "2. Deadlifts", Instructions = "- Stand with your feet hip-width apart\n- Grip the barbell\n- Lift it by extending your hips and knees.", GifUrl = "https://example.com/deadlifts.gif" });
                exercises.Add(new Exercise { Name = "3. Squats", Instructions = "- Position the barbell on your upper back\n- Lower your hips until your thighs are parallel to the floor\n- Stand back up.", GifUrl = "https://example.com/squats.gif" });
                exercises.Add(new Exercise { Name = "4. Lat Pulldown", Instructions = "- Sit at the machine\n- Grip the bar\n- Pull it down to your chest while keeping your back straight.", GifUrl = "https://example.com/lat_pulldown.gif" });
                exercises.Add(new Exercise { Name = "5. Shoulder Press", Instructions = "- Sit on a bench with a backrest\n- Press the dumbbells upward until your arms are fully extended.", GifUrl = "https://example.com/shoulder_press.gif" });
                exercises.Add(new Exercise { Name = "6. Bicep Curls", Instructions = "- Hold dumbbells at your sides\n- Curl them up to shoulder level\n- Lower them back down.", GifUrl = "https://example.com/bicep_curls.gif" });
                exercises.Add(new Exercise { Name = "7. Tricep Dips", Instructions = "- Place your hands on a bench behind you\n- Lower your body\n- Push back up.", GifUrl = "https://example.com/tricep_dips.gif" });
                exercises.Add(new Exercise { Name = "8. Chest Fly", Instructions = "- Lie on a bench\n- Hold dumbbells above your chest\n- Open your arms wide\n- Bring them back together.", GifUrl = "https://example.com/chest_fly.gif" });
                exercises.Add(new Exercise { Name = "9. Leg Press", Instructions = "- Sit on the leg press machine\n- Push the platform away from your body\n- Return to the start.", GifUrl = "https://example.com/leg_press.gif" });
                exercises.Add(new Exercise { Name = "10. Cable Rows", Instructions = "- Sit at the cable machine\n- Pull the handle towards your body\n- Release.", GifUrl = "https://example.com/cable_rows.gif" });
                exercises.Add(new Exercise { Name = "11. Incline Dumbbell Press", Instructions = "- Lie on an incline bench\n- Press dumbbells upward\n- Lower them back down.", GifUrl = "https://example.com/incline_press.gif" });
                exercises.Add(new Exercise { Name = "12. T-Bar Rows", Instructions = "- Grip the T-bar\n- Row the bar towards your chest\n- Slowly release.", GifUrl = "https://example.com/tbar_rows.gif" });
                exercises.Add(new Exercise { Name = "13. Pull-Ups", Instructions = "- Hang from a bar\n- Pull your body up until your chin is above the bar\n- Lower back down.", GifUrl = "https://example.com/pull_ups.gif" });
                exercises.Add(new Exercise { Name = "14. Seated Calf Raises", Instructions = "- Sit at the calf raise machine\n- Press up onto your toes\n- Lower back down.", GifUrl = "https://example.com/calf_raises.gif" });
                exercises.Add(new Exercise { Name = "15. Hammer Curls", Instructions = "- Hold dumbbells with a neutral grip\n- Curl them up\n- Lower them back down.", GifUrl = "https://example.com/hammer_curls.gif" });
            }

            else if (workoutType == "Home Workout")
            {
                exercises.Add(new Exercise { Name = "1. Push-ups", Instructions = "- Start in a plank position with your hands shoulder-width apart\n- Lower your body until your chest nearly touches the floor\n- Push back up.", GifUrl = "https://example.com/push_ups.gif" });
                exercises.Add(new Exercise { Name = "2. Lunges", Instructions = "- Step forward with one leg\n- Lower your hips until both knees are bent at about a 90-degree angle.", GifUrl = "https://example.com/lunges.gif" });
                exercises.Add(new Exercise { Name = "3. Plank", Instructions = "- Hold a plank position with your forearms and toes on the ground\n- Keep your body in a straight line.", GifUrl = "https://example.com/plank.gif" });
                exercises.Add(new Exercise { Name = "4. Burpees", Instructions = "- Begin standing\n- Drop into a squat\n- Kick your feet back into a plank\n- Perform a push-up\n- Return to standing.", GifUrl = "https://example.com/burpees.gif" });
                exercises.Add(new Exercise { Name = "5. Mountain Climbers", Instructions = "- Start in a plank position\n- Alternately drive your knees toward your chest in a running motion.", GifUrl = "https://example.com/mountain_climbers.gif" });
                exercises.Add(new Exercise { Name = "6. Jumping Jacks", Instructions = "- Jump with your legs spreading apart\n- Hands touching above your head\n- Return to the starting position.", GifUrl = "https://example.com/jumping_jacks.gif" });
                exercises.Add(new Exercise { Name = "7. Leg Raises", Instructions = "- Lie on your back\n- Keep your legs straight\n- Lift them upward until perpendicular to the floor.", GifUrl = "https://example.com/leg_raises.gif" });
                exercises.Add(new Exercise { Name = "8. Side Plank", Instructions = "- Lie on your side\n- Prop your body up with one forearm\n- Hold the position.", GifUrl = "https://example.com/side_plank.gif" });
                exercises.Add(new Exercise { Name = "9. Wall Sit", Instructions = "- Lean against a wall\n- Bend your knees at 90 degrees\n- Hold the position.", GifUrl = "https://example.com/wall_sit.gif" });
                exercises.Add(new Exercise { Name = "10. Step-Ups", Instructions = "- Step onto a raised platform\n- Step back down.", GifUrl = "https://example.com/step_ups.gif" });
                exercises.Add(new Exercise { Name = "11. High Knees", Instructions = "- Run in place\n- Lift your knees as high as possible.", GifUrl = "https://example.com/high_knees.gif" });
                exercises.Add(new Exercise { Name = "12. Glute Bridge", Instructions = "- Lie on your back\n- Bend your knees\n- Lift your hips upward.", GifUrl = "https://example.com/glute_bridge.gif" });
                exercises.Add(new Exercise { Name = "13. Superman", Instructions = "- Lie face down\n- Lift your arms and legs off the ground\n- Hold.", GifUrl = "https://example.com/superman.gif" });
                exercises.Add(new Exercise { Name = "14. Flutter Kicks", Instructions = "- Lie on your back\n- Keep your legs straight\n- Alternate kicking them upward.", GifUrl = "https://example.com/flutter_kicks.gif" });
                exercises.Add(new Exercise { Name = "15. Reverse Crunches", Instructions = "- Lie on your back\n- Lift your knees towards your chest\n- Lift your hips off the floor.", GifUrl = "https://example.com/reverse_crunches.gif" });

            }

            else if (workoutType == "Yoga")
            {
                exercises.Add(new Exercise { Name = "1. Downward Dog", Instructions = "- Start on all fours\n- Lift your hips toward the ceiling\n- Straighten your legs into an inverted V-shape.", GifUrl = "https://example.com/downward_dog.gif" });
                exercises.Add(new Exercise { Name = "2. Warrior Pose", Instructions = "- Step one foot forward\n- Bend the front knee\n- Stretch your arms above your head.", GifUrl = "https://example.com/warrior_pose.gif" });
                exercises.Add(new Exercise { Name = "3. Tree Pose", Instructions = "- Stand on one leg\n- Place the sole of the other foot on your inner thigh\n- Bring your hands together above your head.", GifUrl = "https://example.com/tree_pose.gif" });
                exercises.Add(new Exercise { Name = "4. Cat-Cow Stretch", Instructions = "- On all fours\n- Alternate between arching your back (cow) and rounding it (cat).", GifUrl = "https://example.com/cat_cow_stretch.gif" });
                exercises.Add(new Exercise { Name = "5. Child's Pose", Instructions = "- Sit back on your heels\n- Stretch your arms forward\n- Rest your forehead on the floor.", GifUrl = "https://example.com/childs_pose.gif" });
                exercises.Add(new Exercise { Name = "6. Cobra Pose", Instructions = "- Lie on your stomach\n- Place your hands under your shoulders\n- Lift your chest upward.", GifUrl = "https://example.com/cobra_pose.gif" });
                exercises.Add(new Exercise { Name = "7. Bridge Pose", Instructions = "- Lie on your back\n- Bend your knees\n- Lift your hips upward.", GifUrl = "https://example.com/bridge_pose.gif" });
                exercises.Add(new Exercise { Name = "8. Pigeon Pose", Instructions = "- Bring one leg forward\n- Bend it\n- Stretch the other leg behind you.", GifUrl = "https://example.com/pigeon_pose.gif" });
                exercises.Add(new Exercise { Name = "9. Half Spinal Twist", Instructions = "- Sit on the floor\n- Twist your upper body\n- Hold onto your opposite knee.", GifUrl = "https://example.com/spinal_twist.gif" });
                exercises.Add(new Exercise { Name = "10. Boat Pose", Instructions = "- Sit on the floor\n- Lift your legs\n- Balance on your hips.", GifUrl = "https://example.com/boat_pose.gif" });
                exercises.Add(new Exercise { Name = "11. Seated Forward Bend", Instructions = "- Sit on the floor with your legs extended\n- Reach forward\n- Try to touch your toes.", GifUrl = "https://example.com/seated_forward_bend.gif" });
                exercises.Add(new Exercise { Name = "12. Camel Pose", Instructions = "- Kneel on the floor\n- Reach back\n- Place your hands on your heels while arching your back.", GifUrl = "https://example.com/camel_pose.gif" });
                exercises.Add(new Exercise { Name = "13. Lotus Pose", Instructions = "- Sit cross-legged\n- Place your feet resting on your thighs\n- Hands resting on your knees.", GifUrl = "https://example.com/lotus_pose.gif" });
                exercises.Add(new Exercise { Name = "14. Eagle Pose", Instructions = "- Wrap one arm under the other\n- One leg over the other\n- Balance on one foot.", GifUrl = "https://example.com/eagle_pose.gif" });
                exercises.Add(new Exercise { Name = "15. Fish Pose", Instructions = "- Lie on your back\n- Arch your upper back\n- Rest the crown of your head on the floor.", GifUrl = "https://example.com/fish_pose.gif" });
            }
            return exercises;
        }



        public class Exercise
        {
            public string Name { get; set; }
            public string Instructions { get; set; }
            public string GifUrl { get; set; }
        }


        //profile button
        private void btnProfilePicture_Click_1(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
            this.Hide();
        }



        //home Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        //bmi calculator button
        private void btnBMICalculator_Click(object sender, EventArgs e)
        {
            BMICalculatorForm bmiCalculator = new BMICalculatorForm();
            bmiCalculator.Show();
            this.Hide();
        }

        //dietplan form
        private void btnDietPlans_Click_1(object sender, EventArgs e)
        {
            DietPlansForm dietPlans = new DietPlansForm();
            dietPlans.Show();
            this.Hide();
        }



        // About Form
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        //tooltip
        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnProfilePicture, "Profile");
        }



        private void btnSaveWorkoutPlan_Click(object sender, EventArgs e)
        {
            // Validate user
            if (UserDataManager.CurrentUser == null || UserDataManager.CurrentUser.UserID <= 0)
            {
                MessageBox.Show("No user is logged in or User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = UserDataManager.CurrentUser.UserID;



            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Clear existing workout plans for the user
                    string deleteQuery = "DELETE FROM WorkoutPlan WHERE UserID = @UserID";
                    using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = userId });
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Insert updated workout plan
                    string insertQuery = "INSERT INTO WorkoutPlan ([UserID], [Day], [Workout], [Duration], [Intensity]) VALUES (@UserID, @Day, @Workout, @Duration, @Intensity)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        foreach (DataGridViewRow row in dgvWorkoutPlan.Rows)
                        {
                            if (!row.IsNewRow) // Skip the empty row at the end
                            {
                                insertCmd.Parameters.Clear();
                                insertCmd.Parameters.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = userId });
                                insertCmd.Parameters.Add(new OleDbParameter("@Day", OleDbType.VarChar) { Value = row.Cells["Day"].Value?.ToString() ?? "" });
                                insertCmd.Parameters.Add(new OleDbParameter("@Workout", OleDbType.VarChar) { Value = row.Cells["Workout"].Value?.ToString() ?? "" });
                                insertCmd.Parameters.Add(new OleDbParameter("@Duration", OleDbType.VarChar) { Value = row.Cells["Duration"].Value?.ToString() ?? "" });
                                insertCmd.Parameters.Add(new OleDbParameter("@Intensity", OleDbType.VarChar) { Value = row.Cells["Intensity"].Value?.ToString() ?? "" });
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Workout plan saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void LoadWorkoutPlan(int userId)
        {

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Day, Workout, Duration, Intensity FROM WorkoutPlan WHERE UserID = @UserID";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            dgvWorkoutPlan.Rows.Clear(); // Clear existing rows in the DataGridView

                            while (reader.Read())
                            {
                                dgvWorkoutPlan.Rows.Add(
                                    reader["Day"].ToString(),
                                    reader["Workout"].ToString(),
                                    reader["Duration"].ToString(),
                                    reader["Intensity"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

    }
}
