namespace GymAndFitness
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlChallenge = new System.Windows.Forms.Panel();
            this.lblChallenge = new System.Windows.Forms.Label();
            this.lblwarning = new System.Windows.Forms.Label();
            this.btnChallenge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblWaterIntake = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarWater = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblWeightProgess = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.progressBarWeight = new System.Windows.Forms.ProgressBar();
            this.timerQuote = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.waterResetTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTipProgressWeight = new System.Windows.Forms.ToolTip(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnWorkoutPlans = new System.Windows.Forms.Button();
            this.btnBMICalculator = new System.Windows.Forms.Button();
            this.btnDietPlans = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.btnProfilePicture = new GymAndFitness.Classes.RoundPictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.slidePanel.SuspendLayout();
            this.pnlChallenge.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnProfilePicture);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gym && Fitness Dashboard";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGreen;
            this.pnlMain.Controls.Add(this.slidePanel);
            this.pnlMain.Controls.Add(this.pnlChallenge);
            this.pnlMain.Controls.Add(this.pictureBox3);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.lblClock);
            this.pnlMain.Controls.Add(this.lblQuote);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(834, 540);
            this.pnlMain.TabIndex = 1;
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.slidePanel.Controls.Add(this.btnHome);
            this.slidePanel.Controls.Add(this.btnAbout);
            this.slidePanel.Controls.Add(this.btnToggle);
            this.slidePanel.Controls.Add(this.btnWorkoutPlans);
            this.slidePanel.Controls.Add(this.btnBMICalculator);
            this.slidePanel.Controls.Add(this.btnDietPlans);
            this.slidePanel.Controls.Add(this.btnDashboard);
            this.slidePanel.Controls.Add(this.label11);
            this.slidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePanel.Location = new System.Drawing.Point(0, 0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(200, 540);
            this.slidePanel.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(-141, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Welcome to Gym && Fitness App!";
            // 
            // pnlChallenge
            // 
            this.pnlChallenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(80)))));
            this.pnlChallenge.Controls.Add(this.lblChallenge);
            this.pnlChallenge.Controls.Add(this.pictureBox4);
            this.pnlChallenge.Controls.Add(this.lblwarning);
            this.pnlChallenge.Controls.Add(this.btnChallenge);
            this.pnlChallenge.Controls.Add(this.label5);
            this.pnlChallenge.Controls.Add(this.label4);
            this.pnlChallenge.Location = new System.Drawing.Point(60, 270);
            this.pnlChallenge.Name = "pnlChallenge";
            this.pnlChallenge.Size = new System.Drawing.Size(500, 150);
            this.pnlChallenge.TabIndex = 13;
            // 
            // lblChallenge
            // 
            this.lblChallenge.AutoSize = true;
            this.lblChallenge.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallenge.ForeColor = System.Drawing.Color.Blue;
            this.lblChallenge.Location = new System.Drawing.Point(8, 70);
            this.lblChallenge.Name = "lblChallenge";
            this.lblChallenge.Size = new System.Drawing.Size(0, 20);
            this.lblChallenge.TabIndex = 18;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Rockwell", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(50, 101);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(124, 19);
            this.lblwarning.TabIndex = 16;
            this.lblwarning.Text = "Do if you can!!";
            // 
            // btnChallenge
            // 
            this.btnChallenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChallenge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChallenge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChallenge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnChallenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallenge.ForeColor = System.Drawing.Color.Black;
            this.btnChallenge.Location = new System.Drawing.Point(16, 29);
            this.btnChallenge.Name = "btnChallenge";
            this.btnChallenge.Size = new System.Drawing.Size(147, 28);
            this.btnChallenge.TabIndex = 1;
            this.btnChallenge.Text = "Get your Challenge";
            this.toolTip1.SetToolTip(this.btnChallenge, "Task");
            this.btnChallenge.UseVisualStyleBackColor = false;
            this.btnChallenge.Click += new System.EventHandler(this.btnChallenge_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Not For Loosers!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHALLENGE SECTION";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(624, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 9;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(632, 46);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 21);
            this.lblClock.TabIndex = 4;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuote.Font = new System.Drawing.Font("Rockwell", 22.09901F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblQuote.Location = new System.Drawing.Point(197, 144);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(0, 38);
            this.lblQuote.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(157, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to Gym && Fitness App!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblWaterIntake);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAddWater);
            this.panel2.Controls.Add(this.progressBarWater);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(568, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 262);
            this.panel2.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(100, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "8 Glass";
            // 
            // lblWaterIntake
            // 
            this.lblWaterIntake.AutoSize = true;
            this.lblWaterIntake.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterIntake.ForeColor = System.Drawing.Color.Blue;
            this.lblWaterIntake.Location = new System.Drawing.Point(75, 104);
            this.lblWaterIntake.Name = "lblWaterIntake";
            this.lblWaterIntake.Size = new System.Drawing.Size(0, 20);
            this.lblWaterIntake.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Progress:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.3802F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(2, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Target Intake: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Intake";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "* It is recommended to drink 8 glass of water daily!";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Daily Water Intake";
            // 
            // progressBarWater
            // 
            this.progressBarWater.Location = new System.Drawing.Point(5, 127);
            this.progressBarWater.Name = "progressBarWater";
            this.progressBarWater.Size = new System.Drawing.Size(233, 42);
            this.progressBarWater.TabIndex = 1;
            this.toolTip1.SetToolTip(this.progressBarWater, "Water Intake");
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(80)))));
            this.panel6.Controls.Add(this.lblWeightProgess);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.progressBarWeight);
            this.panel6.Location = new System.Drawing.Point(62, 434);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(498, 101);
            this.panel6.TabIndex = 15;
            // 
            // lblWeightProgess
            // 
            this.lblWeightProgess.AutoSize = true;
            this.lblWeightProgess.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightProgess.ForeColor = System.Drawing.Color.Blue;
            this.lblWeightProgess.Location = new System.Drawing.Point(208, 12);
            this.lblWeightProgess.Name = "lblWeightProgess";
            this.lblWeightProgess.Size = new System.Drawing.Size(0, 20);
            this.lblWeightProgess.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Weight Progress:";
            // 
            // progressBarWeight
            // 
            this.progressBarWeight.Location = new System.Drawing.Point(29, 48);
            this.progressBarWeight.Name = "progressBarWeight";
            this.progressBarWeight.Size = new System.Drawing.Size(445, 41);
            this.progressBarWeight.TabIndex = 12;
            this.progressBarWeight.MouseEnter += new System.EventHandler(this.progressBarWeight_MouseEnter);
            // 
            // timerQuote
            // 
            this.timerQuote.Enabled = true;
            this.timerQuote.Interval = 73;
            this.timerQuote.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 1;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick_1);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // waterResetTimer
            // 
            this.waterResetTimer.Enabled = true;
            this.waterResetTimer.Tick += new System.EventHandler(this.waterResetTimer_Tick);
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
            this.btnHome.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::GymAndFitness.Properties.Resources.home_button;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-1, 110);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 47);
            this.btnHome.TabIndex = 5;
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
            this.btnAbout.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = global::GymAndFitness.Properties.Resources.info;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 340);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(210, 47);
            this.btnAbout.TabIndex = 11;
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
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Image = global::GymAndFitness.Properties.Resources.menu_bar;
            this.btnToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.Location = new System.Drawing.Point(-1, 12);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(210, 51);
            this.btnToggle.TabIndex = 4;
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
            this.btnWorkoutPlans.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkoutPlans.Image = global::GymAndFitness.Properties.Resources.workout;
            this.btnWorkoutPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkoutPlans.Location = new System.Drawing.Point(-1, 294);
            this.btnWorkoutPlans.Name = "btnWorkoutPlans";
            this.btnWorkoutPlans.Size = new System.Drawing.Size(210, 47);
            this.btnWorkoutPlans.TabIndex = 9;
            this.btnWorkoutPlans.Text = "Workout Plans";
            this.btnWorkoutPlans.UseVisualStyleBackColor = false;
            this.btnWorkoutPlans.Click += new System.EventHandler(this.btnWorkoutPlans_Click_1);
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
            this.btnBMICalculator.Location = new System.Drawing.Point(-1, 202);
            this.btnBMICalculator.Name = "btnBMICalculator";
            this.btnBMICalculator.Size = new System.Drawing.Size(210, 47);
            this.btnBMICalculator.TabIndex = 7;
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
            this.btnDietPlans.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDietPlans.Image = global::GymAndFitness.Properties.Resources.diet;
            this.btnDietPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDietPlans.Location = new System.Drawing.Point(-1, 248);
            this.btnDietPlans.Name = "btnDietPlans";
            this.btnDietPlans.Size = new System.Drawing.Size(210, 47);
            this.btnDietPlans.TabIndex = 8;
            this.btnDietPlans.Text = "Diet Plans";
            this.btnDietPlans.UseVisualStyleBackColor = false;
            this.btnDietPlans.Click += new System.EventHandler(this.btnDietPlans_Click_1);
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
            this.btnDashboard.Location = new System.Drawing.Point(-1, 156);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 47);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GymAndFitness.Properties.Resources.warning_sign;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(11, 101);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 36);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GymAndFitness.Properties.Resources.quote;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(132, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 48);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GymAndFitness.Properties.Resources.calendar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(585, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GymAndFitness.Properties.Resources.clock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(585, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GymAndFitness.Properties.Resources.drink_water;
            this.pictureBox6.Location = new System.Drawing.Point(0, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 65);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // btnAddWater
            // 
            this.btnAddWater.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddWater.BackgroundImage = global::GymAndFitness.Properties.Resources.plus;
            this.btnAddWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddWater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAddWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWater.Font = new System.Drawing.Font("Segoe UI Semibold", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWater.ForeColor = System.Drawing.Color.White;
            this.btnAddWater.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWater.Location = new System.Drawing.Point(10, 180);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(136, 35);
            this.btnAddWater.TabIndex = 2;
            this.btnAddWater.Text = "Add 1 Glass";
            this.btnAddWater.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddWater, "Add a glass of water");
            this.btnAddWater.UseVisualStyleBackColor = false;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
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
            this.btnProfilePicture.Location = new System.Drawing.Point(760, 6);
            this.btnProfilePicture.Name = "btnProfilePicture";
            this.btnProfilePicture.Size = new System.Drawing.Size(58, 58);
            this.btnProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProfilePicture.TabIndex = 40;
            this.btnProfilePicture.TabStop = false;
            this.btnProfilePicture.Click += new System.EventHandler(this.btnProfilePicture_Click_1);
            this.btnProfilePicture.MouseEnter += new System.EventHandler(this.btnProfilePicture_MouseEnter_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::GymAndFitness.Properties.Resources.Gym___FItness_logo;
            this.pictureBox5.Location = new System.Drawing.Point(66, -2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
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
            this.btnLogout.Image = global:: GymAndFitness.Properties.Resources.power_button;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(634, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnLogin.Location = new System.Drawing.Point(634, 16);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 37);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 610);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.slidePanel.ResumeLayout(false);
            this.slidePanel.PerformLayout();
            this.pnlChallenge.ResumeLayout(false);
            this.pnlChallenge.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer slideTimer;
        public System.Windows.Forms.Panel slidePanel;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnToggle;
        public System.Windows.Forms.Button btnWorkoutPlans;
        public System.Windows.Forms.Button btnBMICalculator;
        public System.Windows.Forms.Button btnDietPlans;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlChallenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Button btnChallenge;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblChallenge;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBarWater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBarWeight;
        private System.Windows.Forms.Label lblWeightProgess;
        private System.Windows.Forms.Label lblWaterIntake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer waterResetTimer;
        private System.Windows.Forms.ToolTip toolTipProgressWeight;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Classes.RoundPictureBox btnProfilePicture;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}