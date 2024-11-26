namespace App_Library.Views.AdminView.CollectionUpload
{
    partial class UploadForm
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
            this.pnContent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtPathFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPathImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChooseFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnChooseImage = new Guna.UI2.WinForms.Guna2Button();
            this.txtContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudPirce = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudPubYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublishedYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUploadFile = new System.Windows.Forms.Label();
            this.lblUploadImage = new System.Windows.Forms.Label();
            this.errorProviderTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGenre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPubYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContent = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPirce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPubYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPubYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnContent.Controls.Add(this.txtUsername);
            this.pnContent.Controls.Add(this.label1);
            this.pnContent.Controls.Add(this.lblTitleForm);
            this.pnContent.Controls.Add(this.btnSubmit);
            this.pnContent.Controls.Add(this.txtPathFile);
            this.pnContent.Controls.Add(this.txtPathImage);
            this.pnContent.Controls.Add(this.btnChooseFile);
            this.pnContent.Controls.Add(this.btnChooseImage);
            this.pnContent.Controls.Add(this.txtContent);
            this.pnContent.Controls.Add(this.nudPirce);
            this.pnContent.Controls.Add(this.nudPubYear);
            this.pnContent.Controls.Add(this.txtGenre);
            this.pnContent.Controls.Add(this.txtAuthor);
            this.pnContent.Controls.Add(this.txtTitle);
            this.pnContent.Controls.Add(this.lblContent);
            this.pnContent.Controls.Add(this.lblPrice);
            this.pnContent.Controls.Add(this.lblPublishedYear);
            this.pnContent.Controls.Add(this.lblGenre);
            this.pnContent.Controls.Add(this.lblAuthor);
            this.pnContent.Controls.Add(this.lblTitle);
            this.pnContent.Controls.Add(this.lblUploadFile);
            this.pnContent.Controls.Add(this.lblUploadImage);
            this.pnContent.Location = new System.Drawing.Point(155, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(720, 680);
            this.pnContent.TabIndex = 0;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(225, 15);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(270, 40);
            this.lblTitleForm.TabIndex = 42;
            this.lblTitleForm.Text = "UPLOAD BOOK";
            this.lblTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BorderRadius = 20;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(292, 620);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 40);
            this.btnSubmit.TabIndex = 41;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPathFile
            // 
            this.txtPathFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathFile.DefaultText = "";
            this.txtPathFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPathFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPathFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathFile.Location = new System.Drawing.Point(190, 162);
            this.txtPathFile.Margin = new System.Windows.Forms.Padding(5);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.PasswordChar = '\0';
            this.txtPathFile.PlaceholderText = "";
            this.txtPathFile.SelectedText = "";
            this.txtPathFile.Size = new System.Drawing.Size(352, 26);
            this.txtPathFile.TabIndex = 40;
            // 
            // txtPathImage
            // 
            this.txtPathImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathImage.DefaultText = "";
            this.txtPathImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPathImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPathImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathImage.Location = new System.Drawing.Point(190, 116);
            this.txtPathImage.Margin = new System.Windows.Forms.Padding(5);
            this.txtPathImage.Name = "txtPathImage";
            this.txtPathImage.PasswordChar = '\0';
            this.txtPathImage.PlaceholderText = "";
            this.txtPathImage.SelectedText = "";
            this.txtPathImage.Size = new System.Drawing.Size(352, 26);
            this.txtPathImage.TabIndex = 39;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BorderRadius = 5;
            this.btnChooseFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.Location = new System.Drawing.Point(550, 163);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(120, 25);
            this.btnChooseFile.TabIndex = 38;
            this.btnChooseFile.Text = "Choose Image";
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BorderRadius = 5;
            this.btnChooseImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.Location = new System.Drawing.Point(550, 117);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(120, 25);
            this.btnChooseImage.TabIndex = 37;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtContent
            // 
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultText = "";
            this.txtContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.Location = new System.Drawing.Point(190, 438);
            this.txtContent.Margin = new System.Windows.Forms.Padding(5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderText = "";
            this.txtContent.SelectedText = "";
            this.txtContent.Size = new System.Drawing.Size(480, 162);
            this.txtContent.TabIndex = 36;
            // 
            // nudPirce
            // 
            this.nudPirce.BackColor = System.Drawing.Color.Transparent;
            this.nudPirce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPirce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPirce.Location = new System.Drawing.Point(190, 392);
            this.nudPirce.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPirce.Name = "nudPirce";
            this.nudPirce.Size = new System.Drawing.Size(480, 26);
            this.nudPirce.TabIndex = 35;
            // 
            // nudPubYear
            // 
            this.nudPubYear.BackColor = System.Drawing.Color.Transparent;
            this.nudPubYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPubYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPubYear.Location = new System.Drawing.Point(190, 346);
            this.nudPubYear.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudPubYear.Name = "nudPubYear";
            this.nudPubYear.Size = new System.Drawing.Size(480, 26);
            this.nudPubYear.TabIndex = 34;
            // 
            // txtGenre
            // 
            this.txtGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenre.DefaultText = "";
            this.txtGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenre.Location = new System.Drawing.Point(190, 300);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(5);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PasswordChar = '\0';
            this.txtGenre.PlaceholderText = "";
            this.txtGenre.SelectedText = "";
            this.txtGenre.Size = new System.Drawing.Size(480, 26);
            this.txtGenre.TabIndex = 33;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Location = new System.Drawing.Point(190, 254);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.PlaceholderText = "";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(480, 26);
            this.txtAuthor.TabIndex = 32;
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(190, 208);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(480, 26);
            this.txtTitle.TabIndex = 31;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(50, 438);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(66, 20);
            this.lblContent.TabIndex = 30;
            this.lblContent.Text = "Content";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(50, 392);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price";
            // 
            // lblPublishedYear
            // 
            this.lblPublishedYear.AutoSize = true;
            this.lblPublishedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishedYear.Location = new System.Drawing.Point(50, 346);
            this.lblPublishedYear.Name = "lblPublishedYear";
            this.lblPublishedYear.Size = new System.Drawing.Size(116, 20);
            this.lblPublishedYear.TabIndex = 28;
            this.lblPublishedYear.Text = "Published Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(50, 300);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 27;
            this.lblGenre.Text = "Genre";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(50, 254);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 26;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 208);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title";
            // 
            // lblUploadFile
            // 
            this.lblUploadFile.AutoSize = true;
            this.lblUploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadFile.Location = new System.Drawing.Point(50, 162);
            this.lblUploadFile.Name = "lblUploadFile";
            this.lblUploadFile.Size = new System.Drawing.Size(89, 20);
            this.lblUploadFile.TabIndex = 24;
            this.lblUploadFile.Text = "Upload File";
            // 
            // lblUploadImage
            // 
            this.lblUploadImage.AutoSize = true;
            this.lblUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadImage.Location = new System.Drawing.Point(50, 117);
            this.lblUploadImage.Name = "lblUploadImage";
            this.lblUploadImage.Size = new System.Drawing.Size(109, 20);
            this.lblUploadImage.TabIndex = 23;
            this.lblUploadImage.Text = "Upload Image";
            // 
            // errorProviderTitle
            // 
            this.errorProviderTitle.ContainerControl = this;
            // 
            // errorProviderAuthor
            // 
            this.errorProviderAuthor.ContainerControl = this;
            // 
            // errorProviderGenre
            // 
            this.errorProviderGenre.ContainerControl = this;
            // 
            // errorProviderPubYear
            // 
            this.errorProviderPubYear.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // errorProviderContent
            // 
            this.errorProviderContent.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.Enabled = false;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(190, 70);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(480, 26);
            this.txtUsername.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "User Upload";
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 680);
            this.Controls.Add(this.pnContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UploadForm";
            this.Text = "UploadForm";
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPirce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPubYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPubYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnContent;
        private Guna.UI2.WinForms.Guna2TextBox txtPathFile;
        private Guna.UI2.WinForms.Guna2TextBox txtPathImage;
        private Guna.UI2.WinForms.Guna2Button btnChooseFile;
        private Guna.UI2.WinForms.Guna2Button btnChooseImage;
        private Guna.UI2.WinForms.Guna2TextBox txtContent;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPirce;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPubYear;
        private Guna.UI2.WinForms.Guna2TextBox txtGenre;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublishedYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUploadFile;
        private System.Windows.Forms.Label lblUploadImage;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.ErrorProvider errorProviderTitle;
        private System.Windows.Forms.ErrorProvider errorProviderAuthor;
        private System.Windows.Forms.ErrorProvider errorProviderGenre;
        private System.Windows.Forms.ErrorProvider errorProviderPubYear;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.ErrorProvider errorProviderContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label1;
    }
}