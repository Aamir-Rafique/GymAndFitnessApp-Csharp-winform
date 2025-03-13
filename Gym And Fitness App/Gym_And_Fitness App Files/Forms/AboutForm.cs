using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }


        UserDataManager userDataManager = new UserDataManager();  //Instance of the class: (UserDataManager)



        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblPurpose.Text = "The Gym && Fitness App is designed to help users achieve their fitness goals by providing personalized workout plans, nutritional guidance, and progress tracking. Whether you're looking to build muscle, lose weight, or improve overall fitness, this app offers a comprehensive solution to support your journey. Our mission is to make fitness accessible, convenient, and enjoyable for everyone. Stay fit, stay healthy!";

            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed



            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(btnProfilePicture);
            }


            // Assign the version to the label
            lblVersion.Text =Features.GetCurrentVersion();
        }

        //for slide panel
        private bool isPanelCollapsed = true; // Track panel state
        private int panelWidth; // Store the panel's default width


        //slide  panel timer 
        private void slideTimer_Tick_1(object sender, EventArgs e)
        {
            if (isPanelCollapsed)
            {
                //pnlMain.BackColor = Color.LimeGreen; //change the color of main panel
                slidePanel.Width += 7; // Expand the panel
                if (slidePanel.Width >= panelWidth)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = false; // Panel is now expanded
                }
            }
            else
            {
                //pnlMain.BackColor = Color.LightGreen; //change the color of main panel
                slidePanel.Width -= 7; // Collapse the panel
                if (slidePanel.Width <= 45)
                {
                    slideTimer.Stop();
                    isPanelCollapsed = true; // Panel is now collapsed
                }
            }
        }


        //menu
        private void btnToggle_Click_1(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
            slidePanel.BringToFront();  //to remove glitches while sliding
        }



        //YOutube
        private void pbGmail_Click(object sender, EventArgs e)
        {
            // The URL to open when the PictureBox is clicked
            string url = "https://www.example.com";
            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //facebook
        private void pbFacebook_Click(object sender, EventArgs e)
        {
            // The URL to open when the PictureBox is clicked
            string url = "https://www.example.com";

            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //linkedin
        private void pbLinkedin_Click(object sender, EventArgs e)
        {
            // The URL to open when the PictureBox is clicked
            string url = "https://www.linkedin.com/in/aamir-rafique-7a5bb1336/";

            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //twitter
        private void pbTwitter_Click(object sender, EventArgs e)
        {
            // The URL to open when the PictureBox is clicked
            string url = "https://www.example.com";

            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //github
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // The URL to open when the PictureBox is clicked
            string url = "https://github.com/Aamir-Rafique";

            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //for opening each form...
        private void btnProfilePicture_Click_1(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Features.OpenMainForm();
            this.Hide();
        }

        private void btnBMICalculator_Click_1(object sender, EventArgs e)
        {
            Features.OpenBMICalculatorForm();
            this.Hide();
        }

        private void btnDietPlans_Click_1(object sender, EventArgs e)
        {
            Features.OpenDietPlansForm();
            this.Hide();
        }
        private void btnWorkoutPlans_Click_1(object sender, EventArgs e)
        {
            Features.OpenWorkoutPlansForm();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnProfilePicture, "Profile");
        }



        private void btnProfilePicture_MouseEnter_1(object sender, EventArgs e)
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }
    }
}
