using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.Orthers.CollectionProfile;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionHome;
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
    public partial class StockForm : FormHelper
    {
        BookSoldService bookSoldService;
        MainForm main;
        Form actForm;
        private readonly AuthService _authService;
        public StockForm(MainForm main)
        {
            this.Size = main.Size;
            InitializeComponent();
            bookSoldService = new BookSoldService();
            this.main = main;
            
        }

        private async void StockForm_Load(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            var dbBookBold =await (new BookSoldService()).GetBoughtBooksAsync();
            List<Book> listBook = new List<Book>();
            foreach (var book in dbBookBold)
            {
                listBook.Add(await bookService.GetBookBySlugAsync(book.Slug));
            }
            activeFormChild(pnMain, new BoughtBook(listBook), null, ref actForm);
        }
    }
}
