using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class PasswordVerification : Form
    {
        public PasswordVerification()
        {
            InitializeComponent();
        }




        private void PasswordVerification_Load(object sender, EventArgs e)
        {
            lblPassVerifyStatement.Text = $"Please Enter Password for your account named '{UserDataManager.CurrentUser.Username}':";
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errorPassword.SetError(txtPassword, "Please enter Password");
            }
            else
            {
                errorPassword.Clear();
            }

            //verifying password
            if (txtPassword.Text == UserDataManager.CurrentUser.Password)
            {
                MessageBox.Show("Correct Password");

            }
            else
            {
                MessageBox.Show("Invalid Password, Please enter a valid password!");
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorPassword.Clear();
        }




    }
}
