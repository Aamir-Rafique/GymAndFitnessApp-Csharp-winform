namespace GymAndFitness.Classes
{
    partial class RibbonControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonControl));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pbAppIcon = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::GymAndFitness.Properties.Resources.close_normal;
            this.btnClose.Location = new System.Drawing.Point(41, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.Image = global::GymAndFitness.Properties.Resources.minimize_normal;
            this.btnMinimize.Location = new System.Drawing.Point(5, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // pbAppIcon
            // 
            this.pbAppIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbAppIcon.Image")));
            this.pbAppIcon.Location = new System.Drawing.Point(6, 4);
            this.pbAppIcon.Name = "pbAppIcon";
            this.pbAppIcon.Size = new System.Drawing.Size(26, 27);
            this.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAppIcon.TabIndex = 16;
            this.pbAppIcon.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAppIcon, "Gym & Fitness App");
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 10.9802F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(34, 7);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(119, 21);
            this.lblAppName.TabIndex = 15;
            this.lblAppName.Text = "Gym && Fitness";
            this.toolTip1.SetToolTip(this.lblAppName, "Gym & Fitness App");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(722, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 34);
            this.panel1.TabIndex = 0;
            // 
            // RibbonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.Controls.Add(this.pbAppIcon);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.panel1);
            this.Name = "RibbonControl";
            this.Size = new System.Drawing.Size(800, 34);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RibbonControl_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RibbonControl_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RibbonControl_MouseUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox pbAppIcon;
        private System.Windows.Forms.Label lblAppName;
    }
}
