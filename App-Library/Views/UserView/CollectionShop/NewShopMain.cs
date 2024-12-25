using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionShop;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace App_Library.Views.Main.CollectionShop
{

    public partial class NewShopMain : FormHelper
    {
        // database
        internal List<PanelBook> listPanelAllBook;
        internal List<Book> listBook;
        List<Task<PanelBook>> listTask;
        private readonly BookService _bookService;
        private readonly BookSoldService _bookSoldService;
        internal List<BookSold> listBookSold;
        //Process Bar
        Guna2ProgressIndicator guna2ProgressIndicator;
        //Control
        Form formAd;
        Form formHotDeal;
        // size properties
        // check button option view  click
        internal MainForm controller;
        // Save main form 
        FlowLayoutPanel pnSaveForm = new FlowLayoutPanel();

        public NewShopMain(MainForm controller)
        {
            _bookService = new BookService();
            _bookSoldService = new BookSoldService();
            listTask = new List<Task<PanelBook>>();
            InitializeComponent();
            pnProperties = new Panel();
            this.pnProperties.BackColor = System.Drawing.Color.Transparent;
            this.pnProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnProperties.Location = new System.Drawing.Point(1011, 200);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(19, 480);
            this.pnProperties.TabIndex = 1;
            this.pnProperties.Visible = false;

            this.controller = controller;

        }

        private async void NewShopMain_LoadAsync(object sender, EventArgs e)
        {
            // clear controll

            guna2ProgressIndicator = new Guna2ProgressIndicator();
            guna2ProgressIndicator.Start();
            guna2ProgressIndicator.ProgressColor = Color.Navy;
            guna2ProgressIndicator.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
            this.Controls.Add(guna2ProgressIndicator);
            listPanelAllBook = new List<PanelBook>();
            // Create Data for book
            listBook = await _bookService.GetBooksAsync();
            listBookSold = await _bookSoldService.GetBoughtBooksAsync();

            // Check click
            backgroundWorker1.RunWorkerAsync();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < listBook.Count; i++)
            {
                var task = listBook[i].CreateBookPanelAsync(i, 4);
                if (await task != null)
                {
                    backgroundWorker1.ReportProgress(0, task);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listTask.Add(e.UserState as Task<PanelBook>);
        }
        Form actForm1;
        Form actForm2;
        Form actForm3;
        private async void backgroundWorker1_RunWorkerCompletedAsync(object sender, RunWorkerCompletedEventArgs e)
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
                listPanelAllBook = ((await Task.WhenAll(listTask)).ToList());
                listBookSold = await controller.getListSold();

                formAd = new AdForm(this);
                activeFormChild(pnContainAd, formAd, null, ref actForm1);
                var books = await (new BookService()).GetBooksAsync();
                var bookNewItem = books.OrderBy(book => book.CreatedAt).ToList();
                flowpnNewItem.AutoScroll = true;
                flowpnNewItem.AutoScrollMinSize = new Size((books.Count + 1) * 400, 400);
                for (int i = 0; i < 7; i++)
                {
                    flowpnNewItem.Controls.Add(createPanel(bookNewItem[i], i, pnNewItem));
                }
                var bookHotDeal = books.OrderBy(book => book.Price).ToList();
                flowpnBestDeal.AutoScroll = true;
                flowpnBestDeal.AutoScrollMinSize = new Size((bookHotDeal.Count + 1) * 300, 400);
                for (int i = 0; i < bookHotDeal.Count; i++)
                {
                    flowpnBestDeal.Controls.Add(createPanel(bookHotDeal[i], i, pnBestDeal));
                }
                guna2ProgressIndicator.Stop();
                this.Controls.Remove(guna2ProgressIndicator);

                this.Controls.Remove(this.pnProperties);

                flowpnNewItem.AutoScrollMinSize = new Size((books.Count + 1) * 400, 400);
                ReSize();
                int h = 0;
                foreach (Control control in pnMainForm.Controls)
                {
                    h += control.Height + 10;
                }
                pnMainForm.AutoScrollMinSize = new Size(0, h);
                txtSearch.TabStop = false;
            }
        }
        public Guna2Panel createPanel(Book book, int index, Panel parent)
        {
            Form form = null;
            PanelBook gn = new PanelBook(book, parent);
            gn.Size = new System.Drawing.Size(250, 400);
            gn.TabIndex = index;
            activeFormChild(gn, new BookItem(gn, this), null, ref form);
            return gn;
        }
        Form formContent;
        internal void back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(pnContainSearch);
            ReSize();
        }
        Form actFormProperti;
        public void openProp(PropertiesBookForm form)
        {
            activeFormChild(controller.pnContent, form, null, ref actFormProperti);
        }
        internal async void bookClick(Book book, PanelBook panelBook = null)
        {
            this.Controls.Clear();
            var dbBooks = listBookSold;
            StarsRatingService ratingService = new StarsRatingService();
            BookRating starsRating = await (new StarsRatingService()).GetBookRatingAsync(book.Id);
            PropertiesBookForm form;
            if (starsRating == null)
            {
                form = new PropertiesBookForm(book, 4, this, dbBooks);
            }
            else
            {
                form = new PropertiesBookForm(book, starsRating.TotalRatings, this, dbBooks);
            }

            if (panelBook != null)
            {
                activeFormChild(controller.pnContent, new AnimationProperties(panelBook, this, form), null, ref actFormProperti);
            }
            else
            {
                openProp(form);
            }
        }
        Guna2Panel btnClicked = new Guna2Panel();
        Label txtClicked = new Label();
       
        Form formMain;

        void ReSize()
        {

            pnSearchShop.Location = new Point((pnSearch.Width - pnSearchShop.Width) / 2, (pnSearch.Height - pnSearchShop.Height) / 2);
            pnMainForm.Size = new Size(this.Width - 30, pnMainForm.Height);
            pnContainSearch.Size = new Size(this.Width - 30, pnContainSearch.Height);
            pnAd.Size = new Size(pnMainForm.Width, pnAd.Height);
            pnBestDeal.Size = new Size(pnMainForm.Width, pnBestDeal.Height);
            pnNewItem.Size = new Size(pnMainForm.Width, pnNewItem.Height);
            pnContainAd.Location = new Point((pnAd.Width - pnContainAd.Width) / 2, (pnAd.Height - pnContainAd.Height) / 2);

        }
        private void NewShopMain_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show("HI");
            ReSize();
        }

         public  void refreshData()
            {
                controller.dataBind();
            }
        public Guna2Panel createPanelSearch(Book book, int index)
        {
            Form form = null;
            Guna2Panel gn = new Guna2Panel();
            gn.Size = new System.Drawing.Size(500, 100);
            gn.TabIndex = index;
            gn.Margin = new Padding(5);
            activeFormChild(gn, new BookItemSearch(book, this), null, ref form);
            return gn;
        }
        private async void picSearch_Click(object sender, EventArgs e)
        {
            pnMainSearch.Controls.Clear();
            pnMainSearch.Controls.Add(txtSearch);

            List<Book> result = (await _bookService.SearchBooksAsync(txtSearch.Text)).Books;
            pnSearchShop.Height = 550;
            pnSearchShop.Size = new Size(pnSearchShop.Width, 50 + txtSearch.Margin.Top + txtSearch.Margin.Bottom + txtSearch.Height + (result.Count + 1) * 105);
            pnContainSearch.Size = new Size(pnContainSearch.Width, pnSearchShop.Height + 50);
            for (int i = 0; i < result.Count; i++)
            {
                pnMainSearch.Controls.Add(createPanelSearch(result[i], i));
            }

        }

        private void pnSearch_Click(object sender, EventArgs e)
        {
           
        }
        public Point GetLocationFormNewItem(Panel panel)
        {
            // Lấy tọa độ của panel trong form
            Point controlPosition = panel.Location;

            // Lấy vị trí cuộn hiện tại của flowpnNewItem
            Point scrollPosition = flowpnNewItem.AutoScrollPosition;

            // Điều chỉnh lại tọa độ của control trong panel theo vị trí cuộn
            Point controlPositionInPanel = new Point(
                controlPosition.X - scrollPosition.X,
                controlPosition.Y - scrollPosition.Y
            );

            // Tính toán lại vị trí của item trong panel với một offset nhất định
            // Lấy vị trí của panel cha và cộng thêm offset
            Point result = new Point();
            result.X = controlPositionInPanel.X + scrollPosition.X;
            result.Y = getLocationFormMain(pnNewItem).Y + 100; // Cộng thêm một offset để điều chỉnh vị trí

            return result;
        }

        public Point getLocationFormMain(Panel panel)
        {
            // Lấy tọa độ của panel trong form
            Point controlPosition = panel.Location;

            // Lấy vị trí cuộn hiện tại của pnMainForm
            Point scrollPosition = pnMainForm.AutoScrollPosition;
            Point controlPositionInPanel = new Point(
                controlPosition.X - scrollPosition.X,
                controlPosition.Y - scrollPosition.Y
            );
            // Điều chỉnh lại tọa độ của control trong panel cha theo vị trí cuộn
            Point result = new Point();
            result.X = controlPosition.X + scrollPosition.X;
            result.Y = controlPositionInPanel.Y + scrollPosition.Y; // Cộng thêm một offset để điều chỉnh vị trí

            return result;
        }
        public Point GetLocationFormsBestDeal(Panel panel)
        {
            Point controlPosition = panel.Location;

            // Lấy vị trí cuộn hiện tại của flowpnNewItem
            Point scrollPosition = flowpnBestDeal.AutoScrollPosition;

            // Điều chỉnh lại tọa độ của control trong panel theo vị trí cuộn
            Point controlPositionInPanel = new Point(
                controlPosition.X - scrollPosition.X,
                controlPosition.Y - scrollPosition.Y
            );

            // Tính toán lại vị trí của item trong panel với một offset nhất định
            // Lấy vị trí của panel cha và cộng thêm offset
            Point result = new Point();
            result.X = controlPositionInPanel.X + scrollPosition.X;
            result.Y = getLocationFormMain(pnBestDeal).Y + 100; // Cộng thêm một offset để điều chỉnh vị trí

            return result;
        }

        private void flowpnNewItem_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private async void btnViewAllBook_Click(object sender, EventArgs e)
        {
            listBook =await _bookService.GetBooksAsync();
            activeFormChild(controller.pnContent, new ViewBookForm(this, listBook), null, ref actFormProperti);
        }

        private async void picSearch_Click_1(object sender, EventArgs e)
        {


            List<Book> result = (await _bookService.SearchBooksAsync(txtSearch.Text)).Books;
           
            activeFormChild(controller.pnContent, new ViewBookForm(this, result), null, ref actFormProperti);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(!txtSearch.Text.Equals(""))
            {
            
                BookService dbBook = new BookService();
                List<Book> result = (await dbBook.SearchBooksAsync(txtSearch.Text)).Books;
                pnSearchShop.Height = 550;
                pnResultSearch.Controls.Clear();
                pnSearchShop.Size = new Size(pnSearchShop.Width, 50 + txtSearch.Margin.Top + txtSearch.Margin.Bottom + txtSearch.Height + (result.Count ) * 105);
                pnContainSearch.Size = new Size(pnContainSearch.Width, pnSearchShop.Height + 50);
                for (int i = 0; i < result.Count; i++)
                {
                    pnResultSearch.Controls.Add(createPanelSearch(result[i], i));
                }
            }
            else
            {
                pnResultSearch.Controls.Clear();
                pnSearchShop.Height = 82;
                pnContainSearch.Size = new Size(pnContainSearch.Width, pnSearchShop.Height + 50);
            }
            

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
           txtSearch_TextChanged(sender, e);
        }
    }
}
