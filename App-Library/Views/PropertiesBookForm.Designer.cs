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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameBook = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbPublishedYear = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnBuy = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(28, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 442);
            this.panel1.TabIndex = 0;
            // 
            // lbNameBook
            // 
            this.lbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbNameBook.Location = new System.Drawing.Point(23, 394);
            this.lbNameBook.Name = "lbNameBook";
            this.lbNameBook.Size = new System.Drawing.Size(425, 53);
            this.lbNameBook.TabIndex = 1;
            this.lbNameBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNameBook.Click += new System.EventHandler(this.lbNameBook_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 60;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbAuthor
            // 
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAuthor.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor.Location = new System.Drawing.Point(195, 546);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(269, 33);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAuthor.Click += new System.EventHandler(this.lbAuthor_Click);
            // 
            // lbPublishedYear
            // 
            this.lbPublishedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPublishedYear.ForeColor = System.Drawing.Color.Black;
            this.lbPublishedYear.Location = new System.Drawing.Point(199, 592);
            this.lbPublishedYear.Name = "lbPublishedYear";
            this.lbPublishedYear.Size = new System.Drawing.Size(265, 36);
            this.lbPublishedYear.TabIndex = 3;
            this.lbPublishedYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCategory.ForeColor = System.Drawing.Color.Black;
            this.lbCategory.Location = new System.Drawing.Point(203, 637);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(245, 33);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCategory.Click += new System.EventHandler(this.lbCategory_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(285, 719);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 48);
            this.panel3.TabIndex = 7;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.pnBuy;
            // 
            // pnBuy
            // 
            this.pnBuy.BackColor = System.Drawing.Color.Yellow;
            this.pnBuy.BackgroundImage = global::App_Library.Properties.Resources.gradient;
            this.pnBuy.Controls.Add(this.label2);
            this.pnBuy.Controls.Add(this.pictureBox2);
            this.pnBuy.ForeColor = System.Drawing.Color.Navy;
            this.pnBuy.Location = new System.Drawing.Point(44, 719);
            this.pnBuy.Name = "pnBuy";
            this.pnBuy.Size = new System.Drawing.Size(141, 48);
            this.pnBuy.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(63, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "BUY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_Library.Properties.Resources.shopping_cart;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name Author: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Published Year: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 637);
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
            this.lbPrice.Location = new System.Drawing.Point(45, 447);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(383, 68);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price: ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PropertiesBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 831);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnBuy);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbPublishedYear);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbNameBook);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropertiesBookForm";
            this.Text = "PropertiesBookForm";
            this.panel1.ResumeLayout(false);
            this.pnBuy.ResumeLayout(false);
            this.pnBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNameBook;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbPublishedYear;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrice;
    }
}