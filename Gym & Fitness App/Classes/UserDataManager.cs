using System;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GymAndFitness
{
    public static class UserDataManager
    {

        public static User CurrentUser { get; set; }

        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;

        public static User GetUserDetails(string username)
        {
            User user = null;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Users WHERE [Username] = @Username";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    UserID = int.Parse(reader["UserID"].ToString()),
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Age = int.Parse(reader["Age"].ToString()),
                                    Gender = reader["Gender"].ToString(),
                                    Height = double.Parse(reader["Height"].ToString()),
                                    Weight = double.Parse(reader["Weight"].ToString()),
                                    BMI = double.Parse(reader["BMI"].ToString()),
                                    TargetWeight = reader["TargetWeight"].ToString(),
                                    FitnessGoal = reader["FitnessGoal"].ToString(),
                                    FitnessLevel = reader["FitnessLevel"].ToString(),
                                    ProfilePicture = reader["ProfilePicture"] as byte[],
                                    DailyWaterIntake = reader["DailyWaterIntake"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DailyWaterIntake"]),
                                    MembershipStatus = reader["MembershipStatus"].ToString(),
                                    LicenseKey = reader["LicenseKey"].ToString(),

                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching user details: {ex.Message}", "Database Error");
                }
            }

            CurrentUser = user;
            return user;
        }

        public static void AddWorkoutPlan(WorkoutPlan workoutPlan)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("No current user selected. Cannot add workout plan.", "Error");
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO WorkoutPlan (UserID, Day, Workout, Duration, Intensity) VALUES (@UserID, @Day, @Workout, @Duration, @Intensity)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", CurrentUser.UserID);
                        command.Parameters.AddWithValue("@Day", workoutPlan.Day);
                        command.Parameters.AddWithValue("@Workout", workoutPlan.Workout);
                        command.Parameters.AddWithValue("@Duration", workoutPlan.Duration);
                        command.Parameters.AddWithValue("@Intensity", workoutPlan.Intensity);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding workout plan: {ex.Message}", "Database Error");
                }
            }
        }

        public static void AddDietPlan(DietPlan dietPlan)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("No current user selected. Cannot add diet plan.", "Error");
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO DietPlan (UserID, MealTime, FoodItem, Notes) VALUES (@UserID, @MealTime, @FoodItem, @Notes)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", CurrentUser.UserID);
                        command.Parameters.AddWithValue("@MealTime", dietPlan.MealTime);
                        command.Parameters.AddWithValue("@FoodItem", dietPlan.FoodItem);
                        command.Parameters.AddWithValue("@Notes", dietPlan.Notes);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding diet plan: {ex.Message}", "Database Error");
                }
            }
        }

        //public static List<WorkoutPlan> GetWorkoutPlans()
        //{
        //    List<WorkoutPlan> workoutPlans = new List<WorkoutPlan>();

        //    if (CurrentUser == null)
        //    {
        //        MessageBox.Show("No current user selected. Cannot fetch workout plans.", "Error");
        //        return workoutPlans;
        //    }

        //    using (OleDbConnection connection = new OleDbConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            string query = "SELECT * FROM WorkoutPlans WHERE UserID = @UserID";
        //            using (OleDbCommand command = new OleDbCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@UserID", CurrentUser.UserID);
        //                using (OleDbDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        WorkoutPlan plan = new WorkoutPlan
        //                        {
        //                            UserID = CurrentUser.UserID,
        //                            Day = reader["Day"].ToString(),
        //                            Workout = reader["Workout"].ToString(),
        //                            Duration = reader["Duration"].ToString(),
        //                            Intensity = reader["Intensity"].ToString(),
        //                        };
        //                        workoutPlans.Add(plan);
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error fetching workout plans: {ex.Message}", "Database Error");
        //        }
        //    }

        //    return workoutPlans;
        //}

        //public static List<DietPlan> GetDietPlans()
        //{
        //    List<DietPlan> dietPlans = new List<DietPlan>();

        //    if (CurrentUser == null)
        //    {
        //        MessageBox.Show("No current user selected. Cannot fetch diet plans.", "Error");
        //        return dietPlans;
        //    }

        //    using (OleDbConnection connection = new OleDbConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            string query = "SELECT * FROM DietPlans WHERE UserID = @UserID";
        //            using (OleDbCommand command = new OleDbCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@UserID", CurrentUser.UserID);
        //                using (OleDbDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        DietPlan plan = new DietPlan
        //                        {
        //                            UserID = CurrentUser.UserID,
        //                            MealTime = reader["MealTime"].ToString(),
        //                            FoodItem = Convert.ToInt32(reader["FoodItem"]),
        //                            Notes = reader["Notes"].ToString(),
        //                        };
        //                        dietPlans.Add(plan);
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error fetching diet plans: {ex.Message}", "Database Error");
        //        }
        //    }

        //    return dietPlans;
        //}

        
        
        public static void ApplyProfilePicture(PictureBox pictureBox)
        {
            if (CurrentUser != null && CurrentUser.ProfilePicture != null)
            {
                using (MemoryStream ms = new MemoryStream(CurrentUser.ProfilePicture))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox.Image = Properties.Resources.usernew;
            }
        }



        public static void UpdateProfilePictureInDatabase(byte[] profilePicture)
        {
            if (CurrentUser != null)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Users SET [ProfilePicture] = @ProfilePicture WHERE [Username] = @Username";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProfilePicture", profilePicture);
                            command.Parameters.AddWithValue("@Username", CurrentUser.Username);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating profile picture: {ex.Message}", "Database Error");
                    }
                }

                // Update the local CurrentUser object
                CurrentUser.ProfilePicture = profilePicture;
            }
        }

        //update Height & weight
        public static void UpdateHeightAndWeight(double currentheight, double currentweight, double currentBMI)
        {
            if (CurrentUser != null)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Users SET [Height] = @Height,[Weight] = @Weight, [BMI] = @BMI WHERE [Username] = @Username";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Height", currentheight);
                            command.Parameters.AddWithValue("@Weight", currentweight);
                            command.Parameters.AddWithValue("@BMI", currentBMI);
                            command.Parameters.AddWithValue("@Username", CurrentUser.Username);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating height and weight: {ex.Message}", "Database Error");
                    }
                }
            }
        }





        public static void ChangeProfilePicture(PictureBox pictureBox)
        {
            // Open file dialog to let user choose an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Convert selected image to byte array
                    byte[] profilePicture = File.ReadAllBytes(openFileDialog.FileName);

                    // Update the profile picture in the database
                    UpdateProfilePictureInDatabase(profilePicture);

                    // Apply the new profile picture to the PictureBox in the current form
                    ApplyProfilePicture(pictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error changing profile picture: {ex.Message}", "Error");
                }
            }
        }


        //delete user account
        public static bool DeleteAccount(int userId)
        {
            try
            {
                // Database query to delete the user
                string deleteQuery = "DELETE FROM Users WHERE UserID = @UserID";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.ExecuteNonQuery();
                    }
                }

                // Clear current user data
                CurrentUser = null;

                return true; // Deletion successful
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine($"Error deleting account: {ex.Message}");
                return false; // Deletion failed
            }
        }





    }
}
