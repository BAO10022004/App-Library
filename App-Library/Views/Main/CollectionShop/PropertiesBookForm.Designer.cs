namespace App_Library.Views
{
    partial class PropertiesBookForm
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnBuy = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameBook = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbPublishedYear = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pnBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 60;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.pnBuy;
            // 
            // pnBuy
            // 
            this.pnBuy.BackgroundImage = global::App_Library.Properties.Resources.gradient;
            this.pnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBuy.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pnBuy.BorderRadius = 15;
            this.pnBuy.BorderThickness = 5;
            this.pnBuy.Controls.Add(this.label2);
            this.pnBuy.Controls.Add(this.pictureBox2);
            this.pnBuy.Location = new System.Drawing.Point(111, 655);
            this.pnBuy.Name = "pnBuy";
            this.pnBuy.Size = new System.Drawing.Size(170, 74);
            this.pnBuy.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_Library.Properties.Resources.shopping_cart;
            this.pictureBox2.Location = new System.Drawing.Point(11, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(7, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 442);
            this.panel1.TabIndex = 0;
            // 
            // lbNameBook
            // 
            this.lbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbNameBook.Location = new System.Drawing.Point(47, 392);
            this.lbNameBook.Name = "lbNameBook";
            this.lbNameBook.Size = new System.Drawing.Size(350, 53);
            this.lbNameBook.TabIndex = 1;
            this.lbNameBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAuthor
            // 
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAuthor.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor.Location = new System.Drawing.Point(164, 460);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(269, 33);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPublishedYear
            // 
            this.lbPublishedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPublishedYear.ForeColor = System.Drawing.Color.Black;
            this.lbPublishedYear.Location = new System.Drawing.Point(172, 506);
            this.lbPublishedYear.Name = "lbPublishedYear";
            this.lbPublishedYear.Size = new System.Drawing.Size(265, 36);
            this.lbPublishedYear.TabIndex = 3;
            this.lbPublishedYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCategory.ForeColor = System.Drawing.Color.Black;
            this.lbCategory.Location = new System.Drawing.Point(172, 556);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(245, 33);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name Author: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Published Year: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(20, 584);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(413, 68);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price: ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PropertiesBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 741);
            this.Controls.Add(this.pnBuy);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbPublishedYear);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbNameBook);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropertiesBookForm";
            this.Opacity = 0.6D;
            this.Text = "PropertiesBookForm";
            this.pnBuy.ResumeLayout(false);
            this.pnBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbPublishedYear;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbNameBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}