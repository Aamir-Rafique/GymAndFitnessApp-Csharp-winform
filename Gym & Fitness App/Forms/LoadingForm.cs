using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym___Fitness_App.Forms
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
        private const int LOAD_RESOURCES_TIME = 2500;
        private const int CONNECT_DB_TIME = 3500;
        private const int FINALIZE_TIME = 5000;
        private const int ALMOST_THERE_TIME = 6500;
        private const int COMPLETE_TIME = 9600;

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
                    progressBarLoading.Value = 25;
                    lbl1Develop.Text = "Aamir Rafique";
                    break;

                case LOAD_RESOURCES_TIME:
                    lblLoading.Text = "Loading resources...";
                    lbl2Develop.Text = "Hamza Shahid";
                    progressBarLoading.Value = 45;
                    break;

                case CONNECT_DB_TIME:
                    lblLoading.Text = "Connecting to database...";
                    lbl3Develop.Text = "Raja Shadab";
                    progressBarLoading.Value = 60;
                    break;

                case FINALIZE_TIME:
                    lblLoading.Text = "Finalizing...";
                    progressBarLoading.Value = 75;
                    break;

                case ALMOST_THERE_TIME:
                    lblLoading.Text = "Almost there...";
                    progressBarLoading.Value = 83;
                    break;

                case COMPLETE_TIME:
                    lblLoading.Text ="";
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
