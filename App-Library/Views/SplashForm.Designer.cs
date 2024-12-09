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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSubLogin = new System.Windows.Forms.Panel();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.pnFrameOption = new System.Windows.Forms.Panel();
            this.pnLoginSignupContent = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.gneContentLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerClickButonLogin = new System.Windows.Forms.Timer(this.components);
            this.gneBtnSingIn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gneBtnSingUp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerClickButtonSignUp = new System.Windows.Forms.Timer(this.components);
            this.timerOpenMainForm = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnSubLogin.SuspendLayout();
            this.pnFrameOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.btnMaximize);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(460, 40);
            this.pnHeader.TabIndex = 2;
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::App_Library.Properties.Resources.cross;
            this.btnClose.Location = new System.Drawing.Point(430, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Frame";
            // 
            // pnSubLogin
            // 
            this.pnSubLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnSubLogin.Controls.Add(this.guna2ProgressIndicator1);
            this.pnSubLogin.Controls.Add(this.pnFrameOption);
            this.pnSubLogin.Controls.Add(this.lbWellcome);
            this.pnSubLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubLogin.Location = new System.Drawing.Point(0, 40);
            this.pnSubLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnSubLogin.Name = "pnSubLogin";
            this.pnSubLogin.Size = new System.Drawing.Size(460, 600);
            this.pnSubLogin.TabIndex = 5;
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(-15, -55);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2ProgressIndicator1.TabIndex = 4;
            // 
            // pnFrameOption
            // 
            this.pnFrameOption.BackColor = System.Drawing.Color.White;
            this.pnFrameOption.Controls.Add(this.pnLoginSignupContent);
            this.pnFrameOption.Controls.Add(this.btnSignUp);
            this.pnFrameOption.Controls.Add(this.btnLogIn);
            this.pnFrameOption.Location = new System.Drawing.Point(0, 385);
            this.pnFrameOption.Margin = new System.Windows.Forms.Padding(2);
            this.pnFrameOption.Name = "pnFrameOption";
            this.pnFrameOption.Size = new System.Drawing.Size(460, 700);
            this.pnFrameOption.TabIndex = 3;
            // 
            // pnLoginSignupContent
            // 
            this.pnLoginSignupContent.Location = new System.Drawing.Point(0, 200);
            this.pnLoginSignupContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnLoginSignupContent.Name = "pnLoginSignupContent";
            this.pnLoginSignupContent.Size = new System.Drawing.Size(460, 475);
            this.pnLoginSignupContent.TabIndex = 2;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignUp.Location = new System.Drawing.Point(118, 125);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(226, 55);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign  Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogIn.Location = new System.Drawing.Point(118, 35);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(226, 55);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Sign  In ";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lbWellcome
            // 
            this.lbWellcome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbWellcome.Font = new System.Drawing.Font("Lucida Handwriting", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.White;
            this.lbWellcome.Location = new System.Drawing.Point(0, 152);
            this.lbWellcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(458, 65);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "WELCOME BACK";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gneContentLogin
            // 
            this.gneContentLogin.BorderRadius = 100;
            this.gneContentLogin.TargetControl = this.pnFrameOption;
            // 
            // timerClickButonLogin
            // 
            this.timerClickButonLogin.Interval = 1;
            this.timerClickButonLogin.Tick += new System.EventHandler(this.timerClickButonLogin_Tick);
            // 
            // gneBtnSingIn
            // 
            this.gneBtnSingIn.BorderRadius = 40;
            this.gneBtnSingIn.TargetControl = this.btnLogIn;
            // 
            // gneBtnSingUp
            // 
            this.gneBtnSingUp.BorderRadius = 40;
            this.gneBtnSingUp.TargetControl = this.btnSignUp;
            // 
            // timerClickButtonSignUp
            // 
            this.timerClickButtonSignUp.Interval = 5;
            this.timerClickButtonSignUp.Tick += new System.EventHandler(this.timerSignUp_Tick);
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
            this.ClientSize = new System.Drawing.Size(460, 640);
            this.Controls.Add(this.pnSubLogin);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnSubLogin.ResumeLayout(false);
            this.pnFrameOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnSubLogin;
        private System.Windows.Forms.Panel pnFrameOption;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lbWellcome;
        private Guna.UI2.WinForms.Guna2Elipse gneContentLogin;
        private System.Windows.Forms.Timer timerClickButonLogin;
        private Guna.UI2.WinForms.Guna2Elipse gneBtnSingIn;
        private Guna.UI2.WinForms.Guna2Elipse gneBtnSingUp;
        private Timer timerClickButtonSignUp;
        private Panel pnLoginSignupContent;
        private Timer timerOpenMainForm;
        private PictureBox btnMaximize;
        private PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;

        public Panel PnSubLogin { get => pnSubLogin; set => pnSubLogin = value; }
        public PictureBox BtnExit { get => btnClose; set => btnClose = value; }
    }
}