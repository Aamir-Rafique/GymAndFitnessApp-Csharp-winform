using System;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MembershipForm : Form
    {
        public MembershipForm()
        {
            InitializeComponent();
        }


        private static string connectionString = ConfigurationManager.ConnectionStrings["GymFitnessAppDbConnection"].ConnectionString;

        private void btnFreePlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                UserDataManager.CurrentUser.MembershipStatus = "Free";
                UpdateMembershipInDatabase("Free");
                MessageBox.Show("Membership updated to Free!", "Success");
                this.Close();
                ProfileForm profile = new ProfileForm();
                profile.Show();
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

        private void btnPremiumPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                ProfileForm profile = new ProfileForm();
                profile.Close();
                if (UserDataManager.CurrentUser.MembershipStatus == "Premium")
                {
                    MessageBox.Show("You are already a Premium member!");
                    
                }
                else
                {
                    PremiumForm premiumForm = new PremiumForm();
                    premiumForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }



        // Helper function to update membership in the database
        private void UpdateMembershipInDatabase(string status)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Users SET MembershipStatus = @MembershipStatus WHERE Username = @Username";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MembershipStatus", status);
                    command.Parameters.AddWithValue("@Username", UserDataManager.CurrentUser.Username);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }




        }









    }
}