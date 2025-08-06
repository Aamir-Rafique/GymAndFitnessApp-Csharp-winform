namespace GymAndFitness.Classes
{
    partial class SlidePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnWorkoutPlans = new System.Windows.Forms.Button();
            this.btnBMICalculator = new System.Windows.Forms.Button();
            this.btnDietPlans = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SpringGreen;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnProfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnProfile.Image = global::GymAndFitness.Properties.Resources.userdfa;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 379);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 51);
            this.btnProfile.TabIndex = 22;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnHome.Image = global::GymAndFitness.Properties.Resources.home_button;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 129);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 51);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnAbout.Image = global::GymAndFitness.Properties.Resources.info;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 429);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(210, 51);
            this.btnAbout.TabIndex = 21;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Image = global::GymAndFitness.Properties.Resources.menu_bar;
            this.btnToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.Location = new System.Drawing.Point(0, 23);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(211, 51);
            this.btnToggle.TabIndex = 1;
            this.btnToggle.Text = "Menu";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnWorkoutPlans
            // 
            this.btnWorkoutPlans.BackColor = System.Drawing.Color.SpringGreen;
            this.btnWorkoutPlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWorkoutPlans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkoutPlans.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnWorkoutPlans.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWorkoutPlans.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnWorkoutPlans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnWorkoutPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkoutPlans.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnWorkoutPlans.Image = global::GymAndFitness.Properties.Resources.workout;
            this.btnWorkoutPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkoutPlans.Location = new System.Drawing.Point(0, 329);
            this.btnWorkoutPlans.Name = "btnWorkoutPlans";
            this.btnWorkoutPlans.Size = new System.Drawing.Size(210, 51);
            this.btnWorkoutPlans.TabIndex = 20;
            this.btnWorkoutPlans.Text = "Workout Plans";
            this.btnWorkoutPlans.UseVisualStyleBackColor = false;
            this.btnWorkoutPlans.Click += new System.EventHandler(this.btnWorkoutPlans_Click);
            // 
            // btnBMICalculator
            // 
            this.btnBMICalculator.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBMICalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBMICalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMICalculator.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnBMICalculator.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBMICalculator.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnBMICalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBMICalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMICalculator.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnBMICalculator.Image = global::GymAndFitness.Properties.Resources.bmi;
            this.btnBMICalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBMICalculator.Location = new System.Drawing.Point(0, 229);
            this.btnBMICalculator.Name = "btnBMICalculator";
            this.btnBMICalculator.Size = new System.Drawing.Size(210, 51);
            this.btnBMICalculator.TabIndex = 18;
            this.btnBMICalculator.Text = "BMI Calculator";
            this.btnBMICalculator.UseVisualStyleBackColor = false;
            this.btnBMICalculator.Click += new System.EventHandler(this.btnBMICalculator_Click);
            // 
            // btnDietPlans
            // 
            this.btnDietPlans.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDietPlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDietPlans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDietPlans.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDietPlans.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDietPlans.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDietPlans.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDietPlans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDietPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDietPlans.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnDietPlans.Image = global::GymAndFitness.Properties.Resources.diet;
            this.btnDietPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDietPlans.Location = new System.Drawing.Point(0, 279);
            this.btnDietPlans.Name = "btnDietPlans";
            this.btnDietPlans.Size = new System.Drawing.Size(210, 51);
            this.btnDietPlans.TabIndex = 19;
            this.btnDietPlans.Text = "Diet Plans";
            this.btnDietPlans.UseVisualStyleBackColor = false;
            this.btnDietPlans.Click += new System.EventHandler(this.btnDietPlans_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 11.49307F);
            this.btnDashboard.Image = global::GymAndFitness.Properties.Resources.dashboardfinal;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 179);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 51);
            this.btnDashboard.TabIndex = 17;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 5;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // SlidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnWorkoutPlans);
            this.Controls.Add(this.btnBMICalculator);
            this.Controls.Add(this.btnDietPlans);
            this.Controls.Add(this.btnDashboard);
            this.DoubleBuffered = true;
            this.Name = "SlidePanel";
            this.Size = new System.Drawing.Size(210, 555);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnProfile;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnToggle;
        public System.Windows.Forms.Button btnWorkoutPlans;
        public System.Windows.Forms.Button btnBMICalculator;
        public System.Windows.Forms.Button btnDietPlans;
        public System.Windows.Forms.Button btnDashboard;
        public System.Windows.Forms.Timer slideTimer;
    }
}
