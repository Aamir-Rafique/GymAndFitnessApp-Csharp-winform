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
            this.Dock = DockStyle.Left; // Fix ribbon at the top
        }


        private bool isPanelCollapsed = true; // Track panel state
        private int expandedWidth = 209; // Default expanded width
        private int collapsedWidth = 45; // Default collapsed width
        private int slideSpeed = 7; // Speed of animation (higher = faster)

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

        //method to collapse the slide panel everytime the form is switched..
        public void CollapsePanel()
        {
            if (!isPanelCollapsed)
            {
                slideTimer.Start(); // Collapse the panel automatically
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != MainForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }

            CollapsePanel();
            Features.OpenMainForm();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != DashboardForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }
            CollapsePanel();
            Features.OpenDashboardForm();
        }

        private void btnBMICalculator_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != BMICalculatorForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }
            CollapsePanel();
            Features.OpenBMICalculatorForm();
        }

        private void btnDietPlans_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != DietPlansForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }
            CollapsePanel();
            Features.OpenDietPlansForm();
        }

        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != WorkoutPlansForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }
            CollapsePanel();
            Features.OpenWorkoutPlansForm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != ProfileForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }
            CollapsePanel();
            Features.OpenProfileForm();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm(); // Get the parent form containing this panel
            if (currentForm != null && currentForm != AboutForm.GetInstance())
            {
                currentForm.Hide(); // Hide the current form
            }
            CollapsePanel();
            Features.OpenAboutForm();
        }

    }
}
