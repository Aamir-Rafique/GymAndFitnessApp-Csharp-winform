namespace GymAndFitness
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActivatePremium = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbtnEasyPaisa = new System.Windows.Forms.RadioButton();
            this.rbtnJazzCash = new System.Windows.Forms.RadioButton();
            this.rbtnPayPal = new System.Windows.Forms.RadioButton();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.ribbonControl1 = new GymAndFitness.Classes.RibbonControl();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMembershipStatus = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBoxRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembershipStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(167, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select payment method";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(176, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12.11881F);
            this.label2.Location = new System.Drawing.Point(111, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email:";
            // 
            // btnActivatePremium
            // 
            this.btnActivatePremium.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActivatePremium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnActivatePremium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnActivatePremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivatePremium.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivatePremium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActivatePremium.Location = new System.Drawing.Point(211, 333);
            this.btnActivatePremium.Name = "btnActivatePremium";
            this.btnActivatePremium.Size = new System.Drawing.Size(157, 34);
            this.btnActivatePremium.TabIndex = 6;
            this.btnActivatePremium.Text = "Activate Premium";
            this.btnActivatePremium.UseVisualStyleBackColor = false;
            this.btnActivatePremium.Click += new System.EventHandler(this.btnActivatePremium_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox4);
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox3);
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox1);
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox2);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnEasyPaisa);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnJazzCash);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnPayPal);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnVisa);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(76, 119);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(414, 130);
            this.groupBoxRadioButtons.TabIndex = 68;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::GymAndFitness.Properties.Resources.Easypaisa_New_Icon_Logo;
            this.pictureBox4.Location = new System.Drawing.Point(27, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::GymAndFitness.Properties.Resources.paypal;
            this.pictureBox3.Location = new System.Drawing.Point(241, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GymAndFitness.Properties.Resources.Jazz_Cash_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(241, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::GymAndFitness.Properties.Resources.visa;
            this.pictureBox2.Location = new System.Drawing.Point(22, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // rbtnEasyPaisa
            // 
            this.rbtnEasyPaisa.AutoSize = true;
            this.rbtnEasyPaisa.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEasyPaisa.Location = new System.Drawing.Point(69, 25);
            this.rbtnEasyPaisa.Name = "rbtnEasyPaisa";
            this.rbtnEasyPaisa.Size = new System.Drawing.Size(106, 24);
            this.rbtnEasyPaisa.TabIndex = 1;
            this.rbtnEasyPaisa.TabStop = true;
            this.rbtnEasyPaisa.Text = "EasyPaisa";
            this.rbtnEasyPaisa.UseVisualStyleBackColor = true;
            // 
            // rbtnJazzCash
            // 
            this.rbtnJazzCash.AutoSize = true;
            this.rbtnJazzCash.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJazzCash.Location = new System.Drawing.Point(297, 23);
            this.rbtnJazzCash.Name = "rbtnJazzCash";
            this.rbtnJazzCash.Size = new System.Drawing.Size(97, 24);
            this.rbtnJazzCash.TabIndex = 2;
            this.rbtnJazzCash.TabStop = true;
            this.rbtnJazzCash.Text = "JazzCash";
            this.rbtnJazzCash.UseVisualStyleBackColor = true;
            // 
            // rbtnPayPal
            // 
            this.rbtnPayPal.AutoSize = true;
            this.rbtnPayPal.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPayPal.Location = new System.Drawing.Point(298, 78);
            this.rbtnPayPal.Name = "rbtnPayPal";
            this.rbtnPayPal.Size = new System.Drawing.Size(80, 24);
            this.rbtnPayPal.TabIndex = 4;
            this.rbtnPayPal.TabStop = true;
            this.rbtnPayPal.Text = "PayPal";
            this.rbtnPayPal.UseVisualStyleBackColor = true;
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisa.Location = new System.Drawing.Point(69, 79);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(61, 24);
            this.rbtnVisa.TabIndex = 3;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSize = true;
            this.ribbonControl1.BackColor = System.Drawing.Color.MediumBlue;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(550, 34);
            this.ribbonControl1.TabIndex = 69;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(513, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 70;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::GymAndFitness.Properties.Resources.previous;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 71;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pbMembershipStatus);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 51);
            this.panel1.TabIndex = 72;
            // 
            // pbMembershipStatus
            // 
            this.pbMembershipStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMembershipStatus.Image = global::GymAndFitness.Properties.Resources.crown1;
            this.pbMembershipStatus.Location = new System.Drawing.Point(167, 8);
            this.pbMembershipStatus.Name = "pbMembershipStatus";
            this.pbMembershipStatus.Size = new System.Drawing.Size(39, 35);
            this.pbMembershipStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMembershipStatus.TabIndex = 73;
            this.pbMembershipStatus.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.68317F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Premium Plan";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(554, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(550, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.btnActivatePremium);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 390);
            this.MinimumSize = new System.Drawing.Size(550, 390);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentForm_FormClosed);
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembershipStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActivatePremium;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbtnEasyPaisa;
        private System.Windows.Forms.RadioButton rbtnJazzCash;
        private System.Windows.Forms.RadioButton rbtnPayPal;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private Classes.RibbonControl ribbonControl1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMembershipStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}