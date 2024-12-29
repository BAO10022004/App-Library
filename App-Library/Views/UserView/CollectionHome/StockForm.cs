using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView;
using App_Library.Views.UserView.CollectionHome;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class StockForm : FormHelper
    {
        BookSoldService bookSoldService;
        SideBarUserForm controller;
        Form actForm;
        List<BookSold> listBook;
        private readonly AuthService _authService;
        public StockForm(SideBarUserForm controller , List<BookSold> listBook)
        {
            InitializeComponent();
            bookSoldService = new BookSoldService();
            this.listBook = new List<BookSold>();
            this.listBook = listBook;   
            this.controller = controller;
            
        }

        private async void StockForm_Load(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            List<Book> listBookBought = new List<Book>();
            if(listBook == null || listBook.Count == 0)
            {
                
            }
            else
            {
                foreach (var book in listBook)
                {
                    if (book.Status.Equals("Approved"))
                        listBookBought.Add(await (new BookService()).GetBookBySlugAsync(book.Slug));
                }
                if(!( listBookBought.Count == 0))
                {
                    pnMain.Controls.Clear();
                    activeFormChild(pnContent, new BoughtBook(listBookBought), null, ref actForm);
                }
            }
        }

        private void btnNextShop_Click(object sender, EventArgs e)
        {
            controller.lbHome_Click(controller.btnHome, e);
        }
    }
}
