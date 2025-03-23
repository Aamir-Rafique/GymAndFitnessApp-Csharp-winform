namespace GymAndFitness.Forms
{
    partial class BaseForm
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
            this.ribbonControl1 = new GymAndFitness.Classes.RibbonControl();
            this.slidePanel1 = new GymAndFitness.Classes.SlidePanel();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSize = true;
            this.ribbonControl1.BackColor = System.Drawing.Color.DarkBlue;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(800, 34);
            this.ribbonControl1.TabIndex = 0;
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.Color.MediumBlue;
            this.slidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePanel1.Location = new System.Drawing.Point(0, 34);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(210, 573);
            this.slidePanel1.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.slidePanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Classes.RibbonControl ribbonControl1;
        private Classes.SlidePanel slidePanel1;
    }
}