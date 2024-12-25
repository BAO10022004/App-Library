namespace App_Library.Views.UserView.CollectionShop
{
    partial class ViewBookForm
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
            this.pnContainSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.geSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.geButtonSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.geTextBoxSerch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainFlow = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeleteSortPrice = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDeleteSort = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSortPrice = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortName = new Guna.UI2.WinForms.Guna2Button();
            this.pnContainSearch.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnContainFlow.SuspendLayout();
            this.pnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainSearch
            // 
            this.pnContainSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainSearch.Controls.Add(this.btnBack);
            this.pnContainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainSearch.Location = new System.Drawing.Point(0, 0);
            this.pnContainSearch.Name = "pnContainSearch";
            this.pnContainSearch.Size = new System.Drawing.Size(1030, 100);
            this.pnContainSearch.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::App_Library.Properties.Resources.arrow__1_;
            this.btnBack.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Location = new System.Drawing.Point(12, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // geSearch
            // 
            this.geSearch.BorderRadius = 50;
            // 
            // geButtonSearch
            // 
            this.geButtonSearch.BorderRadius = 30;
            // 
            // geTextBoxSerch
            // 
            this.geTextBoxSerch.BorderRadius = 40;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnContainFlow);
            this.pnMain.Controls.Add(this.pnFilter);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 100);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1030, 580);
            this.pnMain.TabIndex = 2;
            // 
            // pnContainFlow
            // 
            this.pnContainFlow.Controls.Add(this.pnContain);
            this.pnContainFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainFlow.Location = new System.Drawing.Point(0, 64);
            this.pnContainFlow.Name = "pnContainFlow";
            this.pnContainFlow.Size = new System.Drawing.Size(1030, 516);
            this.pnContainFlow.TabIndex = 1;
            // 
            // pnContain
            // 
            this.pnContain.AutoScroll = true;
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(0, 0);
            this.pnContain.Name = "pnContain";
            this.pnContain.Size = new System.Drawing.Size(1030, 516);
            this.pnContain.TabIndex = 0;
            // 
            // pnFilter
            // 
            this.pnFilter.Controls.Add(this.btnDeleteSortPrice);
            this.pnFilter.Controls.Add(this.btnDeleteSort);
            this.pnFilter.Controls.Add(this.btnSortPrice);
            this.pnFilter.Controls.Add(this.btnSortName);
            this.pnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFilter.Location = new System.Drawing.Point(0, 0);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(1030, 64);
            this.pnFilter.TabIndex = 0;
            // 
            // btnDeleteSortPrice
            // 
            this.btnDeleteSortPrice.Animated = true;
            this.btnDeleteSortPrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSortPrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSortPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSortPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSortPrice.FillColor = System.Drawing.Color.White;
            this.btnDeleteSortPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteSortPrice.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSortPrice.Location = new System.Drawing.Point(229, 13);
            this.btnDeleteSortPrice.Name = "btnDeleteSortPrice";
            this.btnDeleteSortPrice.PressedDepth = 0;
            this.btnDeleteSortPrice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDeleteSortPrice.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteSortPrice.TabIndex = 2;
            this.btnDeleteSortPrice.Text = "X";
            this.btnDeleteSortPrice.Visible = false;
            this.btnDeleteSortPrice.Click += new System.EventHandler(this.btnDeleteSortForPrice_Click);
            // 
            // btnDeleteSort
            // 
            this.btnDeleteSort.Animated = true;
            this.btnDeleteSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSort.FillColor = System.Drawing.Color.White;
            this.btnDeleteSort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSort.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSort.Location = new System.Drawing.Point(100, 13);
            this.btnDeleteSort.Name = "btnDeleteSort";
            this.btnDeleteSort.PressedDepth = 0;
            this.btnDeleteSort.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDeleteSort.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteSort.TabIndex = 0;
            this.btnDeleteSort.Text = "X";
            this.btnDeleteSort.Visible = false;
            this.btnDeleteSort.Click += new System.EventHandler(this.btnDeleteSort_Click);
            // 
            // btnSortPrice
            // 
            this.btnSortPrice.Animated = true;
            this.btnSortPrice.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSortPrice.BorderRadius = 20;
            this.btnSortPrice.BorderThickness = 3;
            this.btnSortPrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortPrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortPrice.FillColor = System.Drawing.Color.Transparent;
            this.btnSortPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortPrice.ForeColor = System.Drawing.Color.White;
            this.btnSortPrice.Image = global::App_Library.Properties.Resources.cheap;
            this.btnSortPrice.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSortPrice.Location = new System.Drawing.Point(136, 6);
            this.btnSortPrice.Name = "btnSortPrice";
            this.btnSortPrice.Size = new System.Drawing.Size(87, 46);
            this.btnSortPrice.TabIndex = 1;
            this.btnSortPrice.Click += new System.EventHandler(this.btnSortPrice_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Animated = true;
            this.btnSortName.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSortName.BorderRadius = 20;
            this.btnSortName.BorderThickness = 3;
            this.btnSortName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortName.FillColor = System.Drawing.Color.Transparent;
            this.btnSortName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortName.ForeColor = System.Drawing.Color.White;
            this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az;
            this.btnSortName.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSortName.Location = new System.Drawing.Point(12, 6);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(87, 46);
            this.btnSortName.TabIndex = 0;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // ViewBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 680);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnContainSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBookForm";
            this.Text = "ViewBookForm";
            this.Load += new System.EventHandler(this.ViewBookForm_Load);
            this.pnContainSearch.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnContainFlow.ResumeLayout(false);
            this.pnFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnContainSearch;
        private Guna.UI2.WinForms.Guna2Elipse geSearch;
        private Guna.UI2.WinForms.Guna2Elipse geButtonSearch;
        private Guna.UI2.WinForms.Guna2Elipse geTextBoxSerch;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel pnFilter;
        private Guna.UI2.WinForms.Guna2Panel pnContainFlow;
        private Guna.UI2.WinForms.Guna2Button btnSortName;
        private Guna.UI2.WinForms.Guna2Button btnSortPrice;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeleteSort;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeleteSortPrice;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel pnContain;
    }
}