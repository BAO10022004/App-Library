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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picImageBook = new System.Windows.Forms.PictureBox();
            this.lbTittelBook = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnShowMore = new Guna.UI2.WinForms.Guna2Panel();
            this.lbShowMore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ElipseForBtnSeeMore = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBook)).BeginInit();
            this.btnShowMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEW BOOK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(277, 71);
            this.guna2Panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 71);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_Library.Properties.Resources.new_9562_128;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // picImageBook
            // 
            this.picImageBook.Location = new System.Drawing.Point(292, 1);
            this.picImageBook.Name = "picImageBook";
            this.picImageBook.Size = new System.Drawing.Size(249, 347);
            this.picImageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageBook.TabIndex = 0;
            this.picImageBook.TabStop = false;
            // 
            // lbTittelBook
            // 
            this.lbTittelBook.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittelBook.ForeColor = System.Drawing.Color.Black;
            this.lbTittelBook.Location = new System.Drawing.Point(27, 91);
            this.lbTittelBook.Name = "lbTittelBook";
            this.lbTittelBook.Size = new System.Drawing.Size(262, 110);
            this.lbTittelBook.TabIndex = 3;
            this.lbTittelBook.Text = "label2";
            this.lbTittelBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPrice.Location = new System.Drawing.Point(12, 215);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(277, 79);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price Only : ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShowMore
            // 
            this.btnShowMore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowMore.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowMore.BorderRadius = 10;
            this.btnShowMore.BorderThickness = 2;
            this.btnShowMore.Controls.Add(this.lbShowMore);
            this.btnShowMore.Controls.Add(this.pictureBox1);
            this.btnShowMore.Location = new System.Drawing.Point(33, 298);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(119, 40);
            this.btnShowMore.TabIndex = 5;
            this.btnShowMore.Click += new System.EventHandler(this.lbShowMore_Click);
            this.btnShowMore.MouseLeave += new System.EventHandler(this.btnShowMore_MouseLeave);
            this.btnShowMore.MouseHover += new System.EventHandler(this.btnShowMore_MouseHover);
            // 
            // lbShowMore
            // 
            this.lbShowMore.AutoSize = true;
            this.lbShowMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbShowMore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbShowMore.Location = new System.Drawing.Point(12, 11);
            this.lbShowMore.Name = "lbShowMore";
            this.lbShowMore.Size = new System.Drawing.Size(87, 16);
            this.lbShowMore.TabIndex = 0;
            this.lbShowMore.Text = "Show more ";
            this.lbShowMore.Click += new System.EventHandler(this.lbShowMore_Click);
            this.lbShowMore.MouseLeave += new System.EventHandler(this.btnShowMore_MouseLeave);
            this.lbShowMore.MouseHover += new System.EventHandler(this.btnShowMore_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Library.Properties.Resources.ArrowTittle;
            this.pictureBox1.Location = new System.Drawing.Point(95, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.lbShowMore_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.btnShowMore_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.btnShowMore_MouseHover);
            // 
            // ElipseForBtnSeeMore
            // 
            this.ElipseForBtnSeeMore.BorderRadius = 15;
            this.ElipseForBtnSeeMore.TargetControl = this.btnShowMore;
            // 
            // saveFileDialog1
            // 
            // 
            // Advertisement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(544, 350);
            this.Controls.Add(this.btnShowMore);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTittelBook);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.picImageBook);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Advertisement";
            this.Text = "Advertisement";
            this.Load += new System.EventHandler(this.Advertisement_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBook)).EndInit();
            this.btnShowMore.ResumeLayout(false);
            this.btnShowMore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageBook;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTittelBook;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2Panel btnShowMore;
        private System.Windows.Forms.Label lbShowMore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForBtnSeeMore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}