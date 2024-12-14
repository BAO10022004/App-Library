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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnMainContentLogin = new System.Windows.Forms.Panel();
            this.btnSignInGG = new Guna.UI2.WinForms.Guna2Panel();
            this.picGG = new System.Windows.Forms.PictureBox();
            this.lbGG = new System.Windows.Forms.Label();
            this.lbOr = new System.Windows.Forms.Label();
            this.gnPanelPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.picEye = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.gnPanelLogIn = new Guna.UI2.WinForms.Guna2Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbCreateAccount = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.gnBtnSignInGG = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerEyeOpen = new System.Windows.Forms.Timer(this.components);
            this.timerHoverGg = new System.Windows.Forms.Timer(this.components);
            this.timerLeaveGG = new System.Windows.Forms.Timer(this.components);
            this.pnMainContentLogin.SuspendLayout();
            this.btnSignInGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).BeginInit();
            this.gnPanelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.gnPanelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnBtnLogin
            // 
            this.gnBtnLogin.BorderRadius = 30;
            this.gnBtnLogin.TargetControl = this.btnLogIn;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Aqua;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Teal;
            this.btnLogIn.Location = new System.Drawing.Point(75, 260);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(310, 47);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.Black;
            this.pnMainContentLogin.Controls.Add(this.btnSignInGG);
            this.pnMainContentLogin.Controls.Add(this.lbOr);
            this.pnMainContentLogin.Controls.Add(this.gnPanelPassword);
            this.pnMainContentLogin.Controls.Add(this.gnPanelLogIn);
            this.pnMainContentLogin.Controls.Add(this.btnLogIn);
            this.pnMainContentLogin.Controls.Add(this.lbCreateAccount);
            this.pnMainContentLogin.Controls.Add(this.lbForgotPassword);
            this.pnMainContentLogin.Location = new System.Drawing.Point(0, 0);
            this.pnMainContentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(460, 475);
            this.pnMainContentLogin.TabIndex = 4;
            this.pnMainContentLogin.Click += new System.EventHandler(this.pnMainContentLogin_Click);
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
            // gnPanelPassword
            // 
            this.gnPanelPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelPassword.BorderRadius = 10;
            this.gnPanelPassword.BorderThickness = 2;
            this.gnPanelPassword.Controls.Add(this.picEye);
            this.gnPanelPassword.Controls.Add(this.txbPassword);
            this.gnPanelPassword.Location = new System.Drawing.Point(75, 162);
            this.gnPanelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelPassword.Name = "gnPanelPassword";
            this.gnPanelPassword.Size = new System.Drawing.Size(310, 47);
            this.gnPanelPassword.TabIndex = 15;
            this.gnPanelPassword.MouseLeave += new System.EventHandler(this.txbPassword_MouseLeave);
            this.gnPanelPassword.MouseHover += new System.EventHandler(this.txbPassword_MouseHover);
            // 
            // picEye
            // 
            this.picEye.FillColor = System.Drawing.Color.Black;
            this.picEye.ImageRotate = 0F;
            this.picEye.Location = new System.Drawing.Point(274, 10);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(32, 29);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 5;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.Black;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(25, 15);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(244, 19);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "Password";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown_1);
            this.txbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassword_KeyPress);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            this.txbPassword.MouseLeave += new System.EventHandler(this.txbPassword_MouseLeave);
            this.txbPassword.MouseHover += new System.EventHandler(this.txbPassword_MouseHover);
            this.txbPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbPassword_PreviewKeyDown);
            // 
            // gnPanelLogIn
            // 
            this.gnPanelLogIn.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelLogIn.BorderRadius = 10;
            this.gnPanelLogIn.BorderThickness = 2;
            this.gnPanelLogIn.Controls.Add(this.txbUserName);
            this.gnPanelLogIn.Location = new System.Drawing.Point(75, 100);
            this.gnPanelLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelLogIn.Name = "gnPanelLogIn";
            this.gnPanelLogIn.Size = new System.Drawing.Size(310, 47);
            this.gnPanelLogIn.TabIndex = 14;
            this.gnPanelLogIn.MouseLeave += new System.EventHandler(this.gnPanelLogIn_MouseLeave);
            this.gnPanelLogIn.MouseHover += new System.EventHandler(this.txbUserName_MouseHover);
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.Black;
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.txbUserName.Location = new System.Drawing.Point(25, 15);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(260, 19);
            this.txbUserName.TabIndex = 4;
            this.txbUserName.Text = "Username";
            this.txbUserName.Click += new System.EventHandler(this.txbUserName_Click);
            this.txbUserName.Leave += new System.EventHandler(this.txbUserName_Leave);
            this.txbUserName.MouseHover += new System.EventHandler(this.txbUserName_MouseHover);
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCreateAccount.ForeColor = System.Drawing.Color.Aqua;
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
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Aqua;
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
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnMainContentLogin.ResumeLayout(false);
            this.pnMainContentLogin.PerformLayout();
            this.btnSignInGG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).EndInit();
            this.gnPanelPassword.ResumeLayout(false);
            this.gnPanelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.gnPanelLogIn.ResumeLayout(false);
            this.gnPanelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse gnBtnLogin;
        private Panel pnMainContentLogin;
        private Label lbForgotPassword;
        private Button btnLogIn;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnSignInGG;
        private Guna.UI2.WinForms.Guna2Panel gnPanelPassword;
        private TextBox txbPassword;
        private Label lbOr;
        private Guna.UI2.WinForms.Guna2PictureBox picEye;
        private Timer timerEyeOpen;
        private Guna.UI2.WinForms.Guna2Panel gnPanelLogIn;
        private TextBox txbUserName;
        private Label lbCreateAccount;
        private Timer timerHoverGg;
        private Timer timerLeaveGG;
        private PictureBox picGG;
        private Label lbGG;
        internal Guna.UI2.WinForms.Guna2Panel btnSignInGG;
    }
}