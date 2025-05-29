using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GymAndFitness
{

    public static class UserDataManager
    {
        public static User CurrentUser { get; set; }  //declared static so that the same value is passed for all the forms/classes.. i.e. current user =1;  single copy of this CurrentUser attribute..

        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;

        // Constructor
        //public UserDataManager()
        //{
        //    // Initialize any necessary objects or properties here
        //}

        // Save user details
        public static void SignUpUser(string username, string password, int age, string gender, double height, double weight, double bmi, double targetWeight, string targetWeightRange, string fitnessGoal, string fitnessLevel, byte[] profilePicture, string membershipStatus, double currentWeight)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users ([Username], [Password], [Age], [Gender], [Height], [StartingWeight], [BMI], [TargetWeight], [TargetWeightRange], [FitnessGoal], [FitnessLevel], [ProfilePicture], [MembershipStatus], [CurrentWeight]) " +
                                   "VALUES (@Username, @Password, @Age, @Gender, @Height, @StartingWeight, @BMI, @TargetWeight, @TargetWeightRange, @FitnessGoal, @FitnessLevel, @ProfilePicture, @MembershipStatus, @CurrentWeight)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Height", height);
                        command.Parameters.AddWithValue("@StartingWeight", weight);
                        command.Parameters.AddWithValue("@BMI", bmi);
                        command.Parameters.AddWithValue("@TargetWeight", targetWeight);
                        command.Parameters.AddWithValue("@TargetWeightRange", targetWeightRange);
                        command.Parameters.AddWithValue("@FitnessGoal", fitnessGoal);
                        command.Parameters.AddWithValue("@FitnessLevel", fitnessLevel);
                        command.Parameters.AddWithValue("@ProfilePicture", profilePicture ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MembershipStatus", membershipStatus);
                        command.Parameters.AddWithValue("@CurrentWeight", currentWeight);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sign-Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open the login form and close the current form
                        Features.OpenLoginForm();
                        Application.OpenForms["SignUpForm"].Close();

                        //connection.Close(); 
                        //no need to close connection if using "using" in method header..
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Database Error");
                }
            }
        }

        //helper method to check whether the entered username is avalable or not..
        public static bool IsUsernameAvailable(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username COLLATE Latin1_General_CS_AS = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int count = (int)cmd.ExecuteScalar();

                        return count == 0; // Returns true if username is available, false if taken
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false in case of an error
                }
            }
        }




        // Verify login
        public static bool IsValidLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username COLLATE Latin1_General_CS_AS = @Username AND Password COLLATE Latin1_General_CS_AS = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Get user details
        public static User GetUserDetails(string username)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE [Username] = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    UserID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : 0,
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Age = reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : 0,
                                    Gender = reader["Gender"].ToString(),
                                    Height = reader["Height"] != DBNull.Value ? Convert.ToDouble(reader["Height"]) : 0.0,
                                    StartingWeight = reader["StartingWeight"] != DBNull.Value ? Convert.ToDouble(reader["StartingWeight"]) : 0.0,
                                    CurrentWeight = reader["CurrentWeight"] != DBNull.Value ? Convert.ToDouble(reader["CurrentWeight"]) : 0.0,
                                    BMI = reader["BMI"] != DBNull.Value ? Convert.ToDouble(reader["BMI"]) : 0.0,
                                    TargetWeightRange = reader["TargetWeightRange"].ToString(),
                                    TargetWeight = reader["TargetWeight"] != DBNull.Value ? Convert.ToDouble(reader["TargetWeight"]) : 0.0,
                                    FitnessGoal = reader["FitnessGoal"].ToString(),
                                    FitnessLevel = reader["FitnessLevel"].ToString(),
                                    ProfilePicture = reader["ProfilePicture"] != DBNull.Value ? (byte[])reader["ProfilePicture"] : null,
                                    DailyWaterIntake = reader["DailyWaterIntake"] != DBNull.Value ? Convert.ToDouble(reader["DailyWaterIntake"]) : 0.0,
                                    MembershipStatus = reader["MembershipStatus"].ToString(),
                                    LicenseKey = reader["LicenseKey"].ToString(),
                                };
                                // Reset Daily Water Intake if the date has changed
                                DateTime? lastResetDate = reader["LastResetDate"] != DBNull.Value ? Convert.ToDateTime(reader["LastResetDate"]) : (DateTime?)null;
                                DateTime currentDate = DateTime.Now.Date;

                                if (lastResetDate == null || lastResetDate.Value.Date != currentDate)
                                {
                                    ResetDailyWaterIntake(user.UserID, currentDate);
                                    user.DailyWaterIntake = 0; // Update the in-memory object
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching user details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CurrentUser = user;
            return user;
        }

        //auto resetwaterintake helper method..
        private static void ResetDailyWaterIntake(int userId, DateTime currentDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Users SET DailyWaterIntake = 0, LastResetDate = @LastResetDate WHERE UserID = @UserID";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@UserID", userId);
                    updateCommand.Parameters.AddWithValue("@LastResetDate", currentDate);

                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                }
            }
        }



        // Verify and update license keys
        public static void VerifyLicenseKey(string username, string enteredKey)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT LicenseKey FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result.ToString() == enteredKey)
                    {
                        MessageBox.Show("License key validated successfully!", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CurrentUser.MembershipStatus = "Premium";
                        UpdateMembershipInDatabase("Premium");

                    }
                    else
                    {
                        MessageBox.Show("Invalid license key. Please try again.", "Validation Failed");
                    }
                }
            }
        }

        // Update membership status
        public static void UpdateMembershipInDatabase(string membershipStatus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET MembershipStatus = @MembershipStatus WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MembershipStatus", membershipStatus);
                    command.Parameters.AddWithValue("@UserID", CurrentUser.UserID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Store license key 
        public static void StoreLicenseKey(string licenseKey)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET LicenseKey = @LicenseKey, MembershipStatus = 'Premium' WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseKey", licenseKey);
                    command.Parameters.AddWithValue("@Username", CurrentUser.Username);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Save workout plan
        public static void SaveWorkoutPlan(DataGridView dgvWorkoutPlan)
        {
            int userId = CurrentUser.UserID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Clear existing workout plans for the user
                    string deleteQuery = "DELETE FROM WorkoutPlan WHERE UserID = @UserID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = userId });
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Insert updated workout plan
                    string insertQuery = "INSERT INTO WorkoutPlan ([UserID], [Day], [Workout], [Duration], [Intensity]) VALUES (@UserID, @Day, @Workout, @Duration, @Intensity)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        foreach (DataGridViewRow row in dgvWorkoutPlan.Rows)
                        {
                            if (!row.IsNewRow) // Skip the empty row at the end
                            {
                                insertCmd.Parameters.Clear();
                                insertCmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = userId });
                                insertCmd.Parameters.Add(new SqlParameter("@Day", SqlDbType.VarChar) { Value = row.Cells["Day"].Value?.ToString() ?? "" });
                                insertCmd.Parameters.Add(new SqlParameter("@Workout", SqlDbType.VarChar) { Value = row.Cells["Workout"].Value?.ToString() ?? "" });
                                insertCmd.Parameters.Add(new SqlParameter("@Duration", SqlDbType.VarChar) { Value = row.Cells["Duration"].Value?.ToString() ?? "" });
                                insertCmd.Parameters.Add(new SqlParameter("@Intensity", SqlDbType.VarChar) { Value = row.Cells["Intensity"].Value?.ToString() ?? "" });
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

        // Load workout plan
        public static void LoadWorkoutPlan(DataGridView dgvWorkoutPlan, int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Day, Workout, Duration, Intensity FROM WorkoutPlan WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dgvWorkoutPlan.Rows.Clear(); // Clear existing rows in the DataGridView
                            while (reader.Read())
                            {
                                dgvWorkoutPlan.Rows.Add(reader["Day"].ToString(),
                                    reader["Workout"].ToString(),
                                    reader["Duration"].ToString(),
                                    reader["Intensity"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Add diet plan
        public static void AddDietPlan(DietPlan dietPlan)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("No current user selected. Cannot add diet plan.", "Error");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO DietPlan (UserID, MealTime, FoodItem, Notes) VALUES (@UserID, @MealTime, @FoodItem, @Notes)";
                    using (SqlCommand command = new SqlCommand(query, connection))
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

        // Save diet plan
        public static void SaveDietPlan(ListBox lstBreakfastInput, ListBox lstLunchInput, ListBox lstSnacksInput, ListBox lstDinnerInput, string notes)
        {
            int userId = CurrentUser.UserID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO DietPlan (UserID, MealTime, FoodItem, Notes) VALUES (@UserID, @MealTime, @FoodItem, @Notes)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Save Breakfast items
                        foreach (var item in lstBreakfastInput.Items)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@MealTime", "Breakfast");
                            cmd.Parameters.AddWithValue("@FoodItem", item.ToString());
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.ExecuteNonQuery();
                        }

                        // Save Lunch items
                        foreach (var item in lstLunchInput.Items)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@MealTime", "Lunch");
                            cmd.Parameters.AddWithValue("@FoodItem", item.ToString());
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.ExecuteNonQuery();
                        }

                        // Save Snacks items
                        foreach (var item in lstSnacksInput.Items)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@MealTime", "Snacks");
                            cmd.Parameters.AddWithValue("@FoodItem", item.ToString());
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.ExecuteNonQuery();
                        }

                        // Save Dinner items
                        foreach (var item in lstDinnerInput.Items)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@MealTime", "Dinner");
                            cmd.Parameters.AddWithValue("@FoodItem", item.ToString());
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Diet plan saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Remove workout plan
        public static void RemoveSelectedItem(ListBox listBox, string mealTime)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();
                listBox.Items.Remove(selectedItem);

                int userId = CurrentUser.UserID; // Replace with actual logic to get the current user ID

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM DietPlan WHERE UserID = @UserID AND MealTime = @MealTime AND FoodItem = @FoodItem";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@MealTime", mealTime);
                            cmd.Parameters.AddWithValue("@FoodItem", selectedItem);

                            cmd.ExecuteNonQuery();
                        }

                        // Optional: Show a message indicating success
                        // MessageBox.Show($"Item '{selectedItem}' removed successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Load diet plans
        public static void LoadDietPlans(int userId, ListBox lstBreakfastInput, ListBox lstLunchInput, ListBox lstSnacksInput, ListBox lstDinnerInput, RichTextBox richTextBoxNotesInput)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MealTime, FoodItem, Notes FROM DietPlan WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear the current lists
                            lstBreakfastInput.Items.Clear();
                            lstLunchInput.Items.Clear();
                            lstSnacksInput.Items.Clear();
                            lstDinnerInput.Items.Clear();
                            richTextBoxNotesInput.Clear();

                            // Populate the lists with data from the database
                            while (reader.Read())
                            {
                                string mealTime = reader["MealTime"].ToString();
                                string foodItem = reader["FoodItem"].ToString();
                                string notes = reader["Notes"].ToString();

                                // Add food item to the appropriate meal list based on the MealTime
                                switch (mealTime)
                                {
                                    case "Breakfast":
                                        lstBreakfastInput.Items.Add(foodItem);
                                        break;
                                    case "Lunch":
                                        lstLunchInput.Items.Add(foodItem);
                                        break;
                                    case "Snacks":
                                        lstSnacksInput.Items.Add(foodItem);
                                        break;
                                    case "Dinner":
                                        lstDinnerInput.Items.Add(foodItem);
                                        break;
                                }

                                // Load notes (assuming notes are the same for all meals)
                                if (!string.IsNullOrEmpty(notes))
                                {
                                    richTextBoxNotesInput.Text = notes;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update water intake
        public static void UpdateDailyWaterIntake()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //@ method is used to prevent sql injection!!!
                string query = "UPDATE Users SET DailyWaterIntake = @DailyWaterIntake WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DailyWaterIntake", CurrentUser.DailyWaterIntake);
                    command.Parameters.AddWithValue("@Username", CurrentUser.Username);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




        //reset water
        public static void ResetDailyWaterIntake()
        {
            if (CurrentUser != null)
            {
                // Reset DailyWaterIntake to 0
                CurrentUser.DailyWaterIntake = 0;

                // Update the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET DailyWaterIntake = 0 WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", CurrentUser.Username);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Users SET [ProfilePicture] = @ProfilePicture WHERE [Username] = @Username";
                        using (SqlCommand command = new SqlCommand(query, connection))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE Users SET [Height] = @Height,[CurrentWeight] = @CurrentWeight, [BMI] = @BMI WHERE [Username] = @Username";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Height", currentheight);
                            command.Parameters.AddWithValue("@CurrentWeight", currentweight);
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




        //change Profile Picture

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

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
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
