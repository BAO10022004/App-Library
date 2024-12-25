namespace App_Library.Views.UserView.CollectionShop
{
    partial class AnimationProperties
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
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timerGoHome = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Honeydew;
            this.picImage.FillColor = System.Drawing.Color.LightGray;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(563, 308);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(186, 262);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // timerGoHome
            // 
            this.timerGoHome.Interval = 1;
            this.timerGoHome.Tick += new System.EventHandler(this.timerGoHome_Tick);
            // 
            // AnimationProperties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 680);
            this.Controls.Add(this.picImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimationProperties";
            this.Text = "AnimationProperties";
            this.Load += new System.EventHandler(this.AnimationProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private System.Windows.Forms.Timer timerGoHome;
    }
}