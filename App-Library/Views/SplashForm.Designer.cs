using System.Windows.Forms;

namespace App_Library.Views
{
    partial class SplashForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSubLogin = new System.Windows.Forms.Panel();
            this.pnFrameOption = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.gneContentLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerClickButonLogin = new System.Windows.Forms.Timer(this.components);
            this.gneBtnSingIn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gneBtnSingUp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLogInContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnSubLogin.SuspendLayout();
            this.pnFrameOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 38);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::App_Library.Properties.Resources.cross;
            this.btnExit.Location = new System.Drawing.Point(540, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 32);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnSubLogin
            // 
            this.pnSubLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnSubLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSubLogin.Controls.Add(this.pnFrameOption);
            this.pnSubLogin.Controls.Add(this.lbWellcome);
            this.pnSubLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubLogin.Location = new System.Drawing.Point(0, 38);
            this.pnSubLogin.Name = "pnSubLogin";
            this.pnSubLogin.Size = new System.Drawing.Size(580, 812);
            this.pnSubLogin.TabIndex = 5;
            this.pnSubLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSubLogin_Paint);
            // 
            // pnFrameOption
            // 
            this.pnFrameOption.BackColor = System.Drawing.Color.White;
            this.pnFrameOption.Controls.Add(this.pnLogInContent);
            this.pnFrameOption.Controls.Add(this.btnSignUp);
            this.pnFrameOption.Controls.Add(this.button1);
            this.pnFrameOption.Location = new System.Drawing.Point(-1, 616);
            this.pnFrameOption.Name = "pnFrameOption";
            this.pnFrameOption.Size = new System.Drawing.Size(580, 800);
            this.pnFrameOption.TabIndex = 3;
            this.pnFrameOption.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFrameOption_Paint);
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignUp.Location = new System.Drawing.Point(152, 110);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(285, 73);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign - Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(152, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign - In ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbWellcome
            // 
            this.lbWellcome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbWellcome.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.White;
            this.lbWellcome.Location = new System.Drawing.Point(116, 213);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(355, 83);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "WELLCOME BACK";
            this.lbWellcome.Click += new System.EventHandler(this.lbWellcome_Click);
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
            this.gneBtnSingIn.TargetControl = this.button1;
            // 
            // gneBtnSingUp
            // 
            this.gneBtnSingUp.BorderRadius = 40;
            this.gneBtnSingUp.TargetControl = this.btnSignUp;
            // 
            // pnLogInContent
            // 
            this.pnLogInContent.Location = new System.Drawing.Point(4, 239);
            this.pnLogInContent.Name = "pnLogInContent";
            this.pnLogInContent.Size = new System.Drawing.Size(576, 596);
            this.pnLogInContent.TabIndex = 2;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 850);
            this.Controls.Add(this.pnSubLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnSubLogin.ResumeLayout(false);
            this.pnFrameOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnSubLogin;
        private System.Windows.Forms.Panel pnFrameOption;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbWellcome;
        private Guna.UI2.WinForms.Guna2Elipse gneContentLogin;
        private System.Windows.Forms.Timer timerClickButonLogin;
        private Guna.UI2.WinForms.Guna2Elipse gneBtnSingIn;
        private Guna.UI2.WinForms.Guna2Elipse gneBtnSingUp;
        private Panel pnLogInContent;
    }
}