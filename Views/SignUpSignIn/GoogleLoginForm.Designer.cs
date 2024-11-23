namespace App_Library.Views.SignIn
{
    partial class GoogleLoginForm
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
            this.webViewGoogle = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewGoogle
            // 
            this.webViewGoogle.AllowExternalDrop = true;
            this.webViewGoogle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.webViewGoogle.CreationProperties = null;
            this.webViewGoogle.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewGoogle.Location = new System.Drawing.Point(11, 11);
            this.webViewGoogle.Margin = new System.Windows.Forms.Padding(2);
            this.webViewGoogle.Name = "webViewGoogle";
            this.webViewGoogle.Size = new System.Drawing.Size(412, 539);
            this.webViewGoogle.TabIndex = 0;
            this.webViewGoogle.ZoomFactor = 1D;
            // 
            // GoogleLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.webViewGoogle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GoogleLoginForm";
            this.Text = "GoogleLoginForm";
            this.Load += new System.EventHandler(this.GoogleLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewGoogle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewGoogle;
    }
}