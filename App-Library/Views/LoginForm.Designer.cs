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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gnBtnLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnTxbUserName = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnTxbPassword = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnPanelInputPassword = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnpnContainTxbPassword = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnIconGif = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnIconForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnebeginframe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerClickButonLogin = new System.Windows.Forms.Timer(this.components);
            this.pnMainContentLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCreateAccount = new System.Windows.Forms.Label();
            this.pnContainTxbPassword = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnContainTxbUserName = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMainContentLogin.SuspendLayout();
            this.pnContainTxbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnContainTxbUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnBtnLogin
            // 
            this.gnBtnLogin.BorderRadius = 40;
            // 
            // gnTxbUserName
            // 
            this.gnTxbUserName.BorderRadius = 30;
            // 
            // gnTxbPassword
            // 
            this.gnTxbPassword.BorderRadius = 30;
            // 
            // gnPanelInputPassword
            // 
            this.gnPanelInputPassword.BorderRadius = 30;
            // 
            // gnpnContainTxbPassword
            // 
            this.gnpnContainTxbPassword.BorderRadius = 30;
            // 
            // gnIconGif
            // 
            this.gnIconGif.BorderRadius = 100;
            // 
            // gnIconForm
            // 
            this.gnIconForm.BorderRadius = 110;
            // 
            // gnebeginframe
            // 
            this.gnebeginframe.BorderRadius = 200;
            // 
            // timerClickButonLogin
            // 
            this.timerClickButonLogin.Interval = 10;
            this.timerClickButonLogin.Tick += new System.EventHandler(this.timerClickButonLogin_Tick);
            // 
            // pnMainContentLogin
            // 
            this.pnMainContentLogin.BackColor = System.Drawing.Color.White;
            this.pnMainContentLogin.Controls.Add(this.panel2);
            this.pnMainContentLogin.Controls.Add(this.lbCreateAccount);
            this.pnMainContentLogin.Controls.Add(this.pnContainTxbPassword);
            this.pnMainContentLogin.Controls.Add(this.pictureBox3);
            this.pnMainContentLogin.Controls.Add(this.pnContainTxbUserName);
            this.pnMainContentLogin.Controls.Add(this.btnLogin);
            this.pnMainContentLogin.Controls.Add(this.lbForgotPassword);
            this.pnMainContentLogin.Controls.Add(this.label3);
            this.pnMainContentLogin.Controls.Add(this.label2);
            this.pnMainContentLogin.Location = new System.Drawing.Point(-8, -32);
            this.pnMainContentLogin.Name = "pnMainContentLogin";
            this.pnMainContentLogin.Size = new System.Drawing.Size(606, 812);
            this.pnMainContentLogin.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(660, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 529);
            this.panel2.TabIndex = 4;
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.lbCreateAccount.Location = new System.Drawing.Point(362, 427);
            this.lbCreateAccount.Name = "lbCreateAccount";
            this.lbCreateAccount.Size = new System.Drawing.Size(139, 20);
            this.lbCreateAccount.TabIndex = 8;
            this.lbCreateAccount.Text = "Create Account";
            // 
            // pnContainTxbPassword
            // 
            this.pnContainTxbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnContainTxbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainTxbPassword.Controls.Add(this.txbPassword);
            this.pnContainTxbPassword.Location = new System.Drawing.Point(214, 354);
            this.pnContainTxbPassword.Name = "pnContainTxbPassword";
            this.pnContainTxbPassword.Size = new System.Drawing.Size(359, 42);
            this.pnContainTxbPassword.TabIndex = 11;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassword.Location = new System.Drawing.Point(16, 3);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(313, 34);
            this.txbPassword.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::App_Library.Properties.Resources.IconLogin;
            this.pictureBox3.Location = new System.Drawing.Point(196, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pnContainTxbUserName
            // 
            this.pnContainTxbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnContainTxbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainTxbUserName.Controls.Add(this.txbUserName);
            this.pnContainTxbUserName.Location = new System.Drawing.Point(214, 268);
            this.pnContainTxbUserName.Name = "pnContainTxbUserName";
            this.pnContainTxbUserName.Size = new System.Drawing.Size(359, 54);
            this.pnContainTxbUserName.TabIndex = 10;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUserName.Location = new System.Drawing.Point(16, 9);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(298, 34);
            this.txbUserName.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(243, 497);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 60);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbForgotPassword.Location = new System.Drawing.Point(89, 427);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(157, 20);
            this.lbForgotPassword.TabIndex = 7;
            this.lbForgotPassword.Text = "Forgot Password ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(50, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name: ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 574);
            this.Controls.Add(this.pnMainContentLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnMainContentLogin.ResumeLayout(false);
            this.pnMainContentLogin.PerformLayout();
            this.pnContainTxbPassword.ResumeLayout(false);
            this.pnContainTxbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnContainTxbUserName.ResumeLayout(false);
            this.pnContainTxbUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse gnBtnLogin;
        private Guna.UI2.WinForms.Guna2Elipse gnTxbUserName;
        private Guna.UI2.WinForms.Guna2Elipse gnTxbPassword;
        private Guna.UI2.WinForms.Guna2Elipse gnPanelInputPassword;
        private Guna.UI2.WinForms.Guna2Elipse gnpnContainTxbPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse gnIconGif;
        private Guna.UI2.WinForms.Guna2Elipse gnIconForm;
        private Guna.UI2.WinForms.Guna2Elipse gnebeginframe;
        private Timer timerClickButonLogin;
        private Panel pnMainContentLogin;
        private Panel panel2;
        private Label lbCreateAccount;
        private Panel pnContainTxbPassword;
        private TextBox txbPassword;
        private PictureBox pictureBox3;
        private Panel pnContainTxbUserName;
        private TextBox txbUserName;
        private Button btnLogin;
        private Label lbForgotPassword;
        private Label label3;
        private Label label2;
    }
}