using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym___Fitness_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }




        //for slide panel
        private bool isPanelCollapsed = true; // Track panel state
        private int panelWidth; // Store the panel's default width


        //slide  panel timer 
        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelCollapsed)
            {
                slidePanel.Width +=7; // Expand the panel
                if (slidePanel.Width >= panelWidth)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = false; // Panel is now expanded
                }
            }
            else
            {
                slidePanel.Width -=7; // Collapse the panel
                if (slidePanel.Width <= 45)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = true; // Panel is now collapsed
                }
            }
        }



        //form1 i.e. main
        private void Form1_Load(object sender, EventArgs e)
        {
            //backgroundimages


            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed

            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {

                UserDataManager.ApplyProfilePicture(btnProfilePicture);

                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;
            }
            else
            {
                MessageBox.Show("No user is logged in.");

                btnLogout.Visible = false;
                btnLogout.Enabled = false;
                btnLogin.Visible = true;
                btnLogin.Enabled = true;

            }

        }

        private void btnToggle_Click_1(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
            slidePanel.BringToFront();  //to remove glitches while sliding

        }
        //slide panel ended..






        //dashboard form
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }



        //bmI fORM
        private void btnBMICalculator_Click(object sender, EventArgs e)
        {
            BMICalculatorForm bmiCalculator = new BMICalculatorForm();
            bmiCalculator.Show();
            this.Hide();
        }

        //dietplan form
        private void btnDietPlans_Click(object sender, EventArgs e)
        {
            DietPlansForm dietPlans = new DietPlansForm();
            dietPlans.Show();
            this.Hide();
        }


        //WorkoutPlan form
        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            WorkoutPlansForm workoutPlans = new WorkoutPlansForm();
            workoutPlans.Show();
            this.Hide();
        }

        //profile Form
        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
            this.Hide();
        }


        // About Form
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
            this.Hide();
        }


        //hovering message
        private void btnProfilePicture_MouseEnter(object sender, EventArgs e)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserDataManager.CurrentUser = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

       
    }
}
