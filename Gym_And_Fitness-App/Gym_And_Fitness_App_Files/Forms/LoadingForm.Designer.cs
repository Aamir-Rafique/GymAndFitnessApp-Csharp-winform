namespace GymAndFitness.Forms
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lbl1Develop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new GymAndFitness.Classes.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27.80198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(155, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gym && Fitness";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Cascadia Mono", 13.83168F, System.Drawing.FontStyle.Bold);
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(2, 203);
            this.lblLoading.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(132, 27);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1Develop
            // 
            this.lbl1Develop.AutoSize = true;
            this.lbl1Develop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Develop.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl1Develop.Location = new System.Drawing.Point(446, 261);
            this.lbl1Develop.Name = "lbl1Develop";
            this.lbl1Develop.Size = new System.Drawing.Size(77, 17);
            this.lbl1Develop.TabIndex = 3;
            this.lbl1Develop.Text = " AR FitTech";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code Light", 8.267326F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(446, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Powered by";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.980198F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblVersion.Location = new System.Drawing.Point(311, 103);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(118, 19);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "version: Loading..";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.25743F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(208, 137);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 31);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(-1, 230);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(538, 11);
            this.progressBarLoading.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBox1.BorderSize = 2;
            this.pictureBox1.GradientAngle = 50F;
            this.pictureBox1.Image = global::GymAndFitness.Properties.Resources.Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(59, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(535, 284);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl1Develop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 284);
            this.MinimumSize = new System.Drawing.Size(535, 284);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lbl1Develop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private Classes.RoundPictureBox pictureBox1;
    }
}