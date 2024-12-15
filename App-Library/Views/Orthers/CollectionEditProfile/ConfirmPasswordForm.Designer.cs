namespace App_Library.Views.Orthers.CollectionEditProfile.ChangePasswordCollection
{
    partial class ConfirmPasswordForm
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
            this.timerHHoverNext = new System.Windows.Forms.Timer(this.components);
            this.timerLeave = new System.Windows.Forms.Timer(this.components);
            this.timerOtps = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendOtp = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodeOtp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picEye = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timerEyeOpen = new System.Windows.Forms.Timer(this.components);
            this.pnPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.pnCodeOtp = new Guna.UI2.WinForms.Guna2Panel();
            this.txtUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.pnPassword.SuspendLayout();
            this.pnCodeOtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerHHoverNext
            // 
            this.timerHHoverNext.Interval = 1;
            this.timerHHoverNext.Tick += new System.EventHandler(this.timerHHoverNext_Tick);
            // 
            // timerLeave
            // 
            this.timerLeave.Interval = 1;
            this.timerLeave.Tick += new System.EventHandler(this.timerLeave_Tick);
            // 
            // timerOtps
            // 
            this.timerOtps.Interval = 1000;
            this.timerOtps.Tick += new System.EventHandler(this.timerOtp_Tick);
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 30;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::App_Library.Properties.Resources.ArrowTittle;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(502, 458);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 58);
            this.btnNext.TabIndex = 8;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(44, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "USER NAME : ";
            // 
            // btnSendOtp
            // 
            this.btnSendOtp.BorderRadius = 15;
            this.btnSendOtp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendOtp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendOtp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOtp.ForeColor = System.Drawing.Color.White;
            this.btnSendOtp.Location = new System.Drawing.Point(438, 10);
            this.btnSendOtp.Name = "btnSendOtp";
            this.btnSendOtp.Size = new System.Drawing.Size(105, 48);
            this.btnSendOtp.TabIndex = 5;
            this.btnSendOtp.Text = "Send";
            this.btnSendOtp.Click += new System.EventHandler(this.btnSendOtp_Click);
            // 
            // txtCodeOtp
            // 
            this.txtCodeOtp.BorderRadius = 15;
            this.txtCodeOtp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodeOtp.DefaultText = "";
            this.txtCodeOtp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodeOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodeOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodeOtp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodeOtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodeOtp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtCodeOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodeOtp.Location = new System.Drawing.Point(147, 10);
            this.txtCodeOtp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCodeOtp.Name = "txtCodeOtp";
            this.txtCodeOtp.PasswordChar = '\0';
            this.txtCodeOtp.PlaceholderText = "";
            this.txtCodeOtp.SelectedText = "";
            this.txtCodeOtp.Size = new System.Drawing.Size(266, 48);
            this.txtCodeOtp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "CODE OTP ";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(147, 5);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(396, 48);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPassword.Location = new System.Drawing.Point(9, 20);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(124, 22);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm";
            // 
            // picEye
            // 
            this.picEye.BackColor = System.Drawing.Color.White;
            this.picEye.Image = global::App_Library.Properties.Resources.eye;
            this.picEye.ImageRotate = 0F;
            this.picEye.Location = new System.Drawing.Point(466, 11);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(45, 36);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 9;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // timerEyeOpen
            // 
            this.timerEyeOpen.Interval = 1000;
            this.timerEyeOpen.Tick += new System.EventHandler(this.timerEyeOpen_Tick);
            // 
            // pnPassword
            // 
            this.pnPassword.Controls.Add(this.lbPassword);
            this.pnPassword.Controls.Add(this.picEye);
            this.pnPassword.Controls.Add(this.txtPassword);
            this.pnPassword.Location = new System.Drawing.Point(35, 274);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(574, 57);
            this.pnPassword.TabIndex = 10;
            // 
            // pnCodeOtp
            // 
            this.pnCodeOtp.Controls.Add(this.label3);
            this.pnCodeOtp.Controls.Add(this.txtCodeOtp);
            this.pnCodeOtp.Controls.Add(this.btnSendOtp);
            this.pnCodeOtp.Location = new System.Drawing.Point(35, 364);
            this.pnCodeOtp.Name = "pnCodeOtp";
            this.pnCodeOtp.Size = new System.Drawing.Size(574, 66);
            this.pnCodeOtp.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtUserName.Location = new System.Drawing.Point(192, 198);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(42, 22);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.Text = "null";
            // 
            // ConfirmPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(648, 641);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pnCodeOtp);
            this.Controls.Add(this.pnPassword);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmPasswordForm";
            this.Text = "ConfirmPasswordForm";
            this.Load += new System.EventHandler(this.ConfirmPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnCodeOtp.ResumeLayout(false);
            this.pnCodeOtp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCodeOtp;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSendOtp;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Timer timerHHoverNext;
        private System.Windows.Forms.Timer timerLeave;
        private System.Windows.Forms.Timer timerOtps;
        private Guna.UI2.WinForms.Guna2PictureBox picEye;
        private System.Windows.Forms.Timer timerEyeOpen;
        private Guna.UI2.WinForms.Guna2Panel pnPassword;
        private Guna.UI2.WinForms.Guna2Panel pnCodeOtp;
        private System.Windows.Forms.Label txtUserName;
    }
}