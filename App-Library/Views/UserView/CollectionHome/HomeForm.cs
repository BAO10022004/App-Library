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
    public partial class HomeForm : FormHelper
    {
        BookSoldService bookSoldService;
        MainForm main;
        private readonly AuthService _authService;
        public HomeForm(MainForm main)
        {
            this.Size = main.Size;
            InitializeComponent();
            bookSoldService = new BookSoldService();
            this.main = main;

                pnNameForm.Controls.Remove(pnBack);
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            lbNumberBoughtBook.Text =(await bookSoldService.GetBoughtBooksAsync()).Count.ToString();
            BookService bookService = new BookService();
            List<Book> bookForUser = new List<Book>();
            var result = await bookSoldService.GetBooksInProgressAsync();
            //this.Controls.Remove(pnNameForm);
            lbNumberHistory.Text = result.Count.ToString();
            var lisBookPending = new List<BookSold>();
            foreach (BookSold bookSold in result)
            {
                if(!bookSold.Status.Equals("Approved"))
                {
                    lisBookPending.Add(bookSold);
                }
            }
            lbProcessing.Text = lisBookPending.Count.ToString();
        }
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            lbNameForm.Location = new Point((pnNameForm.Width - lbNameForm.Width) / 2, (pnNameForm.Height - lbNameForm.Height) / 2);
            pnGroup1.Width = this.Width / 2-10;
            pnGroup.Width = this.Width / 2-10;
            btnBoughtBook.Location =new Point( (pnGroup1.Width - btnBoughtBook.Width) / 2, btnBoughtBook.Location.Y);
            btnProcessing.Location = new Point((pnGroup2.Width - btnProcessing.Width) / 2, btnProcessing.Location.Y);
            pnHistory.Location = new Point((pnGroup2.Width - btnProcessing.Width) / 2, pnHistory.Location.Y);
            pnProFile.Location = new Point((pnGroup1.Width - btnBoughtBook.Width) / 2, pnProFile.Location.Y);
        }
        Form actForm;
        private async void label4_Click(object sender, EventArgs e)
        {
            pnNameForm.Controls.Add(pnBack);

            BookService bookService = new BookService();
            List<Book> bookForUser = new List<Book>();
            List<BookSold> bookSolds = new List<BookSold>();
            bookSolds =await bookSoldService.GetBoughtBooksAsync();
            
            foreach(BookSold bookSold in bookSolds)
            {
                Book book = new Book();
                book =await bookService.GetBookBySlugAsync(bookSold.Slug);
                bookForUser.Add(book);
            }
            activeFormChild(pnMain, new BoughtBook(bookForUser), null,ref actForm);
            lbNameForm.Text = "BOUGHT BOOK";
            HomeForm_Resize(sender,e);
        }
        Form actFormFrofile;
        private void lbProfile_Click(object sender, EventArgs e)
        {
            pnNameForm.Controls.Add(pnBack);
            this.Controls.Remove(pnNameForm);
            activeFormChild(pnMain, new ProfileForm(), null, ref actFormFrofile);
        }

        private async void label2_Click_1(object sender, EventArgs e)
        {
            pnNameForm.Controls.Add(pnBack);
            lbNameForm.Text = "HISTORY";
            BookService bookService = new BookService();
            List<Book> bookForUser = new List<Book>();
            var result =await bookSoldService.GetBooksInProgressAsync();
            activeFormChild(pnMain, new HistoryForm(result), null, ref actFormFrofile);
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            
                main.clickBackHome(sender, e);
        }
    }
}
