using App_Library.Views.ToolerForm;
using System.Windows.Forms;

namespace App_Library.Views
{
    partial class SplashForm : FormHelper
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
            this.pnSubLogin = new System.Windows.Forms.Panel();
            this.pnFrameOption = new System.Windows.Forms.Panel();
            this.pnContainButtonSignUp = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnContainButtonSignIn = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnLoginSignupContent = new System.Windows.Forms.Panel();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerClickButtonSignUp = new System.Windows.Forms.Timer(this.components);
            this.gneContentLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerClickButonLogin = new System.Windows.Forms.Timer(this.components);
            this.gneBtnSingIn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gneBtnSingUp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerOpenMainForm = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnSubLogin.SuspendLayout();
            this.pnFrameOption.SuspendLayout();
            this.pnContainButtonSignUp.SuspendLayout();
            this.pnContainButtonSignIn.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSubLogin
            // 
            this.pnSubLogin.BackColor = System.Drawing.Color.Cyan;
            this.pnSubLogin.Controls.Add(this.pnFrameOption);
            this.pnSubLogin.Controls.Add(this.lbWellcome);
            this.pnSubLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubLogin.Location = new System.Drawing.Point(0, 40);
            this.pnSubLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnSubLogin.Name = "pnSubLogin";
            this.pnSubLogin.Size = new System.Drawing.Size(460, 600);
            this.pnSubLogin.TabIndex = 5;
            // 
            // pnFrameOption
            // 
            this.pnFrameOption.BackColor = System.Drawing.Color.Black;
            this.pnFrameOption.Controls.Add(this.pnContainButtonSignUp);
            this.pnFrameOption.Controls.Add(this.pnContainButtonSignIn);
            this.pnFrameOption.Controls.Add(this.pnLoginSignupContent);
            this.pnFrameOption.Location = new System.Drawing.Point(0, 385);
            this.pnFrameOption.Margin = new System.Windows.Forms.Padding(2);
            this.pnFrameOption.Name = "pnFrameOption";
            this.pnFrameOption.Size = new System.Drawing.Size(460, 700);
            this.pnFrameOption.TabIndex = 3;
            // 
            // pnContainButtonSignUp
            // 
            this.pnContainButtonSignUp.BorderColor = System.Drawing.Color.Aqua;
            this.pnContainButtonSignUp.BorderRadius = 14;
            this.pnContainButtonSignUp.BorderThickness = 2;
            this.pnContainButtonSignUp.Controls.Add(this.btnSignUp);
            this.pnContainButtonSignUp.Location = new System.Drawing.Point(118, 132);
            this.pnContainButtonSignUp.Name = "pnContainButtonSignUp";
            this.pnContainButtonSignUp.Padding = new System.Windows.Forms.Padding(10);
            this.pnContainButtonSignUp.Size = new System.Drawing.Size(237, 63);
            this.pnContainButtonSignUp.TabIndex = 5;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Black;
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Aqua;
            this.btnSignUp.Location = new System.Drawing.Point(10, 10);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(217, 43);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pnContainButtonSignIn
            // 
            this.pnContainButtonSignIn.BorderColor = System.Drawing.Color.Aqua;
            this.pnContainButtonSignIn.BorderRadius = 14;
            this.pnContainButtonSignIn.BorderThickness = 2;
            this.pnContainButtonSignIn.Controls.Add(this.btnLogIn);
            this.pnContainButtonSignIn.Location = new System.Drawing.Point(118, 34);
            this.pnContainButtonSignIn.Name = "pnContainButtonSignIn";
            this.pnContainButtonSignIn.Padding = new System.Windows.Forms.Padding(10);
            this.pnContainButtonSignIn.Size = new System.Drawing.Size(237, 63);
            this.pnContainButtonSignIn.TabIndex = 4;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Black;
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Aqua;
            this.btnLogIn.Location = new System.Drawing.Point(10, 10);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(217, 43);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "SIGN IN ";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pnLoginSignupContent
            // 
            this.pnLoginSignupContent.Location = new System.Drawing.Point(0, 200);
            this.pnLoginSignupContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnLoginSignupContent.Name = "pnLoginSignupContent";
            this.pnLoginSignupContent.Size = new System.Drawing.Size(460, 475);
            this.pnLoginSignupContent.TabIndex = 2;
            // 
            // lbWellcome
            // 
            this.lbWellcome.BackColor = System.Drawing.Color.Cyan;
            this.lbWellcome.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Bold);
            this.lbWellcome.ForeColor = System.Drawing.Color.Teal;
            this.lbWellcome.Location = new System.Drawing.Point(0, 152);
            this.lbWellcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(458, 65);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "WELCOME BACK";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Cyan;
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.btnMaximize);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(460, 40);
            this.pnHeader.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(419, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 22);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = global::App_Library.Properties.Resources.calculate;
            this.btnMinimize.Location = new System.Drawing.Point(359, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Image = global::App_Library.Properties.Resources.scale__1_;
            this.btnMaximize.Location = new System.Drawing.Point(394, 10);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Library.Properties.Resources.open_book;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "READ BOOK APP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClickButtonSignUp
            // 
            this.timerClickButtonSignUp.Interval = 5;
            this.timerClickButtonSignUp.Tick += new System.EventHandler(this.timerSignUp_Tick);
            // 
            // gneContentLogin
            // 
            this.gneContentLogin.BorderRadius = 20;
            this.gneContentLogin.TargetControl = this.pnFrameOption;
            // 
            // timerClickButonLogin
            // 
            this.timerClickButonLogin.Interval = 1;
            this.timerClickButonLogin.Tick += new System.EventHandler(this.timerClickButonLogin_Tick);
            // 
            // gneBtnSingIn
            // 
            this.gneBtnSingIn.BorderRadius = 20;
            this.gneBtnSingIn.TargetControl = this.btnLogIn;
            // 
            // gneBtnSingUp
            // 
            this.gneBtnSingUp.BorderRadius = 40;
            this.gneBtnSingUp.TargetControl = this.btnSignUp;
            // 
            // timerOpenMainForm
            // 
            this.timerOpenMainForm.Interval = 10;
            this.timerOpenMainForm.Tick += new System.EventHandler(this.timerOpenMainForm_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(460, 640);
            this.Controls.Add(this.pnSubLogin);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.pnSubLogin.ResumeLayout(false);
            this.pnFrameOption.ResumeLayout(false);
            this.pnContainButtonSignUp.ResumeLayout(false);
            this.pnContainButtonSignIn.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnSubLogin;
        public Panel pnFrameOption;
        private Panel pnLoginSignupContent;
        private Button btnSignUp;
        private Button btnLogIn;
        private Label lbWellcome;
        public Panel pnHeader;
        private PictureBox btnMinimize;
        private PictureBox btnMaximize;
        private PictureBox pictureBox1;
        private Label label1;
        private Timer timerClickButtonSignUp;
        private Guna.UI2.WinForms.Guna2Elipse gneContentLogin;
        private Timer timerClickButonLogin;
        private Guna.UI2.WinForms.Guna2Elipse gneBtnSingIn;
        private Guna.UI2.WinForms.Guna2Elipse gneBtnSingUp;
        private Timer timerOpenMainForm;
        private Guna.UI2.WinForms.Guna2Panel pnContainButtonSignIn;
        private Guna.UI2.WinForms.Guna2Panel pnContainButtonSignUp;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnClose;

        public Panel PnSubLogin { get => pnSubLogin; set => pnSubLogin = value; }
    }
}