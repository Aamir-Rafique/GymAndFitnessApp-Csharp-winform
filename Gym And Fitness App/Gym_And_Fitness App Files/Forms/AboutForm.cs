using GymAndFitness.Forms;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class AboutForm : BaseForm
    {
        private static AboutForm instance;

        private AboutForm()
        {
            InitializeComponent();
        }

        public static AboutForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AboutForm();
            }
            return instance;
        }

       

        private void AboutForm_Load(object sender, EventArgs e)
        {
            AboutFormLoadEvents();
        }
        public void ReloadAboutFormData()
        {
            AboutFormLoadEvents();
        }

        private async void AboutFormLoadEvents()
        {
            lblPurpose.Text = "The Gym && Fitness App is designed to help users achieve their fitness goals by providing personalized workout plans, nutritional guidance, and progress tracking. Whether you're looking to build muscle, lose weight, or improve overall fitness, this app offers a comprehensive solution to support your journey. Our mission is to make fitness accessible, convenient, and enjoyable for everyone. Stay fit, stay healthy!";

            // Assign the version to the label
            lblVersion.Text = Features.GetCurrentVersion();

            // Accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                // Load membership plan pics asynchronously
                await LoadMembershipPictureAsync();

                // Apply profile picture (assuming this method is lightweight)
                UserDataManager.ApplyProfilePicture(btnProfilePicture);
            }
        }

        // 🔹 Asynchronous method to load the membership status picture
        private async Task LoadMembershipPictureAsync()
        {
            try
            {
                // Simulate loading time (if fetching from DB/API)
                await Task.Delay(500);

                // Load image in a separate thread to avoid UI freeze
                pbMembershipStatus.Image = await Task.Run(() => Features.MembershipStatusPic());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load membership status image: " + ex.Message);
            }
        }



            //old logic (without async..)
        //private void AboutFormLoadEvents()
        //{
        //    lblPurpose.Text = "The Gym && Fitness App is designed to help users achieve their fitness goals by providing personalized workout plans, nutritional guidance, and progress tracking. Whether you're looking to build muscle, lose weight, or improve overall fitness, this app offers a comprehensive solution to support your journey. Our mission is to make fitness accessible, convenient, and enjoyable for everyone. Stay fit, stay healthy!";

        //    //  accessing current user 
        //    if (UserDataManager.CurrentUser != null)
        //    {
        //        //load membership plan pics
        //        pbMembershipStatus.Image = Features.MembershipStatusPic();
        //        UserDataManager.ApplyProfilePicture(btnProfilePicture);
        //    }


        //    // Assign the version to the label
        //    lblVersion.Text = Features.GetCurrentVersion();
        //}

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


        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }
    }
}
