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

        //method to update profile picture in the forms.. after it is changed in profile form...
        public void RefreshMainFormElements()
        {
            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.ApplyProfilePicture(btnProfilePicture);
                pbMembershipStatus.Image = Features.MembershipStatusPic();
            }
        }
        //form1 i.e. main
        private void Form1_Load(object sender, EventArgs e)
        {
            MainFormLoadEvents();

            //old logic..
            ////  accessing current user 
            //if (UserDataManager.CurrentUser != null)
            //{
            //    UserDataManager.ApplyProfilePicture(btnProfilePicture);
            //    btnLogout.Visible = true;
            //    btnLogout.Enabled = true;
            //    btnLogin.Visible = false;
            //    btnLogin.Enabled = false;

            //    //load membership plan pics
            //    pbMembershipStatus.Image = Features.MembershipStatusPic();
            //}
            //else
            //{
            //    MessageBox.Show("No user is logged in.");
            //    btnLogout.Visible = false;
            //    btnLogout.Enabled = false;
            //    btnLogin.Visible = true;
            //    btnLogin.Enabled = true;
            //}
        }

        private void MainFormLoadEvents()
        {
            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.ApplyProfilePicture(btnProfilePicture);
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                btnLogin.Visible = false;
                btnLogin.Enabled = false;

                //load membership plan pics
                pbMembershipStatus.Image = Features.MembershipStatusPic();
            }
            else
            {
                btnLogout.Visible = false;
                btnLogout.Enabled = false;
                btnLogin.Visible = true;
                btnLogin.Enabled = true;

                MessageBox.Show("No user is logged in.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ReloadMainFormData()
        {
            MainFormLoadEvents();
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
            DialogResult result = MessageBox.Show("Are you sure you want to LOGOUT?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Features.LogoutNow();
            }
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
