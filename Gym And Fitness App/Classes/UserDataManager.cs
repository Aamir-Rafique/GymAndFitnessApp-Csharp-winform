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


        //save user details
        public static void SignUpUser(string username, string password, int age, string gender, double height, double weight, double bmi, double targetWeight, string targetWeightRange, string fitnessGoal, string fitnessLevel, byte[] profilePicture)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open(); // SQL query to insert data
                    string query = "INSERT INTO Users ([Username], [Password], [Age], [Gender], [Height], [StartingWeight], [BMI], [TargetWeight], [TargetWeightRange], [FitnessGoal], [FitnessLevel], [ProfilePicture]) " + "VALUES (@Username, @Password, @Age, @Gender, @Height, @StartingWeight, @BMI, @TargetWeight, @TargetWeightRange, @FitnessGoal, @FitnessLevel, @ProfilePicture)"; using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username); command.Parameters.AddWithValue("@Password", password); command.Parameters.AddWithValue("@Age", age); command.Parameters.AddWithValue("@Gender", gender); command.Parameters.AddWithValue("@Height", height); command.Parameters.AddWithValue("@StartingWeight", weight); command.Parameters.AddWithValue("@BMI", bmi); command.Parameters.AddWithValue("@TargetWeight", targetWeight); command.Parameters.AddWithValue("@TargetWeightRange", targetWeightRange); command.Parameters.AddWithValue("@FitnessGoal", fitnessGoal); command.Parameters.AddWithValue("@FitnessLevel", fitnessLevel); command.Parameters.AddWithValue("@ProfilePicture", profilePicture ?? (object)DBNull.Value); command.ExecuteNonQuery();
                        MessageBox.Show("Sign-Up Successful!", "Success");

                        // Open the login form and close the current form
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Database Error");
                }
            }
        }

        //verify login
        public static bool IsValidLogin(string username, string password)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = ? AND Password = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

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


        //get user details
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
                                    StartingWeight = double.Parse(reader["StartingWeight"].ToString()),
                                    CurrentWeight = double.Parse(reader["CurrentWeight"].ToString()),
                                    BMI = double.Parse(reader["BMI"].ToString()),
                                    TargetWeightRange = reader["TargetWeightRange"].ToString(),
                                    TargetWeight = double.Parse(reader["TargetWeight"].ToString()),
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

        //verify and update license keys
        public static void VerifyLicenseKey(string username, string enteredKey)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT LicenseKey FROM Users WHERE Username = @Username";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result.ToString() == enteredKey)
                    {
                        MessageBox.Show("License key validated successfully! You now have premium membership.", "Validation Success");

                        CurrentUser.MembershipStatus = "Premium";
                        UpdateMembershipInDatabase("Premium");

                        ProfileForm profile = new ProfileForm();
                        profile.Show();

                        // Assuming this is called from a form, close the current form
                        // ((Form)Application.OpenForms[0]).Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid license key. Please try again.", "Validation Failed");
                    }
                }
            }
        }


        //updateMembershipsatatus
        public static void UpdateMembershipInDatabase(string membershipStatus)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Users SET MembershipStatus = @MembershipStatus WHERE UserID = @UserID";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MembershipStatus", membershipStatus);
                    command.Parameters.AddWithValue("@UserID", CurrentUser.UserID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        //store license key
        public static void StoreLicenseKey(string licenseKey)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Users SET LicenseKey = @LicenseKey, MembershipStatus = 'Premium' WHERE Username = @Username";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseKey", licenseKey);
                    command.Parameters.AddWithValue("@Username", CurrentUser.Username);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }





        //button save workout plan click
        public static void SaveWorkoutPlan(DataGridView dgvWorkoutPlan)
        {
            int userId = CurrentUser.UserID;

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


        //load workout plan..
        public static void LoadWorkoutPlan(DataGridView dgvWorkoutPlan, int userId)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open(); string query = "SELECT Day, Workout, Duration, Intensity FROM WorkoutPlan WHERE UserID = @UserID"; using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId); using (OleDbDataReader reader = cmd.ExecuteReader())
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





        //add dietplan
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

        //save diet plan
        public static void SaveDietPlan(ListBox lstBreakfastInput, ListBox lstLunchInput, ListBox lstSnacksInput, ListBox lstDinnerInput, string notes)
        {
            int userId = CurrentUser.UserID;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO DietPlan (UserID, MealTime, FoodItem, Notes) VALUES (@UserID, @MealTime, @FoodItem, @Notes)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
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



        //remove workout plan
        public static void RemoveSelectedItem(ListBox listBox, string mealTime)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();
                listBox.Items.Remove(selectedItem);

                int userId = CurrentUser.UserID; // Replace with actual logic to get the current user ID

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "DELETE FROM DietPlan WHERE UserID = @UserID AND MealTime = @MealTime AND FoodItem = @FoodItem";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
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


        //load diet plans 
        public static void LoadDietPlans(int userId, ListBox lstBreakfastInput, ListBox lstLunchInput, ListBox lstSnacksInput, ListBox lstDinnerInput, RichTextBox richTextBoxNotesInput)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Change query to select based on UserId or Username
                    string query = "SELECT MealTime, FoodItem, Notes FROM DietPlan WHERE UserID = @UserID"; // Ensure the column name matches the database

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);  // Add parameter for userId

                        using (OleDbDataReader reader = cmd.ExecuteReader())  // Use OleDbDataReader for MS Access
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


        //update water intake
        public static void UpdateDailyWaterIntake()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Users SET DailyWaterIntake = @DailyWaterIntake WHERE Username = @Username";

                using (OleDbCommand command = new OleDbCommand(query, connection))
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
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "UPDATE Users SET DailyWaterIntake = 0 WHERE Username = @Username";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
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
                        string query = "UPDATE Users SET [Height] = @Height,[CurrentWeight] = @CurrentWeight, [BMI] = @BMI WHERE [Username] = @Username";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
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
