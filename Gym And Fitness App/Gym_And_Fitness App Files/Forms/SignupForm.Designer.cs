namespace GymAndFitness
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFitnessLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFitnessGoal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtTargetWeight = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTargetWeightRange = new System.Windows.Forms.Label();
            this.lblProfilePicturePath = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbProfilePicture = new GymAndFitness.Classes.RoundPictureBox();
            this.ribbonControl1 = new GymAndFitness.Classes.RibbonControl();
            this.lblUsernameStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnBackToLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 68);
            this.panel1.TabIndex = 3;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackgroundImage = global::GymAndFitness.Properties.Resources.previous;
            this.btnBackToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.Location = new System.Drawing.Point(23, 8);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(42, 49);
            this.btnBackToLogin.TabIndex = 3;
            this.btnBackToLogin.TabStop = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.82178F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12.11881F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(23, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(436, 23);
            this.label15.TabIndex = 61;
            this.label15.Text = "Please fill all the required fields to create your account";
            // 
            // cmbFitnessLevel
            // 
            this.cmbFitnessLevel.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFitnessLevel.FormattingEnabled = true;
            this.cmbFitnessLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cmbFitnessLevel.Location = new System.Drawing.Point(175, 368);
            this.cmbFitnessLevel.Name = "cmbFitnessLevel";
            this.cmbFitnessLevel.Size = new System.Drawing.Size(148, 26);
            this.cmbFitnessLevel.TabIndex = 7;
            this.cmbFitnessLevel.Text = "Select an option...";
            this.cmbFitnessLevel.SelectedIndexChanged += new System.EventHandler(this.cmbFitnessLevel_SelectedIndexChanged);
            this.cmbFitnessLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFitnessLevel_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(46, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Fitness Level:";
            // 
            // cmbFitnessGoal
            // 
            this.cmbFitnessGoal.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFitnessGoal.FormattingEnabled = true;
            this.cmbFitnessGoal.Items.AddRange(new object[] {
            "Muscle Gain",
            "Fat Loss"});
            this.cmbFitnessGoal.Location = new System.Drawing.Point(496, 367);
            this.cmbFitnessGoal.Name = "cmbFitnessGoal";
            this.cmbFitnessGoal.Size = new System.Drawing.Size(149, 26);
            this.cmbFitnessGoal.TabIndex = 8;
            this.cmbFitnessGoal.Text = "Select an option...";
            this.cmbFitnessGoal.SelectedIndexChanged += new System.EventHandler(this.cmbFitnessGoal_SelectedIndexChanged);
            this.cmbFitnessGoal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFitnessGoal_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(372, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 56;
            this.label9.Text = "Fitness Goal:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(175, 429);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(175, 239);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(148, 26);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(496, 178);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(148, 26);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(496, 238);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(148, 26);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(175, 176);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // cmbGender
            // 
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(175, 300);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(148, 27);
            this.cmbGender.TabIndex = 3;
            this.cmbGender.Text = "Select an option...";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            this.cmbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGender_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(46, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(47, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(367, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Height (cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(372, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Weight (kg):";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignup.Location = new System.Drawing.Point(260, 499);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(114, 34);
            this.btnSignup.TabIndex = 12;
            this.btnSignup.Text = "SignUp";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Username:";
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUploadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnUploadPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnUploadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadPicture.Location = new System.Drawing.Point(742, 367);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(71, 29);
            this.btnUploadPicture.TabIndex = 11;
            this.btnUploadPicture.Text = "Upload";
            this.btnUploadPicture.UseVisualStyleBackColor = false;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(687, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 21);
            this.label13.TabIndex = 71;
            this.label13.Text = "Upload Profile Picture";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(534, 429);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(111, 26);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(372, 432);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 21);
            this.label14.TabIndex = 75;
            this.label14.Text = "Confirm Password:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(449, 499);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(371, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 78;
            this.label12.Text = "Target Weight (kg):";
            // 
            // txtTargetWeight
            // 
            this.txtTargetWeight.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetWeight.Location = new System.Drawing.Point(534, 298);
            this.txtTargetWeight.Name = "txtTargetWeight";
            this.txtTargetWeight.Size = new System.Drawing.Size(110, 26);
            this.txtTargetWeight.TabIndex = 6;
            this.txtTargetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTargetWeight_KeyPress_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.267326F, System.Drawing.FontStyle.Italic);
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(372, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 17);
            this.label17.TabIndex = 79;
            this.label17.Text = "Suggested Weight Range(kg):";
            // 
            // lblTargetWeightRange
            // 
            this.lblTargetWeightRange.AutoSize = true;
            this.lblTargetWeightRange.Font = new System.Drawing.Font("Cascadia Code", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetWeightRange.ForeColor = System.Drawing.Color.Purple;
            this.lblTargetWeightRange.Location = new System.Drawing.Point(541, 324);
            this.lblTargetWeightRange.Name = "lblTargetWeightRange";
            this.lblTargetWeightRange.Size = new System.Drawing.Size(88, 17);
            this.lblTargetWeightRange.TabIndex = 80;
            this.lblTargetWeightRange.Text = "Loading...";
            // 
            // lblProfilePicturePath
            // 
            this.lblProfilePicturePath.AutoSize = true;
            this.lblProfilePicturePath.Font = new System.Drawing.Font("Segoe UI", 9.267326F, System.Drawing.FontStyle.Italic);
            this.lblProfilePicturePath.ForeColor = System.Drawing.Color.Transparent;
            this.lblProfilePicturePath.Location = new System.Drawing.Point(875, 550);
            this.lblProfilePicturePath.Name = "lblProfilePicturePath";
            this.lblProfilePicturePath.Size = new System.Drawing.Size(0, 17);
            this.lblProfilePicturePath.TabIndex = 81;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfilePicture.BorderColor = System.Drawing.Color.Aqua;
            this.pbProfilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfilePicture.BorderSize = 2;
            this.pbProfilePicture.GradientAngle = 50F;
            this.pbProfilePicture.Image = global::GymAndFitness.Properties.Resources.usernew;
            this.pbProfilePicture.Location = new System.Drawing.Point(696, 172);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 76;
            this.pbProfilePicture.TabStop = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSize = true;
            this.ribbonControl1.BackColor = System.Drawing.Color.MediumBlue;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(880, 34);
            this.ribbonControl1.TabIndex = 82;
            // 
            // lblUsernameStatus
            // 
            this.lblUsernameStatus.AutoSize = true;
            this.lblUsernameStatus.Font = new System.Drawing.Font("Cascadia Code", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameStatus.ForeColor = System.Drawing.Color.Purple;
            this.lblUsernameStatus.Location = new System.Drawing.Point(175, 205);
            this.lblUsernameStatus.Name = "lblUsernameStatus";
            this.lblUsernameStatus.Size = new System.Drawing.Size(0, 17);
            this.lblUsernameStatus.TabIndex = 83;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.lblUsernameStatus);
            this.Controls.Add(this.cmbFitnessLevel);
            this.Controls.Add(this.txtTargetWeight);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.cmbFitnessGoal);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.lblProfilePicturePath);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblTargetWeightRange);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 550);
            this.MinimumSize = new System.Drawing.Size(880, 550);
            this.Name = "SignupForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignupForm_FormClosed);
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFitnessLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFitnessGoal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTip1;
        private Classes.RoundPictureBox pbProfilePicture;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTargetWeight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTargetWeightRange;
        private System.Windows.Forms.Label lblProfilePicturePath;
        private System.Windows.Forms.ErrorProvider error;
        private Classes.RibbonControl ribbonControl1;
        private System.Windows.Forms.PictureBox btnBackToLogin;
        private System.Windows.Forms.Label lblUsernameStatus;
    }
}