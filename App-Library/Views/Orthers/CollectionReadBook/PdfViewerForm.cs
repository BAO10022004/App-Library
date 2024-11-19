using App_Library.Services;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class PdfViewerForm : Form
    {
        private WebView2 webView;

        public PdfViewerForm()
        {
            InitializeComponent();
            InitializeWebView();
            LoadPdfFromUrl("https://firebasestorage.googleapis.com/v0/b/reading-book-web.appspot.com/o/pdfs%2F1728644837653to-kill-a-mockingbird.pdf?alt=media&token=f638608f-5bf3-4b21-a3e9-d3a5e671cf91");
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
