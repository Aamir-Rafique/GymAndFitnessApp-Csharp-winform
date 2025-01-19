namespace GymAndFitness
{
    partial class BMICalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculatorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfilePicture = new GymAndFitness.Classes.RoundPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBMICategory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTargetWeightRange = new System.Windows.Forms.Label();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnWorkoutPlans = new System.Windows.Forms.Button();
            this.btnBMICalculator = new System.Windows.Forms.Button();
            this.btnDietPlans = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorHeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.slidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnProfilePicture);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnProfilePicture.Location = new System.Drawing.Point(713, 11);
            this.btnProfilePicture.Name = "btnProfilePicture";
            this.btnProfilePicture.Size = new System.Drawing.Size(58, 58);
            this.btnProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProfilePicture.TabIndex = 40;
            this.btnProfilePicture.TabStop = false;
            this.btnProfilePicture.Click += new System.EventHandler(this.btnProfilePicture_Click_1);
            this.btnProfilePicture.MouseEnter += new System.EventHandler(this.btnProfilePicture_MouseEnter_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GymAndFitness.Properties.Resources.Gym___FItness_logo;
            this.pictureBox2.Location = new System.Drawing.Point(60, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight (kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Height and weight to calculate your BMI";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(164, 165);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(144, 30);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(164, 219);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(144, 30);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "BMI";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBMI.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(137, 355);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 21);
            this.lblBMI.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(164, 284);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 25);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBMICategory
            // 
            this.lblBMICategory.AutoSize = true;
            this.lblBMICategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBMICategory.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMICategory.Location = new System.Drawing.Point(192, 397);
            this.lblBMICategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMICategory.Name = "lblBMICategory";
            this.lblBMICategory.Size = new System.Drawing.Size(0, 21);
            this.lblBMICategory.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "BMI Category:";
            // 
            // lblTargetWeightRange
            // 
            this.lblTargetWeightRange.AutoSize = true;
            this.lblTargetWeightRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTargetWeightRange.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetWeightRange.Location = new System.Drawing.Point(239, 504);
            this.lblTargetWeightRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetWeightRange.Name = "lblTargetWeightRange";
            this.lblTargetWeightRange.Size = new System.Drawing.Size(0, 21);
            this.lblTargetWeightRange.TabIndex = 32;
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
            this.slidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePanel.Location = new System.Drawing.Point(0, 74);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(200, 486);
            this.slidePanel.TabIndex = 33;
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
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
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 1;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GymAndFitness.Properties.Resources.bmi_chart_new;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(401, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 314);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "BMI Scale");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 503);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Target Weight Range:";
            // 
            // errorHeight
            // 
            this.errorHeight.ContainerControl = this;
            // 
            // errorWeight
            // 
            this.errorWeight.ContainerControl = this;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.slidePanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTargetWeightRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBMICategory);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.slidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBMICategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTargetWeightRange;
        public System.Windows.Forms.Panel slidePanel;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnToggle;
        public System.Windows.Forms.Button btnWorkoutPlans;
        public System.Windows.Forms.Button btnBMICalculator;
        public System.Windows.Forms.Button btnDietPlans;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorHeight;
        private System.Windows.Forms.ErrorProvider errorWeight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Classes.RoundPictureBox btnProfilePicture;
    }
}