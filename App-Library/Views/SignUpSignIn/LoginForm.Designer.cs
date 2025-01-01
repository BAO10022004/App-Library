using System.Windows.Forms;

namespace App_Library.Views
{
    partial class LoginForm
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
            this.gnBtnLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnBtnSignInGG = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerEyeOpen = new System.Windows.Forms.Timer(this.components);
            this.timerHoverGg = new System.Windows.Forms.Timer(this.components);
            this.timerLeaveGG = new System.Windows.Forms.Timer(this.components);
            this.pnMainContentLogin = new System.Windows.Forms.Panel();
            this.picEye = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.MessegePassword = new Guna.UI2.WinForms.Guna2Button();
            this.MessegeUsername = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignInGG = new Guna.UI2.WinForms.Guna2Panel();
            this.picGG = new System.Windows.Forms.PictureBox();
            this.lbGG = new System.Windows.Forms.Label();
            this.lbOr = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lbCreateAccount = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.pnMainContentLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.btnSignInGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).BeginInit();
            this.SuspendLayout();
            // 
            // gnBtnLogin
            // 
            this.gnBtnLogin.BorderRadius = 30;
            this.gnBtnLogin.TargetControl = this.btnLogIn;
            // 
            // gnBtnSignInGG
            // 
            this.gnBtnSignInGG.BorderRadius = 30;
            // 
            // timerEyeOpen
            // 
            this.timerEyeOpen.Interval = 200;
            this.timerEyeOpen.Tick += new System.EventHandler(this.timerEyeOpen_Tick);
            // 
            // timerHoverGg
            // 
            this.timerHoverGg.Interval = 1;
            this.timerHoverGg.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLeaveGG
            // 
            this.timerLeaveGG.Interval = 1;
            this.timerLeaveGG.Tick += new System.EventHandler(this.timerLeaveGG_Tick);
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.White;
            this.pnMainContentLogin.Controls.Add(this.picEye);
            this.pnMainContentLogin.Controls.Add(this.txtPassword);
            this.pnMainContentLogin.Controls.Add(this.txtUserName);
            this.pnMainContentLogin.Controls.Add(this.MessegePassword);
            this.pnMainContentLogin.Controls.Add(this.MessegeUsername);
            this.pnMainContentLogin.Controls.Add(this.btnSignInGG);
            this.pnMainContentLogin.Controls.Add(this.lbOr);
            this.pnMainContentLogin.Controls.Add(this.btnLogIn);
            this.pnMainContentLogin.Controls.Add(this.lbCreateAccount);
            this.pnMainContentLogin.Controls.Add(this.lbForgotPassword);
            this.pnMainContentLogin.Location = new System.Drawing.Point(0, 0);
            this.pnMainContentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(460, 475);
            this.pnMainContentLogin.TabIndex = 4;
            // 
            // picEye
            // 
            this.picEye.FillColor = System.Drawing.Color.Black;
            this.picEye.Image = global::App_Library.Properties.Resources.eye;
            this.picEye.ImageRotate = 0F;
            this.picEye.Location = new System.Drawing.Point(344, 163);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(32, 29);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 5;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "Password";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPassword.Location = new System.Drawing.Point(75, 154);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(310, 47);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "Username";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtUserName.Location = new System.Drawing.Point(75, 75);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(310, 47);
            this.txtUserName.TabIndex = 27;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
            this.txtUserName.MouseHover += new System.EventHandler(this.txtUserName_MouseHover);
            // 
            // MessegePassword
            // 
            this.MessegePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MessegePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MessegePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MessegePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MessegePassword.FillColor = System.Drawing.Color.White;
            this.MessegePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegePassword.ForeColor = System.Drawing.Color.Red;
            this.MessegePassword.Image = global::App_Library.Properties.Resources.mark;
            this.MessegePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegePassword.Location = new System.Drawing.Point(75, 205);
            this.MessegePassword.Name = "MessegePassword";
            this.MessegePassword.Size = new System.Drawing.Size(310, 18);
            this.MessegePassword.TabIndex = 26;
            this.MessegePassword.Text = "guna2Button1";
            this.MessegePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegePassword.Visible = false;
            // 
            // MessegeUsername
            // 
            this.MessegeUsername.BorderColor = System.Drawing.Color.White;
            this.MessegeUsername.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MessegeUsername.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MessegeUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MessegeUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MessegeUsername.FillColor = System.Drawing.Color.White;
            this.MessegeUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeUsername.ForeColor = System.Drawing.Color.Red;
            this.MessegeUsername.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeUsername.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeUsername.Location = new System.Drawing.Point(75, 129);
            this.MessegeUsername.Name = "MessegeUsername";
            this.MessegeUsername.Size = new System.Drawing.Size(310, 18);
            this.MessegeUsername.TabIndex = 25;
            this.MessegeUsername.Text = "guna2Button1";
            this.MessegeUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeUsername.Visible = false;
            // 
            // btnSignInGG
            // 
            this.btnSignInGG.BorderColor = System.Drawing.Color.Blue;
            this.btnSignInGG.BorderRadius = 15;
            this.btnSignInGG.BorderThickness = 3;
            this.btnSignInGG.Controls.Add(this.picGG);
            this.btnSignInGG.Controls.Add(this.lbGG);
            this.btnSignInGG.Location = new System.Drawing.Point(78, 345);
            this.btnSignInGG.Name = "btnSignInGG";
            this.btnSignInGG.Padding = new System.Windows.Forms.Padding(12);
            this.btnSignInGG.Size = new System.Drawing.Size(310, 47);
            this.btnSignInGG.TabIndex = 17;
            this.btnSignInGG.MouseLeave += new System.EventHandler(this.lbGG_MouseLeave);
            // 
            // picGG
            // 
            this.picGG.BackColor = System.Drawing.Color.Transparent;
            this.picGG.Image = global::App_Library.Properties.Resources.google1;
            this.picGG.Location = new System.Drawing.Point(32, 11);
            this.picGG.Name = "picGG";
            this.picGG.Size = new System.Drawing.Size(28, 23);
            this.picGG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGG.TabIndex = 1;
            this.picGG.TabStop = false;
            this.picGG.Click += new System.EventHandler(this.btnSignInGG_Click);
            this.picGG.MouseHover += new System.EventHandler(this.lbGG_MouseHover);
            // 
            // lbGG
            // 
            this.lbGG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbGG.ForeColor = System.Drawing.Color.Blue;
            this.lbGG.Location = new System.Drawing.Point(12, 12);
            this.lbGG.Name = "lbGG";
            this.lbGG.Size = new System.Drawing.Size(286, 23);
            this.lbGG.TabIndex = 0;
            this.lbGG.Text = "Continue with Google";
            this.lbGG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGG.Click += new System.EventHandler(this.btnSignInGG_Click);
            this.lbGG.MouseHover += new System.EventHandler(this.lbGG_MouseHover);
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOr.ForeColor = System.Drawing.Color.DarkGray;
            this.lbOr.Location = new System.Drawing.Point(214, 320);
            this.lbOr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(33, 18);
            this.lbOr.TabIndex = 16;
            this.lbOr.Text = "OR";
            this.lbOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Blue;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(75, 260);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(310, 47);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCreateAccount.ForeColor = System.Drawing.Color.Blue;
            this.lbCreateAccount.Location = new System.Drawing.Point(75, 224);
            this.lbCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreateAccount.Name = "lbCreateAccount";
            this.lbCreateAccount.Size = new System.Drawing.Size(124, 18);
            this.lbCreateAccount.TabIndex = 8;
            this.lbCreateAccount.Text = "Create Account";
            this.lbCreateAccount.Click += new System.EventHandler(this.lbCreateAccount_Click);
            this.lbCreateAccount.MouseLeave += new System.EventHandler(this.lbCreateAccount_MouseLeave);
            this.lbCreateAccount.MouseHover += new System.EventHandler(this.lbCreateAccount_MouseHover);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbForgotPassword.Location = new System.Drawing.Point(261, 226);
            this.lbForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(120, 15);
            this.lbForgotPassword.TabIndex = 7;
            this.lbForgotPassword.Text = "Forgot Password ";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            this.lbForgotPassword.MouseLeave += new System.EventHandler(this.lbForgotPassword_MouseLeave);
            this.lbForgotPassword.MouseHover += new System.EventHandler(this.lbForgotPassword_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 475);
            this.Controls.Add(this.pnMainContentLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 300);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoginForm";
            this.pnMainContentLogin.ResumeLayout(false);
            this.pnMainContentLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.btnSignInGG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse gnBtnLogin;
        private Panel pnMainContentLogin;
        private Label lbForgotPassword;
        private Button btnLogIn;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnSignInGG;
        private Label lbOr;
        private Guna.UI2.WinForms.Guna2PictureBox picEye;
        private Timer timerEyeOpen;
        private Label lbCreateAccount;
        private Timer timerHoverGg;
        private Timer timerLeaveGG;
        private PictureBox picGG;
        private Label lbGG;
        internal Guna.UI2.WinForms.Guna2Panel btnSignInGG;
        private Guna.UI2.WinForms.Guna2Button MessegeUsername;
        private Guna.UI2.WinForms.Guna2Button MessegePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
    }
}