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
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.pnMainContentLogin = new System.Windows.Forms.Panel();
            this.lbOr = new System.Windows.Forms.Label();
            this.gnPanelPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.gnPanelLogIn = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignInGG = new System.Windows.Forms.Button();
            this.lbCreateAccount = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.gnBtnSignInGG = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMainContentLogin.SuspendLayout();
            this.gnPanelPassword.SuspendLayout();
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
            this.btnLogIn.BackColor = System.Drawing.Color.Blue;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.Location = new System.Drawing.Point(85, 342);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(410, 55);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.White;
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.txbUserName.Location = new System.Drawing.Point(30, 17);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(350, 21);
            this.txbUserName.TabIndex = 4;
            this.txbUserName.Text = "Username";
            this.txbUserName.Click += new System.EventHandler(this.txbUserName_Click);
            this.txbUserName.Leave += new System.EventHandler(this.txbUserName_Leave);
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.White;
            this.pnMainContentLogin.Controls.Add(this.lbOr);
            this.pnMainContentLogin.Controls.Add(this.gnPanelPassword);
            this.pnMainContentLogin.Controls.Add(this.gnPanelLogIn);
            this.pnMainContentLogin.Controls.Add(this.btnLogIn);
            this.pnMainContentLogin.Controls.Add(this.btnSignInGG);
            this.pnMainContentLogin.Controls.Add(this.lbCreateAccount);
            this.pnMainContentLogin.Controls.Add(this.lbForgotPassword);
            this.pnMainContentLogin.Location = new System.Drawing.Point(0, 0);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(580, 620);
            this.pnMainContentLogin.TabIndex = 4;
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOr.ForeColor = System.Drawing.Color.Black;
            this.lbOr.Location = new System.Drawing.Point(278, 402);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(24, 20);
            this.lbOr.TabIndex = 16;
            this.lbOr.Text = "or";
            // 
            // gnPanelPassword
            // 
            this.gnPanelPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelPassword.BorderRadius = 10;
            this.gnPanelPassword.BorderThickness = 2;
            this.gnPanelPassword.Controls.Add(this.txbPassword);
            this.gnPanelPassword.Location = new System.Drawing.Point(85, 186);
            this.gnPanelPassword.Name = "gnPanelPassword";
            this.gnPanelPassword.Size = new System.Drawing.Size(410, 56);
            this.gnPanelPassword.TabIndex = 15;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(30, 17);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(350, 21);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "Password";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // gnPanelLogIn
            // 
            this.gnPanelLogIn.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelLogIn.BorderRadius = 10;
            this.gnPanelLogIn.BorderThickness = 2;
            this.gnPanelLogIn.Controls.Add(this.txbUserName);
            this.gnPanelLogIn.Location = new System.Drawing.Point(85, 110);
            this.gnPanelLogIn.Name = "gnPanelLogIn";
            this.gnPanelLogIn.Size = new System.Drawing.Size(410, 56);
            this.gnPanelLogIn.TabIndex = 14;
            // 
            // btnSignInGG
            // 
            this.btnSignInGG.BackColor = System.Drawing.Color.Blue;
            this.btnSignInGG.FlatAppearance.BorderSize = 0;
            this.btnSignInGG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignInGG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignInGG.Location = new System.Drawing.Point(85, 427);
            this.btnSignInGG.Name = "btnSignInGG";
            this.btnSignInGG.Size = new System.Drawing.Size(410, 55);
            this.btnSignInGG.TabIndex = 12;
            this.btnSignInGG.Text = "Continue With Google";
            this.btnSignInGG.UseVisualStyleBackColor = false;
            this.btnSignInGG.Click += new System.EventHandler(this.btnSignInGG_Click);
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.lbCreateAccount.Location = new System.Drawing.Point(85, 282);
            this.lbCreateAccount.Name = "lbCreateAccount";
            this.lbCreateAccount.Size = new System.Drawing.Size(139, 20);
            this.lbCreateAccount.TabIndex = 8;
            this.lbCreateAccount.Text = "Create Account";
            this.lbCreateAccount.Click += new System.EventHandler(this.lbCreateAccount_Click);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbForgotPassword.Location = new System.Drawing.Point(354, 282);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(141, 20);
            this.lbForgotPassword.TabIndex = 7;
            this.lbForgotPassword.Text = "Forgot Password ";
            // 
            // gnBtnSignInGG
            // 
            this.gnBtnSignInGG.BorderRadius = 30;
            this.gnBtnSignInGG.TargetControl = this.btnSignInGG;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 620);
            this.Controls.Add(this.pnMainContentLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnMainContentLogin.ResumeLayout(false);
            this.pnMainContentLogin.PerformLayout();
            this.gnPanelPassword.ResumeLayout(false);
            this.gnPanelPassword.PerformLayout();
            this.gnPanelLogIn.ResumeLayout(false);
            this.gnPanelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse gnBtnLogin;
        private Panel pnMainContentLogin;
        private Label lbCreateAccount;
        private TextBox txbUserName;
        private Label lbForgotPassword;
        private Button btnSignInGG;
        private Button btnLogIn;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnSignInGG;
        private Guna.UI2.WinForms.Guna2Panel gnPanelLogIn;
        private Guna.UI2.WinForms.Guna2Panel gnPanelPassword;
        private TextBox txbPassword;
        private Label lbOr;
    }
}