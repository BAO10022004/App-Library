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
            this.lbOr = new System.Windows.Forms.Label();
            this.gnPanelConfirmPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.gnPanelUsername = new Guna.UI2.WinForms.Guna2Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.gnPanelPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.gnPanelEmail = new Guna.UI2.WinForms.Guna2Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignInGG = new System.Windows.Forms.Button();
            this.lbLogin1 = new System.Windows.Forms.Label();
            this.lbLogin2 = new System.Windows.Forms.Label();
            this.gnBtnSignInGG = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnBtnLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnMainContentLogin.SuspendLayout();
            this.gnPanelConfirmPassword.SuspendLayout();
            this.gnPanelUsername.SuspendLayout();
            this.gnPanelPassword.SuspendLayout();
            this.gnPanelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.White;
            this.pnMainContentLogin.Controls.Add(this.lbOr);
            this.pnMainContentLogin.Controls.Add(this.gnPanelConfirmPassword);
            this.pnMainContentLogin.Controls.Add(this.gnPanelUsername);
            this.pnMainContentLogin.Controls.Add(this.gnPanelPassword);
            this.pnMainContentLogin.Controls.Add(this.gnPanelEmail);
            this.pnMainContentLogin.Controls.Add(this.btnSignUp);
            this.pnMainContentLogin.Controls.Add(this.btnSignInGG);
            this.pnMainContentLogin.Controls.Add(this.lbLogin1);
            this.pnMainContentLogin.Controls.Add(this.lbLogin2);
            this.pnMainContentLogin.Location = new System.Drawing.Point(0, 0);
            this.pnMainContentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(460, 475);
            this.pnMainContentLogin.TabIndex = 5;
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOr.ForeColor = System.Drawing.Color.Black;
            this.lbOr.Location = new System.Drawing.Point(219, 346);
            this.lbOr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(21, 17);
            this.lbOr.TabIndex = 18;
            this.lbOr.Text = "or";
            this.lbOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gnPanelConfirmPassword
            // 
            this.gnPanelConfirmPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelConfirmPassword.BorderRadius = 10;
            this.gnPanelConfirmPassword.BorderThickness = 2;
            this.gnPanelConfirmPassword.Controls.Add(this.txbConfirmPassword);
            this.gnPanelConfirmPassword.Location = new System.Drawing.Point(75, 229);
            this.gnPanelConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelConfirmPassword.Name = "gnPanelConfirmPassword";
            this.gnPanelConfirmPassword.Size = new System.Drawing.Size(310, 47);
            this.gnPanelConfirmPassword.TabIndex = 17;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbConfirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbConfirmPassword.Location = new System.Drawing.Point(25, 15);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(260, 17);
            this.txbConfirmPassword.TabIndex = 4;
            this.txbConfirmPassword.Text = "Confirm Password";
            this.txbConfirmPassword.Click += new System.EventHandler(this.txbConfirmPassword_Click);
            this.txbConfirmPassword.Leave += new System.EventHandler(this.txbConfirmPassword_Leave);
            // 
            // gnPanelUsername
            // 
            this.gnPanelUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelUsername.BorderRadius = 10;
            this.gnPanelUsername.BorderThickness = 2;
            this.gnPanelUsername.Controls.Add(this.txbUsername);
            this.gnPanelUsername.Location = new System.Drawing.Point(75, 105);
            this.gnPanelUsername.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelUsername.Name = "gnPanelUsername";
            this.gnPanelUsername.Size = new System.Drawing.Size(310, 47);
            this.gnPanelUsername.TabIndex = 15;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.White;
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
            // 
            // gnPanelPassword
            // 
            this.gnPanelPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelPassword.BorderRadius = 10;
            this.gnPanelPassword.BorderThickness = 2;
            this.gnPanelPassword.Controls.Add(this.txbPassword);
            this.gnPanelPassword.Location = new System.Drawing.Point(75, 167);
            this.gnPanelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelPassword.Name = "gnPanelPassword";
            this.gnPanelPassword.Size = new System.Drawing.Size(310, 47);
            this.gnPanelPassword.TabIndex = 16;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(25, 15);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(260, 17);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "Password";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // gnPanelEmail
            // 
            this.gnPanelEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.gnPanelEmail.BorderRadius = 10;
            this.gnPanelEmail.BorderThickness = 2;
            this.gnPanelEmail.Controls.Add(this.txbEmail);
            this.gnPanelEmail.Location = new System.Drawing.Point(75, 43);
            this.gnPanelEmail.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelEmail.Name = "gnPanelEmail";
            this.gnPanelEmail.Size = new System.Drawing.Size(310, 47);
            this.gnPanelEmail.TabIndex = 14;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
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
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Blue;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignUp.Location = new System.Drawing.Point(75, 297);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(310, 47);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignInGG
            // 
            this.btnSignInGG.BackColor = System.Drawing.Color.Blue;
            this.btnSignInGG.FlatAppearance.BorderSize = 0;
            this.btnSignInGG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignInGG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignInGG.Location = new System.Drawing.Point(75, 365);
            this.btnSignInGG.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignInGG.Name = "btnSignInGG";
            this.btnSignInGG.Size = new System.Drawing.Size(310, 47);
            this.btnSignInGG.TabIndex = 12;
            this.btnSignInGG.Text = "Continue With Google";
            this.btnSignInGG.UseVisualStyleBackColor = false;
            this.btnSignInGG.Click += new System.EventHandler(this.btnSignInGG_Click);
            // 
            // lbLogin1
            // 
            this.lbLogin1.AutoSize = true;
            this.lbLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLogin1.ForeColor = System.Drawing.Color.Black;
            this.lbLogin1.Location = new System.Drawing.Point(75, 414);
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
            this.lbLogin2.Location = new System.Drawing.Point(252, 414);
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
            this.gnBtnSignInGG.TargetControl = this.btnSignInGG;
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
            this.gnPanelConfirmPassword.ResumeLayout(false);
            this.gnPanelConfirmPassword.PerformLayout();
            this.gnPanelUsername.ResumeLayout(false);
            this.gnPanelUsername.PerformLayout();
            this.gnPanelPassword.ResumeLayout(false);
            this.gnPanelPassword.PerformLayout();
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
        private System.Windows.Forms.Button btnSignInGG;
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
    }
}