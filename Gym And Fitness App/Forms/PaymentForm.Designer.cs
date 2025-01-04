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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.txtGeneratedKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorGroupBoxRadioButtons = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbtnEasyPaisa = new System.Windows.Forms.RadioButton();
            this.rbtnJazzCash = new System.Windows.Forms.RadioButton();
            this.rbtnPayPal = new System.Windows.Forms.RadioButton();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.errorGeneratedKey = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorGroupBoxRadioButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            this.groupBoxRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGeneratedKey)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(109, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select payment method";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(72, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Input a Valid Email Address";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerateKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGenerateKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKey.Font = new System.Drawing.Font("Segoe UI", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateKey.Location = new System.Drawing.Point(138, 288);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(133, 34);
            this.btnGenerateKey.TabIndex = 6;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // txtGeneratedKey
            // 
            this.txtGeneratedKey.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedKey.Location = new System.Drawing.Point(384, 294);
            this.txtGeneratedKey.Name = "txtGeneratedKey";
            this.txtGeneratedKey.Size = new System.Drawing.Size(193, 26);
            this.txtGeneratedKey.TabIndex = 7;
            this.txtGeneratedKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneratedKey_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Your Key Appears here:";
            // 
            // errorGroupBoxRadioButtons
            // 
            this.errorGroupBoxRadioButtons.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox4);
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox3);
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox1);
            this.groupBoxRadioButtons.Controls.Add(this.pictureBox2);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnEasyPaisa);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnJazzCash);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnPayPal);
            this.groupBoxRadioButtons.Controls.Add(this.rbtnVisa);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(70, 65);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(440, 130);
            this.groupBoxRadioButtons.TabIndex = 68;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::GymAndFitness.Properties.Resources.Easypaisa_New_Icon_Logo;
            this.pictureBox4.Location = new System.Drawing.Point(25, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::GymAndFitness.Properties.Resources.paypal;
            this.pictureBox3.Location = new System.Drawing.Point(14, 76);
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
            this.pictureBox1.Location = new System.Drawing.Point(278, 18);
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
            this.pictureBox2.Location = new System.Drawing.Point(286, 81);
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
            this.rbtnEasyPaisa.Location = new System.Drawing.Point(71, 23);
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
            this.rbtnJazzCash.Location = new System.Drawing.Point(334, 23);
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
            this.rbtnPayPal.Location = new System.Drawing.Point(71, 85);
            this.rbtnPayPal.Name = "rbtnPayPal";
            this.rbtnPayPal.Size = new System.Drawing.Size(80, 24);
            this.rbtnPayPal.TabIndex = 3;
            this.rbtnPayPal.TabStop = true;
            this.rbtnPayPal.Text = "PayPal";
            this.rbtnPayPal.UseVisualStyleBackColor = true;
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Font = new System.Drawing.Font("Rockwell", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisa.Location = new System.Drawing.Point(333, 85);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(61, 24);
            this.rbtnVisa.TabIndex = 4;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            // 
            // errorGeneratedKey
            // 
            this.errorGeneratedKey.ContainerControl = this;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 349);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGeneratedKey);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym & Fitness";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorGroupBoxRadioButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGeneratedKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox txtGeneratedKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorGroupBoxRadioButtons;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbtnEasyPaisa;
        private System.Windows.Forms.RadioButton rbtnJazzCash;
        private System.Windows.Forms.RadioButton rbtnPayPal;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.ErrorProvider errorGeneratedKey;
    }
}