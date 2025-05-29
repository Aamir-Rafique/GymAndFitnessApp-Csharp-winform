﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class DashboardFormClass
    {
        public static async Task DasboardFormLoadEvents(
       Timer timerTime,
       Timer timerQuote,
       Label lblDate,
       PictureBox pbProfilePicture,
       PictureBox pbMembershipStatus,
       Button btnLogout,
       Button btnLogin,
       Label lblWaterIntake,
       ProgressBar progressBarWater,
       ProgressBar progressBarWeight,
       Label lblWeightProgess,
       // Add these if PremiumFeatureDashboardForm needs them!
       Label lblPremiumMembers,
       Panel pnlWaterIntake,
       Button btnAddWater,
       Label lblGlasses,
       ToolTip toolTip,
       PictureBox pbwaterintake
   )
        {
            timerTime.Start();
            timerQuote.Start();

            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            if (UserDataManager.CurrentUser != null)
            {
                // Async profile picture load (if thread-safe)
                await Task.Run(() => UserDataManager.ApplyProfilePicture(pbProfilePicture));

                // Load membership plan pictures asynchronously
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());

                // Update buttons based on user status
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                // Weight progress
                ProgressBarWeight(progressBarWeight, lblWeightProgess);

                // Water Intake Progress
                lblWaterIntake.Text = $"{UserDataManager.CurrentUser.DailyWaterIntake} / 8 Glasses";
                progressBarWater.Value = (int)((UserDataManager.CurrentUser.DailyWaterIntake / 8.0) * 100);
                if (progressBarWater.Value == 100)
                {
                    lblWaterIntake.Text = "Great!";
                }

                PremiumFeatureDashboardForm(lblPremiumMembers, pnlWaterIntake, btnAddWater, lblWaterIntake, lblGlasses, progressBarWater, toolTip, pbwaterintake);
            }
            else
            {
                btnLogout.Visible = false;
                btnLogout.Enabled = false;
                btnLogin.Visible = true;
                btnLogin.Enabled = true;

                // Initialize progress bar values for non-logged-in user interaction
                progressBarWater.Value = 15;
                progressBarWeight.Value = 26;
                lblWeightProgess.Text = "Login to view your progress...";
            }
        }


        // Helper Method to Disable Water Tracker/Premium Features
        public static void PremiumFeatureDashboardForm(Label lblPremiumMembers, Panel pnlWaterIntake, Button btnAddWater, Label lblWaterIntake, Label lblGlasses, ProgressBar progressBarWater, ToolTip toolTip, PictureBox pbwaterintake)
        {
            if (UserDataManager.CurrentUser.MembershipStatus == "Free" ||
               UserDataManager.CurrentUser.MembershipStatus == null)
            {
                lblPremiumMembers.Text = "For Premium Members Only!";
                pnlWaterIntake.BackColor = Color.Gainsboro;
                pnlWaterIntake.ForeColor = Color.Gray;
                btnAddWater.BackColor = Color.Gainsboro;
                btnAddWater.Enabled = false;
                lblWaterIntake.ForeColor = Color.Gray;
                lblGlasses.ForeColor = Color.Gray;
                progressBarWater.Enabled = false;
                progressBarWater.Value = 0;
                toolTip.SetToolTip(pnlWaterIntake, "Upgrade to Premium to access this feature!");
                toolTip.SetToolTip(pbwaterintake, "Upgrade to Premium to access this feature!");
                pnlWaterIntake.Cursor = Cursors.Hand;
            }
            else
            {
                lblPremiumMembers.Text = "";
                pnlWaterIntake.BackColor = Color.Turquoise;
                pnlWaterIntake.ForeColor = Color.Black;
                btnAddWater.BackColor = Color.DodgerBlue;
                btnAddWater.Enabled = true;
                lblWaterIntake.ForeColor = Color.Blue;
                lblGlasses.ForeColor = Color.Blue;
                progressBarWater.Enabled = true;
                toolTip.SetToolTip(pnlWaterIntake, "");
                toolTip.SetToolTip(pbwaterintake, "");
                pnlWaterIntake.Cursor = Cursors.Arrow;
            }
        }


        public static void ProgressBarWeight(ProgressBar progressBarWeight, Label lblWeightProgess)
        {
            // Weight Progress
            double startingWeight = UserDataManager.CurrentUser.StartingWeight;
            double currentWeight = UserDataManager.CurrentUser.CurrentWeight;
            double targetWeight = UserDataManager.CurrentUser.TargetWeight;
            double weightProgressPercentage = CalculateWeightProgress(
                startingWeight, currentWeight, targetWeight, UserDataManager.CurrentUser.FitnessGoal
            );

            // Update progress bar and label
            progressBarWeight.Value = (int)weightProgressPercentage;
            lblWeightProgess.Text = $"Fitness Progress: {Math.Round(weightProgressPercentage)}% ";
            if (progressBarWeight.Value == 100)
            {
                lblWeightProgess.Text = $"Congratulations! You have achieved your goal.";
            }
        }




        // Helper Method for Weight Progress Calculation
        public static double CalculateWeightProgress(double startingWeight, double currentWeight, double targetWeight, string fitnessGoal)
        {
            double weightProgressPercentage = 0;

            // Ensure fitnessGoal is valid
            if (string.IsNullOrWhiteSpace(fitnessGoal))
            {
                return 0; // No valid goal provided
            }

            fitnessGoal = fitnessGoal.ToLower();

            if (targetWeight != startingWeight)
            {
                double weightDifference = Math.Abs(targetWeight - startingWeight);
                double progress = Math.Abs(currentWeight - startingWeight);

                // Check if progress should be calculated
                bool isValidRange =
                    (fitnessGoal == "muscle gain" && currentWeight >= startingWeight) ||
                    (fitnessGoal == "fat loss" && currentWeight <= startingWeight);

                if (isValidRange)
                {
                    weightProgressPercentage = (progress / weightDifference) * 100;

                    // **New Logic: Handle Overachievement**
                    if ((fitnessGoal == "muscle gain" && currentWeight > targetWeight) ||
                        (fitnessGoal == "fat loss" && currentWeight < targetWeight))
                    {
                        weightProgressPercentage = 100; // Cap at 100%
                        // OR: Allow overachievement: weightProgressPercentage = (progress / weightDifference) * 110;
                    }
                }
            }

            return Math.Min(100, weightProgressPercentage); // Ensure max is 100%
        }




        //For motivational quotes
        private static string[] quotes = {
                "Believe in yourself!",
                "You are stronger than you think!",
                "Every day is a second chance.",
                "Hard work pays off!",
                "Success is a journey, not a destination.",
                "Dream big.",
                "Stay positive.",
                "Make it happen.",
                "New beginnings.",
                "Keep going.",
                "Your only limit is your mind.",
                "Push yourself.",
                "Go out and get it.",
                "Feel the achievement.",
                "Don't stop.",
                "Thank yourself later.",
                "Little things matter.",
                "Hard does not mean impossible.",
                "Create opportunity.",
                "Discover your strengths.",
                "Focus on goals.",
                "Believe you can.",
                "Wake up determined.",
                "Tomorrow never comes!",
                "Love what you do.",
                "Don't limit your challenges",
                "Challenge your limits!",
               "Sweat, sacrifice, and success.",
                "Train insane or remain the same.",
                "No excuses, just results.",
                "Winners never quit, and quitters never win."
        };


        private static int currentQuoteIndex = 0;
        private static int currentCharIndex = 0;
        private static bool isTypingForward = true;
        private static int pauseCounter = 0;
        private static int pauseDuration = 13; // Adjust pause duration as needed

        public static void GetQoutes(Label lblQuote)
        {
            if (isTypingForward)
            {
                if (currentCharIndex < quotes[currentQuoteIndex].Length)
                {
                    lblQuote.Text += quotes[currentQuoteIndex][currentCharIndex];
                    currentCharIndex++;
                }
                else
                {
                    pauseCounter++;
                    if (pauseCounter >= pauseDuration)
                    {
                        isTypingForward = false;
                        pauseCounter = 0;
                        currentCharIndex--;
                    }
                }
            }
            else
            {
                if (currentCharIndex >= 0)
                {
                    lblQuote.Text = lblQuote.Text.Substring(0, currentCharIndex);
                    currentCharIndex--;
                }
                else
                {
                    isTypingForward = true;
                    currentCharIndex = 0;
                    currentQuoteIndex = (currentQuoteIndex + 1) % quotes.Length;
                    lblQuote.Text = string.Empty; // Clear the label for the next quote
                }
            }
        }




        //challenges..
        private static string[] challenges =
        {
            // Existing challenges
            "Do a 15-minute stretching routine.",
            "Do 10 Pull-ups.",
            "Do 20 Push-ups.",
            "Do 15 squats.",
            "Do a dynamic warm-up before your workout.",
            "Stretch your Whole body for 5 minutes.",
            "Drink a glass of water before each meal.",
            "Replace one sugary drink with water.",
            "Carry a water bottle with you all day.",
            "Drink a glass of water first thing in the morning.",
            "Set a timer to remind you to drink water every hour.",
            "Write in a journal for 10 minutes. for mental Health!",
            "Practice deep breathing exercises.",
            "Spend 15 minutes in nature.",
            "Read a chapter of a book.",
            "Disconnect from screens for an hour.",
            "Eat 5 servings of fruits and vegetables.",
            "Try a new smoothie recipe.",
            "Avoid junk foods for a day.",
            "Prepare a healthy meal from scratch.",
            "Track your calorie intake.",
            "Complete a 5Km run.",
            "Do a 30-minute HIIT workout.",
            "Perform 50 sit-ups.",
            "Hold a plank for 2 minutes.",

            "Do 50 jumping jacks.",
            "Take a 30-minute brisk walk.",
            "Do a 10-minute meditation session.",
            "Try a new yoga pose.",
            "Do 3 sets of 10 lunges.",
            "Run up and down the stairs for 5 minutes.",
            "Do 20 burpees.",
            "Try a new healthy recipe.",
            "Do a 5-minute cool-down after your workout.",
            "Take a 10-minute power nap.",
            "Do 3 sets of 15 tricep dips.",
            "Spend 10 minutes practicing mindfulness.",
            "Do 3 sets of 20 calf raises.",
            "Try a new fruit or vegetable.",
            "Do a 10-minute core workout.",
            "Spend 10 minutes stretching your hamstrings.",
            "Do 3 sets of 10 bicep curls.",
            "Take a 15-minute walk after dinner.",
            "Do 3 sets of 15 shoulder presses.",
            "Spend 10 minutes practicing gratitude.",
            "Do a 10-minute cardio workout.",
            "Try a new fitness app or workout video.",
            "Do 3 sets of 20 leg raises.",
            "Spend 10 minutes stretching your back.",
            "Do 3 sets of 15 chest presses."
        };

        private static Random random = new Random();
        private static int index;

        public static void GetChallenges(Label lblChallenge)
        {
            index = random.Next(challenges.Length);
            lblChallenge.Text = challenges[index];
        }



        //Helper method for btnAddWater_Click

        public static void SetWaterIntake(Label lblWaterIntake, ProgressBar progressBarWater)
        {
            if (UserDataManager.CurrentUser != null)
            {
                // Add one glass
                if (UserDataManager.CurrentUser.DailyWaterIntake < 8) // Ensure limit is not exceeded
                {
                    UserDataManager.CurrentUser.DailyWaterIntake++;

                    UserDataManager.UpdateDailyWaterIntake();
                    //refresh
                    lblWaterIntake.Text = $"{UserDataManager.CurrentUser.DailyWaterIntake} / 8 Glasses";
                    progressBarWater.Value = (int)((UserDataManager.CurrentUser.DailyWaterIntake / 8.0) * 100);

                }
                else
                {
                    MessageBox.Show("You have already reached your daily goal of 8 glasses.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //tooltip for progressBarWeight
        public static void ToolTipProgBarWeight(ToolTip toolTip, ProgressBar progressBarWeight)
        {
            if (UserDataManager.CurrentUser != null)
            {
                toolTip.SetToolTip(progressBarWeight, $"Current Weight: {UserDataManager.CurrentUser.CurrentWeight} kg\nTarget Weight: {UserDataManager.CurrentUser.TargetWeight} kg");
            }
            else
            {
                toolTip.SetToolTip(progressBarWeight, $"Login to view your progress!");
            }
        }


        //tooltip for progressBarWater
        public static void ToolTipProgBarWater(ToolTip toolTip, ProgressBar progressBarWater)
        {
            if (UserDataManager.CurrentUser != null)
            {
                toolTip.SetToolTip(progressBarWater, $"Current Intake: {UserDataManager.CurrentUser.DailyWaterIntake} glass\nTarget Intake: 8 glass");
            }
            else
            {
                toolTip.SetToolTip(progressBarWater, $"Login to view your progress!");
            }
        }





    }
}
