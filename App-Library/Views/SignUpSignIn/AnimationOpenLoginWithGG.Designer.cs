namespace App_Library.Views.SignUpSignIn
{
    partial class AnimationOpenLoginWithGG
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignInGG = new Guna.UI2.WinForms.Guna2Panel();
            this.picGG = new System.Windows.Forms.PictureBox();
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.pnMain.SuspendLayout();
            this.btnSignInGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnSignInGG);
            this.pnMain.Location = new System.Drawing.Point(78, 415);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(310, 47);
            this.pnMain.TabIndex = 0;
            // 
            // btnSignInGG
            // 
            this.btnSignInGG.BackColor = System.Drawing.Color.Transparent;
            this.btnSignInGG.BorderColor = System.Drawing.Color.Blue;
            this.btnSignInGG.BorderRadius = 15;
            this.btnSignInGG.BorderThickness = 3;
            this.btnSignInGG.Controls.Add(this.picGG);
            this.btnSignInGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignInGG.FillColor = System.Drawing.Color.White;
            this.btnSignInGG.Location = new System.Drawing.Point(0, 0);
            this.btnSignInGG.Name = "btnSignInGG";
            this.btnSignInGG.Padding = new System.Windows.Forms.Padding(12);
            this.btnSignInGG.Size = new System.Drawing.Size(310, 47);
            this.btnSignInGG.TabIndex = 18;
            // 
            // picGG
            // 
            this.picGG.BackColor = System.Drawing.Color.Transparent;
            this.picGG.Image = global::App_Library.Properties.Resources.google1;
            this.picGG.Location = new System.Drawing.Point(143, 11);
            this.picGG.Name = "picGG";
            this.picGG.Size = new System.Drawing.Size(28, 23);
            this.picGG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGG.TabIndex = 1;
            this.picGG.TabStop = false;
            // 
            // timerOpen
            // 
            this.timerOpen.Interval = 1;
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // AnimationOpenLoginWithGG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(460, 640);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimationOpenLoginWithGG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimationOpenLoginWithGG";
            this.pnMain.ResumeLayout(false);
            this.btnSignInGG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        internal Guna.UI2.WinForms.Guna2Panel btnSignInGG;
        private System.Windows.Forms.PictureBox picGG;
        private System.Windows.Forms.Timer timerOpen;
    }
}