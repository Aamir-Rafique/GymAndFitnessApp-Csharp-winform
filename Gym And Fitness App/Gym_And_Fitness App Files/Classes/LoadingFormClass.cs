using System;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    internal class LoadingFormClass
    {
        private static int elapsedTime = 0;

        // Constants for timing events
        private const int initializeAppTime = 1000;
        private const int loadResourcesTime = 2000;
        private const int ConnectDBTime = 3000;
        private const int FinalizeTime = 3800;
        private const int AlmostThereTime = 5000;
        private const int CompleteTime = 6000;

        public static void LoadingFormLoadEvents(Timer timerLoading, Label lblVersion)
        {
            timerLoading.Start();

            // Assign the version to the label
            lblVersion.Text = "Version: " + Features.GetCurrentVersion();
        }

        private static void UpdateProgressBarAndMessage(Label lblLoading, Label lblWelcome, ProgressBar progressBarLoading, Timer timerLoading)
        {
            // Update progress bar and label based on elapsed time
            if (elapsedTime < initializeAppTime)
            {
                lblLoading.Text = "Initializing application...";
                UpdateProgressBar(5, 15, progressBarLoading, timerLoading);

            }
            else if (elapsedTime < loadResourcesTime)
            {
                lblLoading.Text = "Loading resources...";
                UpdateProgressBar(25, 40, progressBarLoading, timerLoading);
            }
            else if (elapsedTime < ConnectDBTime)
            {
                lblLoading.Text = "Connecting to database...";
                UpdateProgressBar(45, 65, progressBarLoading, timerLoading);
            }
            else if (elapsedTime < FinalizeTime)
            {
                lblLoading.Text = "Finalizing setup...";
                UpdateProgressBar(70, 85, progressBarLoading, timerLoading);
            }
            else if (elapsedTime < AlmostThereTime)
            {
                lblLoading.Text = "Almost there...";
                UpdateProgressBar(90, 95, progressBarLoading, timerLoading);
            }
            else if (elapsedTime < CompleteTime)
            {
                lblLoading.Text = " ";
                lblWelcome.Text = "Welcome!";
                progressBarLoading.Value = 100;
            }
            else
            {
                lblLoading.Text = "";
                //lblWelcome.Text = "Welcome!";
                timerLoading.Stop();

                // **Preload forms using Singleton GetInstance() method**
                PreloadForms();

                // -----> HIDE/CLOSE THE LOADING FORM <-----
                // since this a static method, we'll need a reference to the LoadingForm instance
                var form = lblLoading.FindForm();
                if (form != null)
                {
                    form.Close();
                }

            }
        }


        private static void PreloadForms()
        {
            // GetInstance() ensures forms are created only if they are null or disposed
            LoginForm.GetInstance();

            AboutForm.GetInstance();
            BMICalculatorForm.GetInstance();
            DashboardForm.GetInstance();
            DietPlansForm.GetInstance();
            MainForm.GetInstance();
            ProfileForm.GetInstance();
            WorkoutPlansForm.GetInstance();
        }

        private static void UpdateProgressBar(int min, int max, ProgressBar progressBarLoading, Timer timerLoading)
        {
            int increment = (max - min) / (CompleteTime / timerLoading.Interval);
            progressBarLoading.Value = Math.Min(progressBarLoading.Value + increment, max);
        }

        public static void StartLoading(Label lblLoading, Label lblWelcome, ProgressBar progressBarLoading, Timer timerLoading)
        {
            elapsedTime += timerLoading.Interval;
            UpdateProgressBarAndMessage(lblLoading, lblWelcome, progressBarLoading, timerLoading);
        }

    }
}
