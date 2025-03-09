namespace GymAndFitness
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnDietPlans = new System.Windows.Forms.Button();
            this.btnBMICalculator = new System.Windows.Forms.Button();
            this.btnWorkoutPlans = new System.Windows.Forms.Button();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfilePicture = new GymAndFitness.Classes.RoundPictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.slidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 5;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
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
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::GymAndFitness.Properties.Resources.dashboardfinal;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-1, 104);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(209, 51);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
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
            this.btnDietPlans.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDietPlans.Image = global::GymAndFitness.Properties.Resources.diet;
            this.btnDietPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDietPlans.Location = new System.Drawing.Point(-1, 204);
            this.btnDietPlans.Name = "btnDietPlans";
            this.btnDietPlans.Size = new System.Drawing.Size(209, 51);
            this.btnDietPlans.TabIndex = 4;
            this.btnDietPlans.Text = "Diet Plans";
            this.btnDietPlans.UseVisualStyleBackColor = false;
            this.btnDietPlans.Click += new System.EventHandler(this.btnDietPlans_Click);
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
            this.btnBMICalculator.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMICalculator.Image = global::GymAndFitness.Properties.Resources.bmi;
            this.btnBMICalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBMICalculator.Location = new System.Drawing.Point(-1, 154);
            this.btnBMICalculator.Name = "btnBMICalculator";
            this.btnBMICalculator.Size = new System.Drawing.Size(209, 51);
            this.btnBMICalculator.TabIndex = 3;
            this.btnBMICalculator.Text = "BMI Calculator";
            this.btnBMICalculator.UseVisualStyleBackColor = false;
            this.btnBMICalculator.Click += new System.EventHandler(this.btnBMICalculator_Click);
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
            this.btnWorkoutPlans.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkoutPlans.Image = global::GymAndFitness.Properties.Resources.workout;
            this.btnWorkoutPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkoutPlans.Location = new System.Drawing.Point(-1, 254);
            this.btnWorkoutPlans.Name = "btnWorkoutPlans";
            this.btnWorkoutPlans.Size = new System.Drawing.Size(209, 51);
            this.btnWorkoutPlans.TabIndex = 5;
            this.btnWorkoutPlans.Text = "Workout Plans";
            this.btnWorkoutPlans.UseVisualStyleBackColor = false;
            this.btnWorkoutPlans.Click += new System.EventHandler(this.btnWorkoutPlans_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.slidePanel.Controls.Add(this.btnProfile);
            this.slidePanel.Controls.Add(this.btnAbout);
            this.slidePanel.Controls.Add(this.btnToggle);
            this.slidePanel.Controls.Add(this.btnWorkoutPlans);
            this.slidePanel.Controls.Add(this.btnBMICalculator);
            this.slidePanel.Controls.Add(this.btnDietPlans);
            this.slidePanel.Controls.Add(this.btnDashboard);
            this.slidePanel.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidePanel.Location = new System.Drawing.Point(0, 74);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(200, 486);
            this.slidePanel.TabIndex = 0;
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
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = global::GymAndFitness.Properties.Resources.userdfa;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-1, 304);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 51);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = global::GymAndFitness.Properties.Resources.info;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-2, 354);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(210, 51);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Lime;
            this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Rockwell", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Image = global::GymAndFitness.Properties.Resources.menu_bar;
            this.btnToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.Location = new System.Drawing.Point(-1, 12);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(209, 51);
            this.btnToggle.TabIndex = 1;
            this.btnToggle.Text = "Menu";
            this.toolTip1.SetToolTip(this.btnToggle, "Menu");
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnProfilePicture);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 74);
            this.panel1.TabIndex = 1;
            // 
            // btnProfilePicture
            // 
            this.btnProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnProfilePicture.BorderColor = System.Drawing.Color.Lime;
            this.btnProfilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnProfilePicture.BorderSize = 2;
            this.btnProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilePicture.GradientAngle = 50F;
            this.btnProfilePicture.Image = global::GymAndFitness.Properties.Resources.usernew;
            this.btnProfilePicture.Location = new System.Drawing.Point(712, 10);
            this.btnProfilePicture.Name = "btnProfilePicture";
            this.btnProfilePicture.Size = new System.Drawing.Size(58, 58);
            this.btnProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProfilePicture.TabIndex = 40;
            this.btnProfilePicture.TabStop = false;
            this.btnProfilePicture.Click += new System.EventHandler(this.btnProfilePicture_Click);
            this.btnProfilePicture.MouseEnter += new System.EventHandler(this.btnProfilePicture_MouseEnter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::GymAndFitness.Properties.Resources.enter7;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(578, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 37);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnLogin, "Click to Login to your account");
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gym && Fitness App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GymAndFitness.Properties.Resources.Gym___FItness_logo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::GymAndFitness.Properties.Resources.power_button;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(578, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 37);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnLogout, "You will need to login again!");
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12.11881F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(244, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Your Fitness Journey Begins Here!";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::GymAndFitness.Properties.Resources.freepik__candid_image_photography_natural_textures_highly_r__68961;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.slidePanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(804, 604);
            this.MinimumSize = new System.Drawing.Size(804, 604);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.slidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer slideTimer;
        public System.Windows.Forms.Button btnDashboard;
        public System.Windows.Forms.Button btnDietPlans;
        public System.Windows.Forms.Button btnBMICalculator;
        public System.Windows.Forms.Button btnWorkoutPlans;
        public System.Windows.Forms.Panel slidePanel;
        public System.Windows.Forms.Button btnToggle;
        public System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private Classes.RoundPictureBox btnProfilePicture;
        public System.Windows.Forms.Button btnProfile;
    }
}

