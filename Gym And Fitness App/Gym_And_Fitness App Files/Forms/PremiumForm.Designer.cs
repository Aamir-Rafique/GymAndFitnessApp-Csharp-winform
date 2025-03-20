namespace GymAndFitness
{
    partial class PremiumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremiumForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerifyKey = new System.Windows.Forms.Button();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLicenseKey = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGetNewKey = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorLicenseKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 40);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(117, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Premium Plan";
            // 
            // btnVerifyKey
            // 
            this.btnVerifyKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerifyKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnVerifyKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnVerifyKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyKey.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerifyKey.Location = new System.Drawing.Point(124, 161);
            this.btnVerifyKey.Name = "btnVerifyKey";
            this.btnVerifyKey.Size = new System.Drawing.Size(80, 30);
            this.btnVerifyKey.TabIndex = 2;
            this.btnVerifyKey.Text = "Verify";
            this.btnVerifyKey.UseVisualStyleBackColor = false;
            this.btnVerifyKey.Click += new System.EventHandler(this.btnVerifyKey_Click);
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseKey.Location = new System.Drawing.Point(123, 115);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(207, 26);
            this.txtLicenseKey.TabIndex = 1;
            this.txtLicenseKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLicenseKey_KeyDown);
            this.txtLicenseKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseKey_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(13, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lisence Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Your License Key";
            // 
            // errorLicenseKey
            // 
            this.errorLicenseKey.ContainerControl = this;
            // 
            // btnGetNewKey
            // 
            this.btnGetNewKey.BackColor = System.Drawing.Color.Orange;
            this.btnGetNewKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGetNewKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnGetNewKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetNewKey.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNewKey.ForeColor = System.Drawing.Color.White;
            this.btnGetNewKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetNewKey.Location = new System.Drawing.Point(296, 201);
            this.btnGetNewKey.Name = "btnGetNewKey";
            this.btnGetNewKey.Size = new System.Drawing.Size(101, 31);
            this.btnGetNewKey.TabIndex = 3;
            this.btnGetNewKey.Text = "Get a key";
            this.btnGetNewKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGetNewKey, "Click to get a License key!");
            this.btnGetNewKey.UseVisualStyleBackColor = false;
            this.btnGetNewKey.Click += new System.EventHandler(this.btnGetNewKey_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GymAndFitness.Properties.Resources.key3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(259, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // PremiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(402, 239);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGetNewKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerifyKey);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 279);
            this.MinimumSize = new System.Drawing.Size(418, 279);
            this.Name = "PremiumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PremiumForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorLicenseKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerifyKey;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetNewKey;
        private System.Windows.Forms.ErrorProvider errorLicenseKey;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}