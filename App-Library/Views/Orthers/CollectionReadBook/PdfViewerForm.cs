using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class PdfViewerForm : Form
    {
        private WebView2 webView;

        public PdfViewerForm(String stringPdf)
        {
            InitializeComponent();
            InitializeWebView();
            LoadPdfFromUrl(stringPdf);
        }

        private async void InitializeWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(webView);

            // Đảm bảo WebView2 được khởi tạo
            await webView.EnsureCoreWebView2Async(null);
        }

        public async void LoadPdfFromUrl(string pdfUrl)
        {
            // Gán URL trực tiếp từ Firebase cho WebView2 để hiển thị PDF
            webView.Source = new Uri(pdfUrl);
        }
    }
}
