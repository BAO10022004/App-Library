namespace App_Library.Views.Main.CollectionShop
{
    partial class AdForm
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
            this.timerAd = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAdMain = new Guna.UI2.WinForms.Guna2Panel();
            this.picSubAd1 = new System.Windows.Forms.PictureBox();
            this.picSubAd2 = new System.Windows.Forms.PictureBox();
            this.ElipseForMainAd = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseForSubAd1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseForSubAd2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSubAd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubAd2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAd
            // 
            this.timerAd.Interval = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pnAdMain);
            this.flowLayoutPanel1.Controls.Add(this.picSubAd1);
            this.flowLayoutPanel1.Controls.Add(this.picSubAd2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(997, 350);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnAdMain
            // 
            this.pnAdMain.BackColor = System.Drawing.Color.Snow;
            this.pnAdMain.Location = new System.Drawing.Point(0, 0);
            this.pnAdMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnAdMain.Name = "pnAdMain";
            this.pnAdMain.Size = new System.Drawing.Size(544, 350);
            this.pnAdMain.TabIndex = 0;
            // 
            // picSubAd1
            // 
            this.picSubAd1.Location = new System.Drawing.Point(547, 3);
            this.picSubAd1.Name = "picSubAd1";
            this.picSubAd1.Size = new System.Drawing.Size(220, 350);
            this.picSubAd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSubAd1.TabIndex = 1;
            this.picSubAd1.TabStop = false;
            this.picSubAd1.Click += new System.EventHandler(this.picSubAd1_Click);
            // 
            // picSubAd2
            // 
            this.picSubAd2.Location = new System.Drawing.Point(773, 3);
            this.picSubAd2.Name = "picSubAd2";
            this.picSubAd2.Size = new System.Drawing.Size(220, 350);
            this.picSubAd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSubAd2.TabIndex = 2;
            this.picSubAd2.TabStop = false;
            this.picSubAd2.Click += new System.EventHandler(this.picSubAd2_Click);
            // 
            // ElipseForMainAd
            // 
            this.ElipseForMainAd.BorderRadius = 50;
            this.ElipseForMainAd.TargetControl = this.pnAdMain;
            // 
            // ElipseForSubAd1
            // 
            this.ElipseForSubAd1.BorderRadius = 50;
            this.ElipseForSubAd1.TargetControl = this.picSubAd1;
            // 
            // ElipseForSubAd2
            // 
            this.ElipseForSubAd2.BorderRadius = 50;
            this.ElipseForSubAd2.TargetControl = this.picSubAd2;
            // 
            // AdForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(997, 350);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdForm";
            this.Text = "AdForm";
            this.Load += new System.EventHandler(this.AdForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSubAd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubAd2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnAdMain;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForMainAd;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForSubAd1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForSubAd2;
        private System.Windows.Forms.PictureBox picSubAd1;
        private System.Windows.Forms.PictureBox picSubAd2;
    }
}