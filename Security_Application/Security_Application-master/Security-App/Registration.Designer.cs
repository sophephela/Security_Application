
namespace Security_App
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.fnameT = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otpT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendB = new System.Windows.Forms.Button();
            this.registerB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullNames:";
            // 
            // fnameT
            // 
            this.fnameT.Location = new System.Drawing.Point(156, 132);
            this.fnameT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fnameT.Name = "fnameT";
            this.fnameT.Size = new System.Drawing.Size(167, 24);
            this.fnameT.TabIndex = 0;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(156, 185);
            this.emailT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(167, 24);
            this.emailT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(156, 236);
            this.passwordT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(167, 24);
            this.passwordT.TabIndex = 2;
            this.passwordT.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // otpT
            // 
            this.otpT.Location = new System.Drawing.Point(156, 325);
            this.otpT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otpT.Name = "otpT";
            this.otpT.Size = new System.Drawing.Size(167, 24);
            this.otpT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "OTP:";
            // 
            // sendB
            // 
            this.sendB.Location = new System.Drawing.Point(156, 273);
            this.sendB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendB.Name = "sendB";
            this.sendB.Size = new System.Drawing.Size(167, 32);
            this.sendB.TabIndex = 3;
            this.sendB.Text = "Send OTP";
            this.sendB.UseVisualStyleBackColor = true;
            this.sendB.Click += new System.EventHandler(this.sendB_Click);
            // 
            // registerB
            // 
            this.registerB.BackColor = System.Drawing.Color.Moccasin;
            this.registerB.Location = new System.Drawing.Point(156, 371);
            this.registerB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerB.Name = "registerB";
            this.registerB.Size = new System.Drawing.Size(167, 46);
            this.registerB.TabIndex = 5;
            this.registerB.Text = "Register";
            this.registerB.UseVisualStyleBackColor = false;
            this.registerB.Click += new System.EventHandler(this.registerB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerB);
            this.Controls.Add(this.sendB);
            this.Controls.Add(this.otpT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnameT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security-App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameT;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otpT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendB;
        private System.Windows.Forms.Button registerB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

