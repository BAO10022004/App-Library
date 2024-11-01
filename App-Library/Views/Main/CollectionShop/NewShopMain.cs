using App_Library.Models;
using App_Library.Services;
using App_Library.Services.Interfaces;
using App_Library.Views.ToolerForm;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace App_Library.Views.Main.CollectionShop
{

    public partial class NewShopMain : FormHelper
    {
        // database
        List<System.Windows.Forms.Panel> listPanelBookAd;
        List<Panel> listPanelAllBook;
        List<Book> listBook;
        List<Task<Panel>> listTaskPanelHotDealBook;
        List<Task<Panel>> listTaskPanelAllBook;
        private readonly MongoDbContext dbContext;
        private readonly IBookService _bookService;
        //Process Bar
        Guna2ProgressIndicator guna2ProgressIndicator;
        // Get Book form panel clicked
        Dictionary<Control, Book> getBookFromPanelAd;
        Dictionary<Control, Book> getBookFromPanelHotDeal;
        public NewShopMain(MongoDbContext context)
        {
            dbContext = context;
            _bookService = new BookService(dbContext);
            InitializeComponent();
        }

        private async void NewShopMain_LoadAsync(object sender, EventArgs e)
        {
            // clear controll
            foreach (Control control in this.Controls)
            {
                if ((control.Visible == true))
                {
                    control.Visible = false;
                }
               
            }
            guna2ProgressIndicator = new Guna2ProgressIndicator();
            guna2ProgressIndicator.Start();
            guna2ProgressIndicator.ProgressColor = Color.Navy;
            guna2ProgressIndicator.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
            this.Controls.Add(guna2ProgressIndicator);
            // Create Map get Book
            getBookFromPanelAd = new Dictionary<Control, Book>();
            listPanelBookAd = new List<Panel>();
            listPanelAllBook = new List<Panel>();
            listTaskPanelAllBook = new List<Task<Panel>>();
            // Create Data for book
            listBook = await _bookService.GetAllBooksAsync();
            activeFormChild(pnHotDeal, new HotDealForm(listPanelAllBook), e);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                var bookPanel = CreateBookAdPanel(listBook[i], i, 4);
                if (bookPanel != null)
                {
                    getBookFromPanelAd[bookPanel] = listBook[i];

                    backgroundWorker1.ReportProgress(0, bookPanel);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var bookPanel = e.UserState as Panel;
            if(listPanelBookAd.Count < 6)
            {
                listPanelBookAd.Add(bookPanel);
            }
            listPanelAllBook.Add(bookPanel);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Công việc đã bị hủy.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Có lỗi xảy ra: " + e.Error.Message);
            }
            else
            {
                // Ope 
                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }
               // activeFormChild(pnHotDeal, new HotDealForm(listPanelBookAd), e);
               activeFormChild(pnAd, new AdForm(listPanelBookAd), e);
                //bwkCreateHotDeal.RunWorkerAsync();
                

            }

         }

        private void bwkCreateHotDeal_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                var TaskBook =CreateBookPanelAsync(listBook[i], i, 4);
                if (TaskBook != null)
                {
                    bwkCreateHotDeal.ReportProgress(0, TaskBook);
                }
            }
        }

        private void bwkCreateHotDeal_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listTaskPanelAllBook.Add(e.UserState as Task<Panel>);
        }

        private async void bwkCreateHotDeal_RunWorkerCompletedAsync(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Công việc đã bị hủy.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Có lỗi xảy ra: " + e.Error.Message);
            }
            else
            {
                var panels = (await Task.WhenAll(listTaskPanelAllBook)).ToList();
                listPanelAllBook = (await Task.WhenAll(listTaskPanelAllBook)).ToList();
                


            }
        }
    }
}
