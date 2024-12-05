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
            this.picImageBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseForBtnSeeMore
            // 
            this.ElipseForBtnSeeMore.BorderRadius = 15;
            // 
            // picImageBook
            // 
            this.picImageBook.Image = global::App_Library.Properties.Resources.bannerElonMusk;
            this.picImageBook.Location = new System.Drawing.Point(1, 1);
            this.picImageBook.Name = "picImageBook";
            this.picImageBook.Size = new System.Drawing.Size(540, 347);
            this.picImageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageBook.TabIndex = 0;
            this.picImageBook.TabStop = false;
            this.picImageBook.Click += new System.EventHandler(this.picImageBook_Click);
            // 
            // Advertisement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(544, 350);
            this.Controls.Add(this.picImageBook);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Advertisement";
            this.Text = "Advertisement";
            this.Load += new System.EventHandler(this.Advertisement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageBook;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForBtnSeeMore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}