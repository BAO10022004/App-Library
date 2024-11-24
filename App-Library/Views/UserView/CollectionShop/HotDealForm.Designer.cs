namespace App_Library.Views.Main.CollectionShop
{
    partial class HotDealForm
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
            this.pnMainTittle = new Guna.UI2.WinForms.Guna2Panel();
            this.pnTittle = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTittle = new System.Windows.Forms.Label();
            this.fpListBook = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMainTittle.SuspendLayout();
            this.pnTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMainTittle
            // 
            this.pnMainTittle.Controls.Add(this.pnTittle);
            this.pnMainTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMainTittle.Location = new System.Drawing.Point(0, 0);
            this.pnMainTittle.Name = "pnMainTittle";
            this.pnMainTittle.Size = new System.Drawing.Size(1300, 52);
            this.pnMainTittle.TabIndex = 0;
            this.pnMainTittle.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pnTittle
            // 
            this.pnTittle.Controls.Add(this.pictureBox1);
            this.pnTittle.Controls.Add(this.lbTittle);
            this.pnTittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnTittle.Location = new System.Drawing.Point(3, 3);
            this.pnTittle.Name = "pnTittle";
            this.pnTittle.Size = new System.Drawing.Size(132, 49);
            this.pnTittle.TabIndex = 2;
            this.pnTittle.MouseLeave += new System.EventHandler(this.pnTittle_MouseLeave);
            this.pnTittle.MouseHover += new System.EventHandler(this.pnTittle_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(83, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pnTittle_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pnTittle_MouseHover);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTittle.ForeColor = System.Drawing.Color.Red;
            this.lbTittle.Location = new System.Drawing.Point(9, 9);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(56, 29);
            this.lbTittle.TabIndex = 1;
            this.lbTittle.Text = "title";
            this.lbTittle.MouseLeave += new System.EventHandler(this.pnTittle_MouseLeave);
            this.lbTittle.MouseHover += new System.EventHandler(this.pnTittle_MouseHover);
            // 
            // fpListBook
            // 
            this.fpListBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpListBook.Location = new System.Drawing.Point(0, 52);
            this.fpListBook.Name = "fpListBook";
            this.fpListBook.Size = new System.Drawing.Size(1297, 379);
            this.fpListBook.TabIndex = 1;
            this.fpListBook.Paint += new System.Windows.Forms.PaintEventHandler(this.fpHotDealBook_Paint);
            // 
            // HotDealForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1300, 413);
            this.Controls.Add(this.fpListBook);
            this.Controls.Add(this.pnMainTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotDealForm";
            this.Text = "HotDealForm";
            this.Load += new System.EventHandler(this.HotDealForm_Load);
            this.pnMainTittle.ResumeLayout(false);
            this.pnTittle.ResumeLayout(false);
            this.pnTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMainTittle;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.FlowLayoutPanel fpListBook;
        private Guna.UI2.WinForms.Guna2Panel pnTittle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}