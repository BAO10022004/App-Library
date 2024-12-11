namespace App_Library.Views.UserView.CollectionHome
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
            this.picBook = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnContainRead = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRead = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // picBook
            // 
            this.picBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBook.ImageRotate = 0F;
            this.picBook.Location = new System.Drawing.Point(10, 10);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(180, 280);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 0;
            this.picBook.TabStop = false;
            this.picBook.MouseHover += new System.EventHandler(this.pnNoSee_MouseHover);
            // 
            // pnContainRead
            // 
            this.pnContainRead.BackColor = System.Drawing.Color.Transparent;
            this.pnContainRead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnContainRead.Location = new System.Drawing.Point(10, 256);
            this.pnContainRead.Name = "pnContainRead";
            this.pnContainRead.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnContainRead.Size = new System.Drawing.Size(180, 34);
            this.pnContainRead.TabIndex = 1;
            this.pnContainRead.MouseLeave += new System.EventHandler(this.pnNoSee_MouseLeave);
            this.pnContainRead.MouseHover += new System.EventHandler(this.pnNoSee_MouseHover);
            // 
            // btnRead
            // 
            this.btnRead.BorderColor = System.Drawing.Color.Navy;
            this.btnRead.BorderRadius = 9;
            this.btnRead.BorderThickness = 1;
            this.btnRead.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRead.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRead.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRead.FillColor = System.Drawing.Color.SteelBlue;
            this.btnRead.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.btnRead.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnRead.Location = new System.Drawing.Point(0, 0);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(200, 34);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "READ";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(200, 300);
            this.Controls.Add(this.pnContainRead);
            this.Controls.Add(this.picBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BookItem";
            this.Load += new System.EventHandler(this.BookItem_Load);
            this.MouseLeave += new System.EventHandler(this.pnNoSee_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBook;
        private Guna.UI2.WinForms.Guna2Panel pnContainRead;
        private Guna.UI2.WinForms.Guna2Button btnRead;
    }
}