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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbBMIChart = new System.Windows.Forms.PictureBox();
            this.pbUnitConverter = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTargetWeightRange = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBMICategory = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMembershipStatus = new System.Windows.Forms.PictureBox();
            this.pbProfilePicture = new GymAndFitness.Classes.RoundPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBMIChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnitConverter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembershipStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height (cm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight (kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(70, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Height and weight to calculate your BMI";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(164, 195);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(153, 30);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(164, 247);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(153, 30);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(200, 309);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 29);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // pbBMIChart
            // 
            this.pbBMIChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBMIChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBMIChart.Image = global::GymAndFitness.Properties.Resources.bmiChartNormal;
            this.pbBMIChart.Location = new System.Drawing.Point(418, 151);
            this.pbBMIChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbBMIChart.Name = "pbBMIChart";
            this.pbBMIChart.Size = new System.Drawing.Size(371, 301);
            this.pbBMIChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBMIChart.TabIndex = 4;
            this.pbBMIChart.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBMIChart, "BMI Scale");
            // 
            // pbUnitConverter
            // 
            this.pbUnitConverter.BackgroundImage = global::GymAndFitness.Properties.Resources.exchange;
            this.pbUnitConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUnitConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUnitConverter.Location = new System.Drawing.Point(331, 195);
            this.pbUnitConverter.Name = "pbUnitConverter";
            this.pbUnitConverter.Size = new System.Drawing.Size(36, 30);
            this.pbUnitConverter.TabIndex = 75;
            this.pbUnitConverter.TabStop = false;
            this.toolTip1.SetToolTip(this.pbUnitConverter, "Unit Converter");
            this.pbUnitConverter.Click += new System.EventHandler(this.pbUnitConverter_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblTargetWeightRange);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblBMICategory);
            this.panel3.Controls.Add(this.lblBMI);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(55, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 193);
            this.panel3.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 76;
            this.label7.Text = "Target Weight Range:";
            // 
            // lblTargetWeightRange
            // 
            this.lblTargetWeightRange.AutoSize = true;
            this.lblTargetWeightRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTargetWeightRange.Font = new System.Drawing.Font("Calibri", 13.11881F, System.Drawing.FontStyle.Bold);
            this.lblTargetWeightRange.ForeColor = System.Drawing.Color.Green;
            this.lblTargetWeightRange.Location = new System.Drawing.Point(195, 140);
            this.lblTargetWeightRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetWeightRange.Name = "lblTargetWeightRange";
            this.lblTargetWeightRange.Size = new System.Drawing.Size(0, 23);
            this.lblTargetWeightRange.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "BMI Category:";
            // 
            // lblBMICategory
            // 
            this.lblBMICategory.AutoSize = true;
            this.lblBMICategory.BackColor = System.Drawing.Color.White;
            this.lblBMICategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBMICategory.Font = new System.Drawing.Font("Calibri", 12.83168F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMICategory.Location = new System.Drawing.Point(152, 88);
            this.lblBMICategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMICategory.Name = "lblBMICategory";
            this.lblBMICategory.Size = new System.Drawing.Size(0, 22);
            this.lblBMICategory.TabIndex = 73;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.Color.White;
            this.lblBMI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBMI.Font = new System.Drawing.Font("Calibri", 14.11881F, System.Drawing.FontStyle.Bold);
            this.lblBMI.Location = new System.Drawing.Point(97, 45);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 24);
            this.lblBMI.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 71;
            this.label5.Text = "BMI: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 70;
            this.label9.Text = "Physique Info:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pbMembershipStatus);
            this.panel1.Controls.Add(this.pbProfilePicture);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 78);
            this.panel1.TabIndex = 1;
            // 
            // pbMembershipStatus
            // 
            this.pbMembershipStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMembershipStatus.Location = new System.Drawing.Point(277, 26);
            this.pbMembershipStatus.Name = "pbMembershipStatus";
            this.pbMembershipStatus.Size = new System.Drawing.Size(30, 26);
            this.pbMembershipStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMembershipStatus.TabIndex = 41;
            this.pbMembershipStatus.TabStop = false;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pbProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfilePicture.BorderColor = System.Drawing.Color.Lime;
            this.pbProfilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfilePicture.BorderSize = 2;
            this.pbProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProfilePicture.GradientAngle = 50F;
            this.pbProfilePicture.Image = global::GymAndFitness.Properties.Resources.usernew;
            this.pbProfilePicture.Location = new System.Drawing.Point(666, 7);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(64, 64);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 40;
            this.pbProfilePicture.TabStop = false;
            this.pbProfilePicture.Click += new System.EventHandler(this.pbProfilePicture_Click);
            this.pbProfilePicture.MouseEnter += new System.EventHandler(this.pbProfilePicture_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GymAndFitness.Properties.Resources.Gym___FItness_logo;
            this.pictureBox2.Location = new System.Drawing.Point(20, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(802, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.pbUnitConverter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbBMIChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BMICalculatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gym & Fitness";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMICalculatorForm_FormClosed);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnCalculate, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pbBMIChart, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.pbUnitConverter, 0);
            this.Controls.SetChildIndex(this.txtHeight, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbBMIChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnitConverter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembershipStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.PictureBox pbBMIChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTargetWeightRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBMICategory;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMembershipStatus;
        private Classes.RoundPictureBox pbProfilePicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbUnitConverter;
    }
}