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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSubLogin = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnSubLogin.SuspendLayout();
            this.pnFrameOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.btnExit);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(580, 40);
            this.pnHeader.TabIndex = 2;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::App_Library.Properties.Resources.cross;
            this.btnExit.Location = new System.Drawing.Point(545, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(57, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Frame";
            // 
            // pnSubLogin
            // 
            this.pnSubLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnSubLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSubLogin.Controls.Add(this.pnFrameOption);
            this.pnSubLogin.Controls.Add(this.lbWellcome);
            this.pnSubLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubLogin.Location = new System.Drawing.Point(0, 40);
            this.pnSubLogin.Name = "pnSubLogin";
            this.pnSubLogin.Size = new System.Drawing.Size(580, 760);
            this.pnSubLogin.TabIndex = 5;
            // 
            // pnFrameOption
            // 
            this.pnFrameOption.BackColor = System.Drawing.Color.White;
            this.pnFrameOption.Controls.Add(this.pnLoginSignupContent);
            this.pnFrameOption.Controls.Add(this.btnSignUp);
            this.pnFrameOption.Controls.Add(this.btnLogIn);
            this.pnFrameOption.Location = new System.Drawing.Point(0, 490);
            this.pnFrameOption.Name = "pnFrameOption";
            this.pnFrameOption.Size = new System.Drawing.Size(580, 894);
            this.pnFrameOption.TabIndex = 3;
            // 
            // pnLoginSignupContent
            // 
            this.pnLoginSignupContent.Location = new System.Drawing.Point(0, 260);
            this.pnLoginSignupContent.Name = "pnLoginSignupContent";
            this.pnLoginSignupContent.Size = new System.Drawing.Size(580, 620);
            this.pnLoginSignupContent.TabIndex = 2;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignUp.Location = new System.Drawing.Point(150, 150);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(280, 70);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign - Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogIn.Location = new System.Drawing.Point(150, 40);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(280, 70);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Sign - In ";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lbWellcome
            // 
            this.lbWellcome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbWellcome.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.White;
            this.lbWellcome.Location = new System.Drawing.Point(115, 215);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(350, 80);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "WELLCOME BACK";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gneContentLogin
            // 
            this.gneContentLogin.BorderRadius = 100;
            this.gneContentLogin.TargetControl = this.pnFrameOption;
            // 
            // timerClickButonLogin
            // 
            this.timerClickButonLogin.Interval = 5;
            this.timerClickButonLogin.Tick += new System.EventHandler(this.timerClickButonLogin_Tick);
            // 
            // gneBtnSingIn
            // 
            this.gneBtnSingIn.BorderRadius = 50;
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
            this.timerOpenMainForm.Tick += new System.EventHandler(this.timerOpenMainForm_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 800);
            this.Controls.Add(this.pnSubLogin);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnSubLogin.ResumeLayout(false);
            this.pnFrameOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
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

        public Panel PnSubLogin { get => pnSubLogin; set => pnSubLogin = value; }
        public PictureBox BtnExit { get => btnExit; set => btnExit = value; }
    }
}