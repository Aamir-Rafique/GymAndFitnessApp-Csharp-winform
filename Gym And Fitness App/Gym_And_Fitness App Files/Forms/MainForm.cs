using GymAndFitness.Forms;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MainForm : BaseForm
    {
        private static MainForm instance;
        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainForm();
            }
            return instance;
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)

        //form1 i.e. main
        private void Form1_Load(object sender, EventArgs e)
        {
            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(btnProfilePicture);
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                //load membership plan pics
                pbMembershipStatus.Image = Features.MembershipStatusPic();
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
            Features.LogoutNow();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Features.OpenLoginForm();
            this.Close();
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
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
