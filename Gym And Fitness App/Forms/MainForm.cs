using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)


        //for slide panel
        private bool isPanelCollapsed = true; // Track panel state
        private int panelWidth; // Store the panel's default width


        //slide  panel timer 
        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelCollapsed)
            {
                slidePanel.Width += 7; // Expand the panel
                if (slidePanel.Width >= panelWidth)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = false; // Panel is now expanded
                }
            }
            else
            {
                slidePanel.Width -= 7; // Collapse the panel
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
                userDataManager.ApplyProfilePicture(btnProfilePicture);
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


        //to open each form..
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }

        private void btnBMICalculator_Click(object sender, EventArgs e)
        {
            Features.OpenBMICalculatorForm();
            this.Hide();
        }

        private void btnDietPlans_Click(object sender, EventArgs e)
        {
            Features.OpenDietPlansForm();
            this.Hide();
        }
        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            Features.OpenWorkoutPlansForm();
            this.Hide();
        }
        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Features.OpenAboutForm();
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
            Features.OpenLoginForm();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Close();
        }





    }
}
