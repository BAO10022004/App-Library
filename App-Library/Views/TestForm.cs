using App_Library.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class TestForm : Form
    {
        FirebaseService _firebase;
        public TestForm()
        {
            InitializeComponent();
            _firebase = new FirebaseService();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathImage.Text = openFileDialog.FileName;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string urlImage = "";
            if (!string.IsNullOrWhiteSpace(txtPathImage.Text))
            {
                urlImage = await _firebase.UploadFileAsync(txtPathImage.Text, "pdfs");
            }
            Console.WriteLine(urlImage);
        }
    }
}
