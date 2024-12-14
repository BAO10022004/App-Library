namespace App_Library.Views.UserView.CollectionShop
{
    partial class BookItem
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbNameBook = new System.Windows.Forms.Label();
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbInfo);
            this.guna2Panel1.Controls.Add(this.lbNameBook);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 296);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(230, 74);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbInfo.Location = new System.Drawing.Point(3, 50);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(224, 24);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "label1";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNameBook
            // 
            this.lbNameBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameBook.ForeColor = System.Drawing.Color.Black;
            this.lbNameBook.Location = new System.Drawing.Point(3, 0);
            this.lbNameBook.Name = "lbNameBook";
            this.lbNameBook.Size = new System.Drawing.Size(227, 42);
            this.lbNameBook.TabIndex = 0;
            this.lbNameBook.Text = "label1";
            this.lbNameBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(10, 10);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(230, 360);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(250, 380);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.picImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BookItem";
            this.Load += new System.EventHandler(this.BookItem_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbNameBook;
        private System.Windows.Forms.Label lbInfo;
    }
}