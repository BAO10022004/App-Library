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
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbNameBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(230, 360);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.picImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(230, 360);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lbPrice);
            this.guna2Panel2.Controls.Add(this.lbInfo);
            this.guna2Panel2.Controls.Add(this.lbNameBook);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 286);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(230, 74);
            this.guna2Panel2.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(5, 49);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(222, 23);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "1";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbInfo.Location = new System.Drawing.Point(3, 28);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(224, 21);
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
            this.lbNameBook.Size = new System.Drawing.Size(227, 28);
            this.lbNameBook.TabIndex = 0;
            this.lbNameBook.Text = "label1";
            this.lbNameBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(250, 380);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BookItem";
            this.Load += new System.EventHandler(this.BookItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbNameBook;
    }
}