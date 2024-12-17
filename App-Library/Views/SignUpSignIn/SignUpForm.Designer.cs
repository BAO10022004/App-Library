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
            this.btnSignInGG = new Guna.UI2.WinForms.Guna2Panel();
            this.picGG = new System.Windows.Forms.PictureBox();
            this.lbGG = new System.Windows.Forms.Label();
            this.MessegeConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.MessegePassword = new Guna.UI2.WinForms.Guna2Button();
            this.MessegeUsername = new Guna.UI2.WinForms.Guna2Button();
            this.MessegeEmail = new Guna.UI2.WinForms.Guna2Button();
            this.lbOr = new System.Windows.Forms.Label();
            this.gnPanelConfirmPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.picEyeOfConfirm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.gnPanelUsername = new Guna.UI2.WinForms.Guna2Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.gnPanelPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.picEyeOfPass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.gnPanelEmail = new Guna.UI2.WinForms.Guna2Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
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
            this.pnMainContentLogin.SuspendLayout();
            this.btnSignInGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).BeginInit();
            this.gnPanelConfirmPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfConfirm)).BeginInit();
            this.gnPanelUsername.SuspendLayout();
            this.gnPanelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfPass)).BeginInit();
            this.gnPanelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.Black;
            this.pnMainContentLogin.Controls.Add(this.btnSignInGG);
            this.pnMainContentLogin.Controls.Add(this.MessegeConfirm);
            this.pnMainContentLogin.Controls.Add(this.MessegePassword);
            this.pnMainContentLogin.Controls.Add(this.MessegeUsername);
            this.pnMainContentLogin.Controls.Add(this.MessegeEmail);
            this.pnMainContentLogin.Controls.Add(this.lbOr);
            this.pnMainContentLogin.Controls.Add(this.gnPanelConfirmPassword);
            this.pnMainContentLogin.Controls.Add(this.gnPanelUsername);
            this.pnMainContentLogin.Controls.Add(this.gnPanelPassword);
            this.pnMainContentLogin.Controls.Add(this.gnPanelEmail);
            this.pnMainContentLogin.Controls.Add(this.btnSignUp);
            this.pnMainContentLogin.Controls.Add(this.lbLogin1);
            this.pnMainContentLogin.Controls.Add(this.lbLogin2);
            this.pnMainContentLogin.Location = new System.Drawing.Point(0, 0);
            this.pnMainContentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(460, 475);
            this.pnMainContentLogin.TabIndex = 5;
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
            this.MessegeConfirm.FillColor = System.Drawing.Color.Black;
            this.MessegeConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeConfirm.ForeColor = System.Drawing.Color.Red;
            this.MessegeConfirm.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeConfirm.Location = new System.Drawing.Point(75, 296);
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
            this.MessegePassword.FillColor = System.Drawing.Color.Black;
            this.MessegePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegePassword.ForeColor = System.Drawing.Color.Red;
            this.MessegePassword.Image = global::App_Library.Properties.Resources.mark;
            this.MessegePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegePassword.Location = new System.Drawing.Point(75, 225);
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
            this.MessegeUsername.FillColor = System.Drawing.Color.Black;
            this.MessegeUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeUsername.ForeColor = System.Drawing.Color.Red;
            this.MessegeUsername.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeUsername.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeUsername.Location = new System.Drawing.Point(78, 155);
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
            this.MessegeEmail.FillColor = System.Drawing.Color.Black;
            this.MessegeEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessegeEmail.ForeColor = System.Drawing.Color.Red;
            this.MessegeEmail.Image = global::App_Library.Properties.Resources.mark;
            this.MessegeEmail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessegeEmail.Location = new System.Drawing.Point(75, 79);
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
            // gnPanelConfirmPassword
            // 
            this.gnPanelConfirmPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelConfirmPassword.BorderRadius = 10;
            this.gnPanelConfirmPassword.BorderThickness = 2;
            this.gnPanelConfirmPassword.Controls.Add(this.picEyeOfConfirm);
            this.gnPanelConfirmPassword.Controls.Add(this.txbConfirmPassword);
            this.gnPanelConfirmPassword.Location = new System.Drawing.Point(75, 244);
            this.gnPanelConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelConfirmPassword.Name = "gnPanelConfirmPassword";
            this.gnPanelConfirmPassword.Size = new System.Drawing.Size(310, 47);
            this.gnPanelConfirmPassword.TabIndex = 17;
            this.gnPanelConfirmPassword.MouseLeave += new System.EventHandler(this.gnPanelEmail_MouseLeave);
            this.gnPanelConfirmPassword.MouseHover += new System.EventHandler(this.txbEmail_MouseHover);
            // 
            // picEyeOfConfirm
            // 
            this.picEyeOfConfirm.Image = global::App_Library.Properties.Resources.eye_slash;
            this.picEyeOfConfirm.ImageRotate = 0F;
            this.picEyeOfConfirm.Location = new System.Drawing.Point(270, 10);
            this.picEyeOfConfirm.Name = "picEyeOfConfirm";
            this.picEyeOfConfirm.Size = new System.Drawing.Size(32, 29);
            this.picEyeOfConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeOfConfirm.TabIndex = 8;
            this.picEyeOfConfirm.TabStop = false;
            this.picEyeOfConfirm.Click += new System.EventHandler(this.picEyeOfConfirm_Click);
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BackColor = System.Drawing.Color.Black;
            this.txbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbConfirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbConfirmPassword.Location = new System.Drawing.Point(25, 15);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(240, 17);
            this.txbConfirmPassword.TabIndex = 4;
            this.txbConfirmPassword.Text = "Confirm Password";
            this.txbConfirmPassword.Click += new System.EventHandler(this.txbConfirmPassword_Click);
            this.txbConfirmPassword.Leave += new System.EventHandler(this.txbConfirmPassword_Leave);
            this.txbConfirmPassword.MouseHover += new System.EventHandler(this.txbEmail_MouseHover_1);
            // 
            // gnPanelUsername
            // 
            this.gnPanelUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelUsername.BorderRadius = 10;
            this.gnPanelUsername.BorderThickness = 2;
            this.gnPanelUsername.Controls.Add(this.txbUsername);
            this.gnPanelUsername.Location = new System.Drawing.Point(75, 103);
            this.gnPanelUsername.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelUsername.Name = "gnPanelUsername";
            this.gnPanelUsername.Size = new System.Drawing.Size(310, 47);
            this.gnPanelUsername.TabIndex = 15;
            this.gnPanelUsername.MouseLeave += new System.EventHandler(this.gnPanelEmail_MouseLeave);
            this.gnPanelUsername.MouseHover += new System.EventHandler(this.txbEmail_MouseHover);
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.Black;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txbUsername.Location = new System.Drawing.Point(25, 15);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(260, 17);
            this.txbUsername.TabIndex = 4;
            this.txbUsername.Text = "Username";
            this.txbUsername.Click += new System.EventHandler(this.txbUsername_Click);
            this.txbUsername.Leave += new System.EventHandler(this.txbUsername_Leave);
            this.txbUsername.MouseHover += new System.EventHandler(this.txbEmail_MouseHover_1);
            // 
            // gnPanelPassword
            // 
            this.gnPanelPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelPassword.BorderRadius = 10;
            this.gnPanelPassword.BorderThickness = 2;
            this.gnPanelPassword.Controls.Add(this.picEyeOfPass);
            this.gnPanelPassword.Controls.Add(this.txbPassword);
            this.gnPanelPassword.Location = new System.Drawing.Point(75, 173);
            this.gnPanelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelPassword.Name = "gnPanelPassword";
            this.gnPanelPassword.Size = new System.Drawing.Size(310, 47);
            this.gnPanelPassword.TabIndex = 16;
            this.gnPanelPassword.MouseLeave += new System.EventHandler(this.gnPanelEmail_MouseLeave);
            this.gnPanelPassword.MouseHover += new System.EventHandler(this.txbEmail_MouseHover);
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
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.Black;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(25, 15);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(240, 17);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "Password";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            this.txbPassword.MouseHover += new System.EventHandler(this.txbEmail_MouseHover_1);
            // 
            // gnPanelEmail
            // 
            this.gnPanelEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelEmail.BorderRadius = 10;
            this.gnPanelEmail.BorderThickness = 2;
            this.gnPanelEmail.Controls.Add(this.txbEmail);
            this.gnPanelEmail.Location = new System.Drawing.Point(75, 27);
            this.gnPanelEmail.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelEmail.Name = "gnPanelEmail";
            this.gnPanelEmail.Size = new System.Drawing.Size(310, 47);
            this.gnPanelEmail.TabIndex = 14;
            this.gnPanelEmail.MouseLeave += new System.EventHandler(this.gnPanelEmail_MouseLeave);
            this.gnPanelEmail.MouseHover += new System.EventHandler(this.txbEmail_MouseHover);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.Black;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txbEmail.Location = new System.Drawing.Point(25, 15);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(260, 17);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.Text = "Email";
            this.txbEmail.Click += new System.EventHandler(this.txbEmail_Click);
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            this.txbEmail.MouseHover += new System.EventHandler(this.txbEmail_MouseHover_1);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Aqua;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btnSignUp.ForeColor = System.Drawing.Color.Teal;
            this.btnSignUp.Location = new System.Drawing.Point(75, 322);
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
            this.gnPanelConfirmPassword.ResumeLayout(false);
            this.gnPanelConfirmPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfConfirm)).EndInit();
            this.gnPanelUsername.ResumeLayout(false);
            this.gnPanelUsername.PerformLayout();
            this.gnPanelPassword.ResumeLayout(false);
            this.gnPanelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOfPass)).EndInit();
            this.gnPanelEmail.ResumeLayout(false);
            this.gnPanelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMainContentLogin;
        private Guna.UI2.WinForms.Guna2Panel gnPanelUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private Guna.UI2.WinForms.Guna2Panel gnPanelEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lbLogin1;
        private Guna.UI2.WinForms.Guna2Panel gnPanelConfirmPassword;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private Guna.UI2.WinForms.Guna2Panel gnPanelPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbLogin2;
        private System.Windows.Forms.Label lbOr;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnSignInGG;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnLogin;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
        private Guna.UI2.WinForms.Guna2PictureBox picEyeOfPass;
        private Guna.UI2.WinForms.Guna2PictureBox picEyeOfConfirm;
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
    }
}