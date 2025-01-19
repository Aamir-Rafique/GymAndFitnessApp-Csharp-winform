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
        private const int initiazlize_app = 1000;
        private const int LOAD_RESOURCES_TIME = 2000;
        private const int CONNECT_DB_TIME = 3000;
        private const int FINALIZE_TIME = 3800;
        private const int ALMOST_THERE_TIME = 5000;
        private const int COMPLETE_TIME = 6000;

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            elapsedTime += timerLoading.Interval;

            // Update progress bar and label based on elapsed time
            switch (elapsedTime)
            {
                case initiazlize_app:
                    lblLoading.Text = "Initializing application...";
                    progressBarLoading.Value = 20;

                    break;

                case LOAD_RESOURCES_TIME:
                    lblLoading.Text = "Loading resources...";
                    progressBarLoading.Value = 35;
                    break;

                case CONNECT_DB_TIME:
                    lblLoading.Text = "Connecting to database...";
                    progressBarLoading.Value = 50;
                    break;

                case FINALIZE_TIME:
                    lblLoading.Text = "Finalizing...";
                    break;

                case ALMOST_THERE_TIME:
                    lblLoading.Text = "Almost there...";
                    progressBarLoading.Value = 70;
                    break;

                case COMPLETE_TIME:
                    lblLoading.Text = "";
                    lblWelcome.Text = "Welcome";
                    progressBarLoading.Value = 100;
                    break;

                default:
                    if (elapsedTime >= COMPLETE_TIME + 600)
                    {
                        // Open LoginForm and close LoadingForm
                        timerLoading.Stop();

                        this.Hide();

                        LoginForm login = new LoginForm();
                        login.Show();

                        //this.Close();
                    }
                    break;
            }
        }



    }
}
