namespace App_Library.Views.UserView.CollectionShop
{
    partial class BookItemSearch
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
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbNameBook = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(8, -1);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(71, 104);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.lbNameBook_Click);
            // 
            // lbNameBook
            // 
            this.lbNameBook.BackColor = System.Drawing.Color.Transparent;
            this.lbNameBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameBook.ForeColor = System.Drawing.Color.White;
            this.lbNameBook.Location = new System.Drawing.Point(85, 5);
            this.lbNameBook.Name = "lbNameBook";
            this.lbNameBook.Size = new System.Drawing.Size(407, 40);
            this.lbNameBook.TabIndex = 1;
            this.lbNameBook.Text = "label1";
            this.lbNameBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNameBook.Click += new System.EventHandler(this.lbNameBook_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.White;
            this.lbAuthor.Location = new System.Drawing.Point(85, 45);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(407, 40);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "label1";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAuthor.Click += new System.EventHandler(this.lbNameBook_Click);
            // 
            // BookItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbNameBook);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookItemSearch";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "BookItemSearch";
            this.Load += new System.EventHandler(this.BookItemSearch_Load);
            this.Click += new System.EventHandler(this.lbNameBook_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private System.Windows.Forms.Label lbNameBook;
        private System.Windows.Forms.Label lbAuthor;
    }
}