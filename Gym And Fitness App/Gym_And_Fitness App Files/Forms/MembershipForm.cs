using GymAndFitness.Classes;
using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class MembershipForm : Form
    {
        private MembershipForm()
        {
            InitializeComponent();
        }

        private static MembershipForm instance;
        public static MembershipForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MembershipForm();
            }
            return instance;
        }

        private void btnFreePlan_Click(object sender, EventArgs e)
        {
            MembershipFormClass.GetFreePlan();
        }

        private void btnPremiumPlan_Click(object sender, EventArgs e)
        {
            MembershipFormClass.GetPremiumPlan();
        }

        private void MembershipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Features.FormClosedEvent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Close();
        }
    }
}