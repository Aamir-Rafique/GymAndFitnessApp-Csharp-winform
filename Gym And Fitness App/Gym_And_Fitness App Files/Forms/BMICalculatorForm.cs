using System;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)



        //load
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            this.Focus();

            // Set placeholder for TextBox
            Features.SetTextBoxPlaceholder(txtHeight, "Your height in cm..");
            Features.SetTextBoxPlaceholder(txtWeight, "Your weight in kg..");

            //slide panel
            panelWidth = slidePanel.Width;
            slidePanel.Width = 45; // Start collapsed

            //loading behaviour of bmi scale/chart
            pbBMIChart.Image = Properties.Resources.bmiChartUnderW8;


            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(btnProfilePicture);
                //load membership plan pics
                pbMembershipStatus.Image = Features.MembershipStatusPic();

            }


        }
        //for slide panel
        private bool isPanelCollapsed = true; // Track panel state
        private int panelWidth; // Store the panel's default width


        //slide  panel timer 
        private void slideTimer_Tick(object sender, EventArgs e)
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







        //button event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                txtHeight.Focus(); //isi pr focus!
                error.SetError(this.txtHeight, "Please Enter your height");
            }
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                txtWeight.Focus(); //isi pr focus!
                error.SetError(this.txtWeight, "Please Enter your Weight");
            }
            else
            {
                double height = 0;
                try
                {
                    double weight = double.Parse(txtWeight.Text);
                    height = double.Parse(txtHeight.Text);
                    double bmi = Features.CalculateBMI(weight, height);
                    lblBMI.Text = $"{bmi:F2}";
                    lblBMI.ForeColor = Features.GetBMIColor(bmi);
                    lblBMICategory.ForeColor = Features.GetBMIColor(bmi);
                    lblBMICategory.Text = Features.GetBMICategory(bmi);
                    pbBMIChart.Image = Features.GetBMIChartUpdate(bmi);
                    lblTargetWeightRange.Text = Features.SuggestTargetWeightRange(height);
                }
                catch (FormatException ex) { MessageBox.Show("Please enter valid numeric values for height and weight: " + ex.Message); }
                catch (Exception ex) { MessageBox.Show("An error occurred while calculating BMI: " + ex.Message); }

            }
        }



        //menu
        private void btnToggle_Click(object sender, EventArgs e)
        {
            slideTimer.Start(); // Start the sliding animation
            slidePanel.BringToFront();  //to remove glitches while sliding
        }


        //to open each form..
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
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            Features.OpenAboutForm();
            this.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Features.OpenDashboardForm();
            this.Hide();
        }


        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 46)  //ASCII code 46, for period(.)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;   //if e.handled is true, it will not let anything to be typed!
            }
            else if (ch == 8)  //8 represents backspace , ASCII code 8, BS or Backspace
            {
                e.Handled = false;
            }
            else if (ch == 46)  //ASCII code 46, for period(.)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnCalculate.PerformClick(); // Trigger the button's click event
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
