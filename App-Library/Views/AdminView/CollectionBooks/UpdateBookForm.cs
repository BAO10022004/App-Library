using App_Library.Models;
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

namespace App_Library.Views.AdminView.CollectionBooks
{
    public partial class UpdateBookForm : Form
    {
        Book _book;
        FirebaseService _firebase;
        BookService _bookService;
        public UpdateBookForm(Book book)
        {
            InitializeComponent();
            _bookService = new BookService();
            _firebase = new FirebaseService();
            _book = book;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtContent.Text = book.Content;
            txtGenre.Text = book.Genre;
            nudPirce.Value = book.Price;
            nudPubYear.Value = book.PublishedYear;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckTitle() && CheckAuthor() && CheckGenre() && CheckPubYear() && CheckPrice() && CheckContent())
            {
                string urlImage = _book.Image, urlFile = _book.PdfUrl;
                if (!string.IsNullOrWhiteSpace(txtPathImage.Text))
                {
                    urlImage = await _firebase.UploadFileAsync(txtPathImage.Text, "images");
                }
                if (!string.IsNullOrWhiteSpace(txtPathFile.Text))
                {
                    urlFile = await _firebase.UploadFileAsync(txtPathFile.Text, "pdfs");
                }

                var updateBook = new UpdateBookDTO
                {
                    Username = Session.CurentUser.Username,
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Genre = txtGenre.Text,
                    PublishedYear = (int)nudPubYear.Value,
                    Price = nudPirce.Value,
                    Content = txtContent.Text,
                    Image = urlImage,
                    PdfUrl = urlFile
                };

                var result = await _bookService.UpdateBookAsync(_book.Id, updateBook);
                this.Close();
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
    }
}
