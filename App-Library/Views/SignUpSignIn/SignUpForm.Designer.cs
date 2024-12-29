namespace App_Library.Views
{
    partial class SignUpForm
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
            this.pnMainContentLogin = new System.Windows.Forms.Panel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignInGG = new Guna.UI2.WinForms.Guna2Panel();
            this.picGG = new System.Windows.Forms.PictureBox();
            this.lbGG = new System.Windows.Forms.Label();
            this.MessegeConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.MessegePassword = new Guna.UI2.WinForms.Guna2Button();
            this.MessegeUsername = new Guna.UI2.WinForms.Guna2Button();
            this.MessegeEmail = new Guna.UI2.WinForms.Guna2Button();
            this.lbOr = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lbLogin1 = new System.Windows.Forms.Label();
            this.lbLogin2 = new System.Windows.Forms.Label();
            this.gnBtnSignInGG = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnBtnLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerOpenEyeForPassWord = new System.Windows.Forms.Timer(this.components);
            this.timerOpenEyeForConfirm = new System.Windows.Forms.Timer(this.components);
            this.timerHoverGg = new System.Windows.Forms.Timer(this.components);
            this.timerLeaveGG = new System.Windows.Forms.Timer(this.components);
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.picEyeOfPass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.picEyeOfConfirm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnMainContentLogin.SuspendLayout();
            this.btnSignInGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfPass)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.White;
            this.pnMainContentLogin.Controls.Add(this.guna2Panel3);
            this.pnMainContentLogin.Controls.Add(this.guna2Panel1);
            this.pnMainContentLogin.Controls.Add(this.txtUsername);
            this.pnMainContentLogin.Controls.Add(this.txtEmail);
            this.pnMainContentLogin.Controls.Add(this.btnSignInGG);
            this.pnMainContentLogin.Controls.Add(this.MessegeConfirm);
            this.pnMainContentLogin.Controls.Add(this.MessegePassword);
            this.pnMainContentLogin.Controls.Add(this.MessegeUsername);
            this.pnMainContentLogin.Controls.Add(this.MessegeEmail);
            this.pnMainContentLogin.Controls.Add(this.lbOr);
            this.pnMainContentLogin.Controls.Add(this.btnSignUp);
            this.pnMainContentLogin.Controls.Add(this.lbLogin1);
            this.pnMainContentLogin.Controls.Add(this.lbLogin2);
            this.pnMainContentLogin.Location = new System.Drawing.Point(0, 0);
            this.pnMainContentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(460, 475);
            this.pnMainContentLogin.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "Email";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtEmail.Location = new System.Drawing.Point(75, 13);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(310, 47);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // btnSignInGG
            // 
            this.btnSignInGG.BorderColor = System.Drawing.Color.Blue;
            this.btnSignInGG.BorderRadius = 15;
            this.btnSignInGG.BorderThickness = 3;
            this.btnSignInGG.Controls.Add(this.picGG);
            this.btnSignInGG.Controls.Add(this.lbGG);
            this.btnSignInGG.Location = new System.Drawing.Point(78, 398);
            this.btnSignInGG.Name = "btnSignInGG";
            this.btnSignInGG.Padding = new System.Windows.Forms.Padding(12);
            this.btnSignInGG.Size = new System.Drawing.Size(310, 47);
            this.btnSignInGG.TabIndex = 27;
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
            // MessegeConfirm
            // 
            this.MessegeConfirm.CustomBorderColor = System.Drawing.Color.Black;
            this.MessegeConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MessegeConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MessegeConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MessegeConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MessegeConfirm.FillColor = System.Drawing.Color.White;
            this.MessegeConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeConfirm.ForeColor = System.Drawing.Color.Red;
            this.MessegeConfirm.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeConfirm.Location = new System.Drawing.Point(78, 300);
            this.MessegeConfirm.Name = "MessegeConfirm";
            this.MessegeConfirm.Size = new System.Drawing.Size(310, 18);
            this.MessegeConfirm.TabIndex = 26;
            this.MessegeConfirm.Text = "guna2Button1";
            this.MessegeConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeConfirm.Visible = false;
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
            this.MessegePassword.Location = new System.Drawing.Point(78, 225);
            this.MessegePassword.Name = "MessegePassword";
            this.MessegePassword.Size = new System.Drawing.Size(310, 18);
            this.MessegePassword.TabIndex = 25;
            this.MessegePassword.Text = "guna2Button1";
            this.MessegePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegePassword.Visible = false;
            // 
            // MessegeUsername
            // 
            this.MessegeUsername.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MessegeUsername.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MessegeUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MessegeUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MessegeUsername.FillColor = System.Drawing.Color.White;
            this.MessegeUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeUsername.ForeColor = System.Drawing.Color.Red;
            this.MessegeUsername.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeUsername.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeUsername.Location = new System.Drawing.Point(78, 146);
            this.MessegeUsername.Name = "MessegeUsername";
            this.MessegeUsername.Size = new System.Drawing.Size(310, 18);
            this.MessegeUsername.TabIndex = 24;
            this.MessegeUsername.Text = "guna2Button1";
            this.MessegeUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeUsername.Visible = false;
            // 
            // MessegeEmail
            // 
            this.MessegeEmail.BackColor = System.Drawing.Color.Black;
            this.MessegeEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MessegeEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MessegeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MessegeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MessegeEmail.FillColor = System.Drawing.Color.White;
            this.MessegeEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeEmail.ForeColor = System.Drawing.Color.Red;
            this.MessegeEmail.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeEmail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeEmail.Location = new System.Drawing.Point(75, 67);
            this.MessegeEmail.Name = "MessegeEmail";
            this.MessegeEmail.Size = new System.Drawing.Size(310, 18);
            this.MessegeEmail.TabIndex = 21;
            this.MessegeEmail.Text = "guna2Button1";
            this.MessegeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeEmail.Visible = false;
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOr.ForeColor = System.Drawing.Color.Black;
            this.lbOr.Location = new System.Drawing.Point(213, 376);
            this.lbOr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(33, 19);
            this.lbOr.TabIndex = 18;
            this.lbOr.Text = "OR";
            this.lbOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Blue;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(75, 327);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(310, 47);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lbLogin1
            // 
            this.lbLogin1.AutoSize = true;
            this.lbLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLogin1.ForeColor = System.Drawing.Color.Gray;
            this.lbLogin1.Location = new System.Drawing.Point(72, 453);
            this.lbLogin1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin1.Name = "lbLogin1";
            this.lbLogin1.Size = new System.Drawing.Size(173, 17);
            this.lbLogin1.TabIndex = 8;
            this.lbLogin1.Text = "Already have an account?";
            this.lbLogin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLogin2
            // 
            this.lbLogin2.AutoSize = true;
            this.lbLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLogin2.ForeColor = System.Drawing.Color.Blue;
            this.lbLogin2.Location = new System.Drawing.Point(249, 453);
            this.lbLogin2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin2.Name = "lbLogin2";
            this.lbLogin2.Size = new System.Drawing.Size(46, 17);
            this.lbLogin2.TabIndex = 7;
            this.lbLogin2.Text = "Login!";
            this.lbLogin2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLogin2.Click += new System.EventHandler(this.lbLogin2_Click);
            // 
            // gnBtnSignInGG
            // 
            this.gnBtnSignInGG.BorderRadius = 30;
            // 
            // gnBtnLogin
            // 
            this.gnBtnLogin.BorderRadius = 30;
            this.gnBtnLogin.TargetControl = this.btnSignUp;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // timerOpenEyeForPassWord
            // 
            this.timerOpenEyeForPassWord.Interval = 1000;
            this.timerOpenEyeForPassWord.Tick += new System.EventHandler(this.timerOpenEyeForPassWord_Tick);
            // 
            // timerOpenEyeForConfirm
            // 
            this.timerOpenEyeForConfirm.Interval = 1000;
            this.timerOpenEyeForConfirm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerHoverGg
            // 
            this.timerHoverGg.Interval = 1;
            this.timerHoverGg.Tick += new System.EventHandler(this.timerHoverGg_Tick);
            // 
            // timerLeaveGG
            // 
            this.timerLeaveGG.Interval = 1;
            this.timerLeaveGG.Tick += new System.EventHandler(this.timerLeaveGG_Tick);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "Username";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtUsername.Location = new System.Drawing.Point(75, 92);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(310, 47);
            this.txtUsername.TabIndex = 29;
            this.txtUsername.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUsername.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
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
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(310, 47);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // picEyeOfPass
            // 
            this.picEyeOfPass.FillColor = System.Drawing.Color.Black;
            this.picEyeOfPass.Image = global::App_Library.Properties.Resources.eye_slash;
            this.picEyeOfPass.ImageRotate = 0F;
            this.picEyeOfPass.Location = new System.Drawing.Point(270, 10);
            this.picEyeOfPass.Name = "picEyeOfPass";
            this.picEyeOfPass.Size = new System.Drawing.Size(32, 29);
            this.picEyeOfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeOfPass.TabIndex = 7;
            this.picEyeOfPass.TabStop = false;
            this.picEyeOfPass.Click += new System.EventHandler(this.picEyeOfPass_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.picEyeOfPass);
            this.guna2Panel1.Controls.Add(this.txtPassword);
            this.guna2Panel1.Location = new System.Drawing.Point(78, 172);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(310, 47);
            this.guna2Panel1.TabIndex = 31;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.picEyeOfConfirm);
            this.guna2Panel3.Controls.Add(this.txtConfirm);
            this.guna2Panel3.Location = new System.Drawing.Point(78, 249);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(310, 47);
            this.guna2Panel3.TabIndex = 33;
            // 
            // picEyeOfConfirm
            // 
            this.picEyeOfConfirm.FillColor = System.Drawing.Color.Black;
            this.picEyeOfConfirm.Image = global::App_Library.Properties.Resources.eye_slash;
            this.picEyeOfConfirm.ImageRotate = 0F;
            this.picEyeOfConfirm.Location = new System.Drawing.Point(270, 10);
            this.picEyeOfConfirm.Name = "picEyeOfConfirm";
            this.picEyeOfConfirm.Size = new System.Drawing.Size(32, 29);
            this.picEyeOfConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeOfConfirm.TabIndex = 7;
            this.picEyeOfConfirm.TabStop = false;
            this.picEyeOfConfirm.Click += new System.EventHandler(this.picEyeOfConfirm_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderColor = System.Drawing.Color.DarkGray;
            this.txtConfirm.BorderRadius = 10;
            this.txtConfirm.BorderThickness = 2;
            this.txtConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirm.DefaultText = "Confirm";
            this.txtConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirm.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtConfirm.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirm.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtConfirm.Location = new System.Drawing.Point(0, 0);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '\0';
            this.txtConfirm.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtConfirm.PlaceholderText = "";
            this.txtConfirm.SelectedText = "";
            this.txtConfirm.Size = new System.Drawing.Size(310, 47);
            this.txtConfirm.TabIndex = 30;
            this.txtConfirm.Click += new System.EventHandler(this.txtConfirm_Click);
            this.txtConfirm.MouseLeave += new System.EventHandler(this.txtConfirm_MouseLeave);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 475);
            this.Controls.Add(this.pnMainContentLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUpForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.pnMainContentLogin.ResumeLayout(false);
            this.pnMainContentLogin.PerformLayout();
            this.btnSignInGG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfPass)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfConfirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMainContentLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lbLogin1;
        private System.Windows.Forms.Label lbLogin2;
        private System.Windows.Forms.Label lbOr;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnSignInGG;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnLogin;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
        private System.Windows.Forms.Timer timerOpenEyeForPassWord;
        private System.Windows.Forms.Timer timerOpenEyeForConfirm;
        private Guna.UI2.WinForms.Guna2Button MessegeEmail;
        private Guna.UI2.WinForms.Guna2Button MessegeConfirm;
        private Guna.UI2.WinForms.Guna2Button MessegePassword;
        private Guna.UI2.WinForms.Guna2Button MessegeUsername;
        internal Guna.UI2.WinForms.Guna2Panel btnSignInGG;
        private System.Windows.Forms.PictureBox picGG;
        private System.Windows.Forms.Label lbGG;
        private System.Windows.Forms.Timer timerHoverGg;
        private System.Windows.Forms.Timer timerLeaveGG;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picEyeOfPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox picEyeOfConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirm;
    }
}