using System;

namespace App_Library.Views.UserView.CollectionShop
{
    partial class AdFormNew
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAd = new System.Windows.Forms.Timer(this.components);
            this.ElipseForMainAd = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseForSubAd1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseForSubAd2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnAdMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnSubAd = new Guna.UI2.WinForms.Guna2Panel();
            this.pnAd = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.pnAdMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAd
            // 
            this.timerAd.Interval = 1;
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ElipseForMainAd
            // 
            this.ElipseForMainAd.BorderRadius = 50;
            // 
            // ElipseForSubAd1
            // 
            this.ElipseForSubAd1.BorderRadius = 50;
            // 
            // ElipseForSubAd2
            // 
            this.ElipseForSubAd2.BorderRadius = 50;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.pnAdMain);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(997, 450);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pnAdMain
            // 
            this.pnAdMain.BackColor = System.Drawing.Color.Snow;
            this.pnAdMain.Controls.Add(this.pnSubAd);
            this.pnAdMain.Controls.Add(this.pnAd);
            this.pnAdMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAdMain.Location = new System.Drawing.Point(120, 0);
            this.pnAdMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnAdMain.Name = "pnAdMain";
            this.pnAdMain.Size = new System.Drawing.Size(761, 450);
            this.pnAdMain.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(881, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(116, 450);
            this.guna2Panel2.TabIndex = 3;
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 1;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // pnSubAd
            // 
            this.pnSubAd.Location = new System.Drawing.Point(749, 0);
            this.pnSubAd.Name = "pnSubAd";
            this.pnSubAd.Size = new System.Drawing.Size(12, 450);
            this.pnSubAd.TabIndex = 3;
            // 
            // pnAd
            // 
            this.pnAd.Location = new System.Drawing.Point(0, 0);
            this.pnAd.Name = "pnAd";
            this.pnAd.Size = new System.Drawing.Size(743, 450);
            this.pnAd.TabIndex = 2;
            // 
            // AdFormNew
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdFormNew";
            this.Text = "AdForm";
            this.Load += new System.EventHandler(this.AdForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.pnAdMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Timer timerAd;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForMainAd;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForSubAd1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForSubAd2;

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnAdMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Timer timerAnimation;
        private Guna.UI2.WinForms.Guna2Panel pnSubAd;
        private Guna.UI2.WinForms.Guna2Panel pnAd;
    }
}