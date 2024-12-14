namespace App_Library.Views.UserView.CollectionHome
{
    partial class HistoryChild
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBookName = new System.Windows.Forms.Panel();
            this.lbBookName = new System.Windows.Forms.Label();
            this.pnAuthor = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.pnPrice = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnRemind = new Guna.UI2.WinForms.Guna2Button();
            this.pnTime = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.pnBookName.SuspendLayout();
            this.pnAuthor.SuspendLayout();
            this.pnPrice.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.pnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnMain
            // 
            this.pnMain.BorderColor = System.Drawing.Color.Firebrick;
            this.pnMain.BorderRadius = 10;
            this.pnMain.BorderThickness = 2;
            this.pnMain.Controls.Add(this.pnBookName);
            this.pnMain.Controls.Add(this.pnAuthor);
            this.pnMain.Controls.Add(this.pnPrice);
            this.pnMain.Controls.Add(this.pnStatus);
            this.pnMain.Controls.Add(this.btnRemind);
            this.pnMain.Controls.Add(this.pnTime);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1025, 64);
            this.pnMain.TabIndex = 0;
            // 
            // pnBookName
            // 
            this.pnBookName.Controls.Add(this.lbBookName);
            this.pnBookName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBookName.ForeColor = System.Drawing.Color.DimGray;
            this.pnBookName.Location = new System.Drawing.Point(28, 5);
            this.pnBookName.Name = "pnBookName";
            this.pnBookName.Size = new System.Drawing.Size(243, 50);
            this.pnBookName.TabIndex = 12;
            // 
            // lbBookName
            // 
            this.lbBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBookName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.ForeColor = System.Drawing.Color.DimGray;
            this.lbBookName.Location = new System.Drawing.Point(0, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(243, 50);
            this.lbBookName.TabIndex = 0;
            this.lbBookName.Text = "    BOOK NAME";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBookName.Click += new System.EventHandler(this.lbBookName_Click);
            // 
            // pnAuthor
            // 
            this.pnAuthor.Controls.Add(this.lbAuthor);
            this.pnAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.pnAuthor.Location = new System.Drawing.Point(277, 5);
            this.pnAuthor.Name = "pnAuthor";
            this.pnAuthor.Size = new System.Drawing.Size(167, 50);
            this.pnAuthor.TabIndex = 13;
            // 
            // lbAuthor
            // 
            this.lbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.lbAuthor.Location = new System.Drawing.Point(0, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(167, 50);
            this.lbAuthor.TabIndex = 0;
            this.lbAuthor.Text = "   AUTHOR";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnPrice
            // 
            this.pnPrice.Controls.Add(this.lbPrice);
            this.pnPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPrice.ForeColor = System.Drawing.Color.DimGray;
            this.pnPrice.Location = new System.Drawing.Point(450, 5);
            this.pnPrice.Name = "pnPrice";
            this.pnPrice.Size = new System.Drawing.Size(109, 50);
            this.pnPrice.TabIndex = 14;
            // 
            // lbPrice
            // 
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbPrice.Location = new System.Drawing.Point(0, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(109, 50);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "PRICE";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.lbStatus);
            this.pnStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnStatus.ForeColor = System.Drawing.Color.DimGray;
            this.pnStatus.Location = new System.Drawing.Point(565, 5);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(155, 50);
            this.pnStatus.TabIndex = 15;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbStatus.Location = new System.Drawing.Point(0, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(155, 50);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "STATUS";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemind
            // 
            this.btnRemind.Animated = true;
            this.btnRemind.AnimatedGIF = true;
            this.btnRemind.AutoRoundedCorners = true;
            this.btnRemind.BorderRadius = 22;
            this.btnRemind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemind.FillColor = System.Drawing.Color.White;
            this.btnRemind.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnRemind.ForeColor = System.Drawing.Color.Blue;
            this.btnRemind.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRemind.Location = new System.Drawing.Point(901, 8);
            this.btnRemind.Name = "btnRemind";
            this.btnRemind.Size = new System.Drawing.Size(112, 47);
            this.btnRemind.TabIndex = 17;
            this.btnRemind.Text = "REMIND";
            this.btnRemind.Click += new System.EventHandler(this.btnRemind_Click);
            // 
            // pnTime
            // 
            this.pnTime.Controls.Add(this.lbTime);
            this.pnTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTime.ForeColor = System.Drawing.Color.DimGray;
            this.pnTime.Location = new System.Drawing.Point(719, 5);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(176, 50);
            this.pnTime.TabIndex = 16;
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lbTime.ForeColor = System.Drawing.Color.DimGray;
            this.lbTime.Location = new System.Drawing.Point(0, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(176, 50);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "TIME STAMP";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HistoryChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1025, 64);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryChild";
            this.Text = "HistoryChild";
            this.Load += new System.EventHandler(this.HistoryChild_Load);
            this.Resize += new System.EventHandler(this.HistoryChild_Resize);
            this.pnMain.ResumeLayout(false);
            this.pnBookName.ResumeLayout(false);
            this.pnAuthor.ResumeLayout(false);
            this.pnPrice.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private System.Windows.Forms.Panel pnBookName;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Panel pnAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Panel pnPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbStatus;
        private Guna.UI2.WinForms.Guna2Panel pnTime;
        private System.Windows.Forms.Label lbTime;
        public Guna.UI2.WinForms.Guna2Button btnRemind;
        private System.Windows.Forms.Timer timer1;
    }
}