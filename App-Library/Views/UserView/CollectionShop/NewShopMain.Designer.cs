﻿using App_Library.Views.ToolerForm;
using System.Web.UI.WebControls;

namespace App_Library.Views.Main.CollectionShop
{
    partial class NewShopMain
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.geSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnSearchShop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMainSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.geTextBoxSerch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.geButtonSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMainForm = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAd = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainAd = new Guna.UI2.WinForms.Guna2Panel();
            this.pnNewItem = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowpnNewItem = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBestDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.flowpnBestDeal = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainAllBook = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnContainSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnResultSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.pnSearchShop.SuspendLayout();
            this.pnMainSearch.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnMainForm.SuspendLayout();
            this.pnAd.SuspendLayout();
            this.pnNewItem.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnBestDeal.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel6.SuspendLayout();
            this.pnContainAllBook.SuspendLayout();
            this.pnContainSearch.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompletedAsync);
            // 
            // geSearch
            // 
            this.geSearch.BorderRadius = 50;
            this.geSearch.TargetControl = this.pnSearchShop;
            // 
            // pnSearchShop
            // 
            this.pnSearchShop.BackColor = System.Drawing.Color.MintCream;
            this.pnSearchShop.BorderColor = System.Drawing.Color.PaleGreen;
            this.pnSearchShop.BorderRadius = 26;
            this.pnSearchShop.BorderThickness = 3;
            this.pnSearchShop.Controls.Add(this.pnMainSearch);
            this.pnSearchShop.Controls.Add(this.guna2Panel1);
            this.pnSearchShop.Location = new System.Drawing.Point(294, 12);
            this.pnSearchShop.Name = "pnSearchShop";
            this.pnSearchShop.Size = new System.Drawing.Size(581, 82);
            this.pnSearchShop.TabIndex = 2;
            // 
            // pnMainSearch
            // 
            this.pnMainSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnMainSearch.Controls.Add(this.pnResultSearch);
            this.pnMainSearch.Controls.Add(this.txtSearch);
            this.pnMainSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainSearch.Location = new System.Drawing.Point(0, 0);
            this.pnMainSearch.Name = "pnMainSearch";
            this.pnMainSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnMainSearch.Size = new System.Drawing.Size(505, 82);
            this.pnMainSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(10, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Lime;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(485, 46);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.picSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(505, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(76, 82);
            this.guna2Panel1.TabIndex = 1;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Honeydew;
            this.picSearch.Image = global::App_Library.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(6, 7);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(59, 48);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 0;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click_1);
            // 
            // geTextBoxSerch
            // 
            this.geTextBoxSerch.BorderRadius = 40;
            this.geTextBoxSerch.TargetControl = this.txtSearch;
            // 
            // geButtonSearch
            // 
            this.geButtonSearch.BorderRadius = 30;
            this.geButtonSearch.TargetControl = this.picSearch;
            // 
            // pnMainForm
            // 
            this.pnMainForm.AutoScroll = true;
            this.pnMainForm.BackColor = System.Drawing.Color.Honeydew;
            this.pnMainForm.Controls.Add(this.pnAd);
            this.pnMainForm.Controls.Add(this.pnNewItem);
            this.pnMainForm.Controls.Add(this.pnBestDeal);
            this.pnMainForm.Controls.Add(this.guna2Panel6);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainForm.Location = new System.Drawing.Point(0, 100);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(1030, 580);
            this.pnMainForm.TabIndex = 2;
            // 
            // pnAd
            // 
            this.pnAd.BackColor = System.Drawing.Color.Transparent;
            this.pnAd.Controls.Add(this.pnContainAd);
            this.pnAd.Location = new System.Drawing.Point(3, 3);
            this.pnAd.Name = "pnAd";
            this.pnAd.Size = new System.Drawing.Size(1030, 350);
            this.pnAd.TabIndex = 2;
            // 
            // pnContainAd
            // 
            this.pnContainAd.Location = new System.Drawing.Point(4, 0);
            this.pnContainAd.Name = "pnContainAd";
            this.pnContainAd.Size = new System.Drawing.Size(1011, 347);
            this.pnContainAd.TabIndex = 0;
            // 
            // pnNewItem
            // 
            this.pnNewItem.BackColor = System.Drawing.Color.Transparent;
            this.pnNewItem.Controls.Add(this.guna2Panel2);
            this.pnNewItem.Controls.Add(this.flowpnNewItem);
            this.pnNewItem.Location = new System.Drawing.Point(0, 356);
            this.pnNewItem.Margin = new System.Windows.Forms.Padding(0);
            this.pnNewItem.Name = "pnNewItem";
            this.pnNewItem.Size = new System.Drawing.Size(1030, 500);
            this.pnNewItem.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1030, 70);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Green;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Location = new System.Drawing.Point(13, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(250, 61);
            this.guna2Panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEW ITEMS";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = global::App_Library.Properties.Resources.Screenshot_2024_12_13_003940;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::App_Library.Properties.Resources.new_17204014;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(47, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // flowpnNewItem
            // 
            this.flowpnNewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpnNewItem.Location = new System.Drawing.Point(0, 0);
            this.flowpnNewItem.Name = "flowpnNewItem";
            this.flowpnNewItem.Size = new System.Drawing.Size(1030, 500);
            this.flowpnNewItem.TabIndex = 1;
            this.flowpnNewItem.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowpnNewItem_Scroll);
            // 
            // pnBestDeal
            // 
            this.pnBestDeal.BackColor = System.Drawing.Color.Transparent;
            this.pnBestDeal.Controls.Add(this.flowpnBestDeal);
            this.pnBestDeal.Controls.Add(this.guna2Panel4);
            this.pnBestDeal.Location = new System.Drawing.Point(0, 856);
            this.pnBestDeal.Margin = new System.Windows.Forms.Padding(0);
            this.pnBestDeal.Name = "pnBestDeal";
            this.pnBestDeal.Size = new System.Drawing.Size(1030, 500);
            this.pnBestDeal.TabIndex = 4;
            // 
            // flowpnBestDeal
            // 
            this.flowpnBestDeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpnBestDeal.Location = new System.Drawing.Point(0, 70);
            this.flowpnBestDeal.Name = "flowpnBestDeal";
            this.flowpnBestDeal.Size = new System.Drawing.Size(1030, 430);
            this.flowpnBestDeal.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1030, 70);
            this.guna2Panel4.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.White;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Green;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 3;
            this.guna2Panel5.Controls.Add(this.label2);
            this.guna2Panel5.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel5.Location = new System.Drawing.Point(7, 6);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(250, 61);
            this.guna2Panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(60, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "BEST DEAL";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackgroundImage = global::App_Library.Properties.Resources.Screenshot_2024_12_13_003940;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::App_Library.Properties.Resources.hot_sale_17905376;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(7, 7);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(47, 46);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.Controls.Add(this.pnContainAllBook);
            this.guna2Panel6.Location = new System.Drawing.Point(0, 1356);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(1030, 70);
            this.guna2Panel6.TabIndex = 5;
            // 
            // pnContainAllBook
            // 
            this.pnContainAllBook.BackColor = System.Drawing.Color.Honeydew;
            this.pnContainAllBook.Controls.Add(this.guna2Button1);
            this.pnContainAllBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainAllBook.Location = new System.Drawing.Point(0, 0);
            this.pnContainAllBook.Name = "pnContainAllBook";
            this.pnContainAllBook.Size = new System.Drawing.Size(1030, 70);
            this.pnContainAllBook.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Honeydew;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Green;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Green;
            this.guna2Button1.Location = new System.Drawing.Point(466, 6);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "SEE MORE ...";
            this.guna2Button1.Click += new System.EventHandler(this.btnViewAllBook_Click);
            // 
            // pnContainSearch
            // 
            this.pnContainSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainSearch.Controls.Add(this.pnSearch);
            this.pnContainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainSearch.Location = new System.Drawing.Point(0, 0);
            this.pnContainSearch.Name = "pnContainSearch";
            this.pnContainSearch.Size = new System.Drawing.Size(1030, 100);
            this.pnContainSearch.TabIndex = 0;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.pnSearchShop);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1030, 100);
            this.pnSearch.TabIndex = 6;
            // 
            // pnResultSearch
            // 
            this.pnResultSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnResultSearch.Location = new System.Drawing.Point(10, 56);
            this.pnResultSearch.Name = "pnResultSearch";
            this.pnResultSearch.Size = new System.Drawing.Size(485, 16);
            this.pnResultSearch.TabIndex = 0;
            // 
            // NewShopMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1030, 680);
            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(this.pnContainSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewShopMain";
            this.Text = "NewShopMain";
            this.Load += new System.EventHandler(this.NewShopMain_LoadAsync);
            this.Resize += new System.EventHandler(this.NewShopMain_Resize);
            this.pnSearchShop.ResumeLayout(false);
            this.pnMainSearch.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnMainForm.ResumeLayout(false);
            this.pnAd.ResumeLayout(false);
            this.pnNewItem.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnBestDeal.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.pnContainAllBook.ResumeLayout(false);
            this.pnContainSearch.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnContainSearch;
        private System.Windows.Forms.Panel pnProperties;
        private System.Windows.Forms.FlowLayoutPanel pnMainForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse geSearch;
        private Guna.UI2.WinForms.Guna2Elipse geTextBoxSerch;
        private Guna.UI2.WinForms.Guna2Elipse geButtonSearch;
        private Guna.UI2.WinForms.Guna2Panel pnNewItem;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Panel pnSearchShop;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox picSearch;
        private Guna.UI2.WinForms.Guna2Panel pnAd;
        private Guna.UI2.WinForms.Guna2Panel pnBestDeal;
        private Guna.UI2.WinForms.Guna2Panel pnContainAd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.FlowLayoutPanel flowpnNewItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowpnBestDeal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel pnContainAllBook;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel pnMainSearch;
        private System.Windows.Forms.FlowLayoutPanel pnResultSearch;
    }
}