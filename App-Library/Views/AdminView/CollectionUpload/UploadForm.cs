using App_Library.Models;
using App_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.AdminView.CollectionUpload
{
    public partial class UploadForm : Form
    {
        FirebaseService _firebase;
        BookService _bookService;
        public UploadForm()
        {
            InitializeComponent();
            _firebase = new FirebaseService();
            _bookService = new BookService();

            txtUsername.Text = Session.CurentUser.Username;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathImage.Text = openFileDialog.FileName;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = openFileDialog.FileName;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckTitle() && CheckAuthor() && CheckGenre() && CheckPubYear() && CheckPrice() && CheckContent())
            {
                string urlImage = "", urlFile = "";
                if (!string.IsNullOrWhiteSpace(txtPathImage.Text))
                {
                    urlImage = await _firebase.UploadFileAsync(txtPathImage.Text, "images");
                }
                if (!string.IsNullOrWhiteSpace(txtPathFile.Text))
                {
                    urlFile = await _firebase.UploadFileAsync(txtPathFile.Text, "pdfs");
                }

                var book = new Book
                {
                    Username = txtUsername.Text,
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Genre = txtGenre.Text,
                    PublishedYear = (int)nudPubYear.Value,
                    Price = nudPirce.Value,
                    Content = txtContent.Text,
                    Image = urlImage,
                    PdfUrl = urlFile
                };

                var result = await _bookService.PostBookAsync(book);
                if (result)
                {
                    MessageBox.Show("dang thanh conog");
                }
                else
                {
                    MessageBox.Show("dang thaats bai");
                }
            }
        }
        private bool CheckTitle()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProviderTitle.SetError(txtTitle, "Please enter title");
                return false;
            }
            else
            {
                errorProviderTitle.SetError(txtTitle, string.Empty);
                return true;
            }
        }
        private bool CheckAuthor()
        {
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                errorProviderAuthor.SetError(txtAuthor, "Please enter author");
                return false;
            }
            else
            {
                errorProviderAuthor.SetError(txtAuthor, string.Empty);
                return true;
            }
        }
        private bool CheckGenre()
        {
            if (string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                errorProviderGenre.SetError(txtGenre, "Please enter genre");
                return false;
            }
            else
            {
                errorProviderGenre.SetError(txtGenre, string.Empty);
                return true;
            }
        }
        private bool CheckPubYear()
        {
            if (nudPubYear.Value == 0)
            {
                errorProviderPubYear.SetError(nudPubYear, "Year must be greater than 0");
                return false;
            }
            else
            {
                errorProviderPubYear.SetError(nudPubYear, string.Empty);
                return true;
            }
        }
        private bool CheckPrice()
        {
            if (nudPirce.Value == 0)
            {
                errorProviderPrice.SetError(nudPirce, "Price must be greater than 0");
                return false;
            }
            else
            {
                errorProviderPrice.SetError(nudPirce, string.Empty);
                return true;
            }
        }
        private bool CheckContent()
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                errorProviderContent.SetError(txtContent, "Please enter content");
                return false;
            }
            else
            {
                errorProviderContent.SetError(txtContent, string.Empty);
                return true;
            }
        }
    }
}
