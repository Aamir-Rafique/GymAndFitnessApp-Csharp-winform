using GymAndFitness.Forms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class DashboardForm : BaseForm
    {
        private static DashboardForm instance;
        private DashboardForm()
        {
            InitializeComponent();
        }
        public static DashboardForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DashboardForm();
            }
            return instance;
        }

        //method to refresh premium features. in the forms.. after it is changed in profile form...
        public void RefreshPremiumFeaturesDashboardForm()
        {
            pbMembershipStatus.Image = Features.MembershipStatusPic();
            PremiumFeatureDashboardForm();
            //ProgressBarWeight();
        }

        //helper method for refreshing profile picture...
        public void RefreshProfilePictureInForms()
        {
            UserDataManager.ApplyProfilePicture(pbProfilePicture);
        }

        public void ProgressBarWeight()
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

        //LOAD
        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await DasboardFormLoadEvents();

            //old logic..

            ////clock
            //timerTime.Start();
            ////quote
            //timerQuote.Start(); // Start the timer
            ////date
            //lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");


            ////  accessing current user 
            //if (UserDataManager.CurrentUser != null)
            //{

            //    UserDataManager.ApplyProfilePicture(btnProfilePicture);

            //    //load membership plan pics
            //    pbMembershipStatus.Image = Features.MembershipStatusPic();

            //    //
            //    btnLogout.Visible = true;
            //    btnLogout.Enabled = true;
            //    btnLogin.Visible = false;
            //    btnLogin.Enabled = false;

            //    // Weight Progress

            //    // Get user data
            //    double startingWeight = UserDataManager.CurrentUser.StartingWeight;
            //    double currentWeight = UserDataManager.CurrentUser.CurrentWeight;
            //    double targetWeight = UserDataManager.CurrentUser.TargetWeight;

            //    double weightProgressPercentage = 0;
            //    string fitnessGoal = UserDataManager.CurrentUser.FitnessGoal?.ToLower(); // Handle potential null values

            //    // Validate target and starting weights to avoid division by zero
            //    if (targetWeight != startingWeight)
            //    {
            //        double weightDifference = Math.Abs(targetWeight - startingWeight);
            //        bool isValidRange =
            //            (fitnessGoal == "muscle gain" && currentWeight >= startingWeight && currentWeight <= targetWeight) ||
            //            (fitnessGoal == "fat loss" && currentWeight <= startingWeight && currentWeight >= targetWeight);

            //        if (isValidRange)
            //        {
            //            double progress = Math.Abs(currentWeight - startingWeight);
            //            weightProgressPercentage = (progress / weightDifference) * 100;
            //        }
            //    }

            //    weightProgressPercentage = Math.Min(100, Math.Max(0, weightProgressPercentage));


            //    // Update progress bar and label
            //    progressBarWeight.Value = (int)weightProgressPercentage;
            //    lblWeightProgess.Text = $"Weight Progress: {Math.Round(weightProgressPercentage)}% ({currentWeight} kg out of {targetWeight} kg)";


            //    // Water Intake Progress
            //    lblWaterIntake.Text = $"{UserDataManager.CurrentUser.DailyWaterIntake} / 8 Glasses";
            //    progressBarWater.Value = (int)((UserDataManager.CurrentUser.DailyWaterIntake / 8.0) * 100);

            //    //lblWaterIntake.Text = $"{waterProgressPercentage}%";

            //    Console.WriteLine($"Height: {UserDataManager.CurrentUser.Height}");
            //    Console.WriteLine($"Weight: {UserDataManager.CurrentUser.CurrentWeight}");
            //    Console.WriteLine($"Progress Percentage: {weightProgressPercentage}");


            //    //disabling water tracker feature for free members... 
            //    if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
            //    {
            //        lblPremiumMembers.Text = "For Premium Members Only!";
            //        pnlWaterIntake.BackColor = Color.Gainsboro;
            //        pnlWaterIntake.ForeColor = Color.Gray;
            //        btnAddWater.BackColor = Color.Gainsboro;
            //        btnAddWater.Enabled = false;
            //        lblWaterIntake.ForeColor = Color.Gray;
            //        lblGlasses.ForeColor = Color.Gray;
            //        progressBarWater.Enabled = false;
            //        progressBarWater.Value = 0;
            //        toolTip.SetToolTip(pnlWaterIntake, $"Upgrade to Premium to access this feature!");
            //        toolTip.SetToolTip(pbwaterintake, $"Upgrade to Premium to access this feature!");
            //        pnlWaterIntake.Cursor = Cursors.Hand;
            //    }

            //}

            //else
            //{
            //    btnLogout.Visible = false;
            //    btnLogout.Enabled = false;
            //    btnLogin.Visible = true;
            //    btnLogin.Enabled = true;

            //    //initializing progressbar values.. for user interaction when no login..
            //    progressBarWater.Value = 15;
            //    progressBarWeight.Value = 26;
            //    lblWeightProgess.Text = "Login to view your progress..";
            //}

        }


        private async Task DasboardFormLoadEvents()
        {
            // Start timers
            timerTime.Start();
            timerQuote.Start();

            // Set the current date
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            // Accessing current user
            if (UserDataManager.CurrentUser != null)
            {
                // Apply profile picture asynchronously
                await Task.Run(() => UserDataManager.ApplyProfilePicture(pbProfilePicture));

                // Load membership plan pictures asynchronously
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());

                // Update buttons based on user status
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                //weight progress method..
                ProgressBarWeight();

                // Water Intake Progress
                lblWaterIntake.Text = $"{UserDataManager.CurrentUser.DailyWaterIntake} / 8 Glasses";
                progressBarWater.Value = (int)((UserDataManager.CurrentUser.DailyWaterIntake / 8.0) * 100);
                if (progressBarWater.Value == 100)
                {
                    lblWaterIntake.Text = "Great!";
                }

                PremiumFeatureDashboardForm();
            }
            else
            {
                // Handle case where no user is logged in
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


        // Helper Method for Weight Progress Calculation
        private double CalculateWeightProgress(double startingWeight, double currentWeight, double targetWeight, string fitnessGoal)
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



        // Helper Method to Disable Water Tracker Features
        private void PremiumFeatureDashboardForm()
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

        public async void ReloadDashboardFormData()
        {
            await DasboardFormLoadEvents();
        }

        //code for clock
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        //For motivational quotes
        private string[] quotes = {
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


        private int currentQuoteIndex = 0;
        private int currentCharIndex = 0;
        private bool isTypingForward = true;
        private int pauseCounter = 0;
        private int pauseDuration = 13; // Adjust pause duration as needed


        private void timer2_Tick(object sender, EventArgs e)
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


        //Progress bar(water intake)
        private void btnCompleteWorkout_Click_1(object sender, EventArgs e)
        {
            UpdateProgress();
        }
        private void UpdateProgress()
        {
            // Example: Increment progress by 13
            progressBarWater.Value = Math.Min(progressBarWater.Value + 13, progressBarWater.Maximum);
        }






        //challenges..
        private string[] challenges =
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




        private Random random = new Random();
        private int index;
        private void btnChallenge_Click_1(object sender, EventArgs e)
        {
            index = random.Next(challenges.Length);
            lblChallenge.Text = challenges[index];
        }


        private void btnAddWater_Click(object sender, EventArgs e)
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

                    //    // Ensure the progress bar is full
                    //    lblWaterIntake.Text = "8 / 8 Glasses";
                    //    progressBarWater.Value = 100;
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void progressBarWeight_MouseEnter(object sender, EventArgs e)
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to LOGOUT?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Features.LogoutNow();
            }
        }

        private void progressBarWater_MouseEnter(object sender, EventArgs e)
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



        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }


        private void pbProfilePicture_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }

        private void pbProfilePicture_MouseEnter(object sender, EventArgs e)
        {
            Features.TooltipProfilePic(toolTip, pbProfilePicture);

        }
    }
}
