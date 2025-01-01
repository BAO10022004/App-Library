namespace App_Library.Views.Main.CollectionShop
{
    partial class Advertisement
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
            this.ElipseForBtnSeeMore = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnMain = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.timerHover = new System.Windows.Forms.Timer(this.components);
            this.picImageBook = new System.Windows.Forms.PictureBox();
            this.pnMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseForBtnSeeMore
            // 
            this.ElipseForBtnSeeMore.BorderRadius = 15;
            this.ElipseForBtnSeeMore.TargetControl = this.picImageBook;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.guna2Panel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.FillColor = System.Drawing.Color.Transparent;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnMain.ShadowColor = System.Drawing.Color.White;
            this.pnMain.ShadowDepth = 250;
            this.pnMain.ShadowShift = 10;
            this.pnMain.Size = new System.Drawing.Size(544, 350);
            this.pnMain.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.picImageBook);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(15, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(514, 320);
            this.guna2Panel1.TabIndex = 0;
            // 
            // timerHover
            // 
            this.timerHover.Interval = 50;
            this.timerHover.Tick += new System.EventHandler(this.timerHover_Tick);
            // 
            // picImageBook
            // 
            this.picImageBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageBook.Image = global::App_Library.Properties.Resources.bannerElonMusk;
            this.picImageBook.Location = new System.Drawing.Point(0, 0);
            this.picImageBook.Name = "picImageBook";
            this.picImageBook.Size = new System.Drawing.Size(514, 320);
            this.picImageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageBook.TabIndex = 2;
            this.picImageBook.TabStop = false;
            this.picImageBook.Click += new System.EventHandler(this.picImageBook_Click);
            this.picImageBook.MouseLeave += new System.EventHandler(this.picImageBook_MouseLeave_1);
            this.picImageBook.MouseHover += new System.EventHandler(this.picImageBook_MouseHover);
            // 
            // Advertisement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 350);
            this.Controls.Add(this.pnMain);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Advertisement";
            this.Text = "Advertisement";
            this.Load += new System.EventHandler(this.Advertisement_Load);
            this.pnMain.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse ElipseForBtnSeeMore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnMain;
        private System.Windows.Forms.Timer timerHover;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox picImageBook;
    }
}