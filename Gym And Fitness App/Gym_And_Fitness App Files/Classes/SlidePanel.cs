using System;
using System.Windows.Forms;

namespace GymAndFitness.Classes
{
    public partial class SlidePanel : UserControl
    {
        public SlidePanel()
        {
            InitializeComponent();
            this.Width = collapsedWidth; // Start in collapsed state
            this.DoubleBuffered = true; // Prevent flickering
        }


        private bool isPanelCollapsed = true; // Track panel state
        private int expandedWidth = 209; // Default expanded width
        private int collapsedWidth = 45; // Default collapsed width
        private int slideSpeed =7; // Speed of animation (higher = faster)

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelCollapsed)
            {
                this.Width += slideSpeed; // Expand the panel
                if (this.Width >= expandedWidth)
                {
                    this.Width = expandedWidth;
                    slideTimer.Stop();
                    isPanelCollapsed = false; // Panel is now expanded
                }
            }
            else
            {
                this.Width -= slideSpeed; // Collapse the panel
                if (this.Width <= collapsedWidth)
                {
                    this.Width = collapsedWidth;
                    slideTimer.Stop();
                    isPanelCollapsed = true; // Panel is now collapsed
                }
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Features.OpenMainForm();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
        }

        private void btnBMICalculator_Click(object sender, EventArgs e)
        {
            Features.OpenBMICalculatorForm();
        }

        private void btnDietPlans_Click(object sender, EventArgs e)
        {
            Features.OpenDietPlansForm();
        }

        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            Features.OpenWorkoutPlansForm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Features.OpenAboutForm();
        }

    }
}
