using System;
using System.Windows.Forms;

namespace GymAndFitness.Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private int elapsedTime = 0;

        // Constants for timing events
        private const int INITIALIZE_APP_TIME = 1000;
        private const int LOAD_RESOURCES_TIME = 2000;
        private const int CONNECT_DB_TIME = 3000;
        private const int FINALIZE_TIME = 3800;
        private const int ALMOST_THERE_TIME = 5000;
        private const int COMPLETE_TIME = 6000;

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timerLoading.Start();

            // Assign the version to the label
            lblVersion.Text = "Version: " + Features.GetCurrentVersion();
        }



        private void timerLoading_Tick(object sender, EventArgs e)
        {
            elapsedTime += timerLoading.Interval;
            UpdateProgressBarAndMessage();
        }

        private void UpdateProgressBarAndMessage()
        {
            // Update progress bar and label based on elapsed time
            if (elapsedTime < INITIALIZE_APP_TIME)
            {
                lblLoading.Text = "Initializing application...";
                UpdateProgressBar(5, 15);
            }
            else if (elapsedTime < LOAD_RESOURCES_TIME)
            {
                lblLoading.Text = "Loading resources...";
                UpdateProgressBar(25, 40);
            }
            else if (elapsedTime < CONNECT_DB_TIME)
            {
                lblLoading.Text = "Connecting to database...";
                UpdateProgressBar(45, 65);
            }
            else if (elapsedTime < FINALIZE_TIME)
            {
                lblLoading.Text = "Finalizing setup...";
                UpdateProgressBar(70, 85);
            }
            else if (elapsedTime < ALMOST_THERE_TIME)
            {
                lblLoading.Text = "Almost there...";
                UpdateProgressBar(90, 95);
            }
            else if (elapsedTime < COMPLETE_TIME)
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

                // Open LoginForm and close LoadingForm
                this.Hide();
                Features.OpenLoginForm();
            }
        }

        private void UpdateProgressBar(int min, int max)
        {
            int increment = (max - min) / (COMPLETE_TIME / timerLoading.Interval);
            progressBarLoading.Value = Math.Min(progressBarLoading.Value + increment, max);
        }

        private void LoadingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }
    }
}
