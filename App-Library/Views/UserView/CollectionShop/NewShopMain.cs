using App_Library.Models;
using App_Library.Services;
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
        internal List<PanelBook> listPanelAllBook;
        internal List<Book> listBook;
        List<Task<PanelBook>> listTask;
        List<Panel> listHotDeal;
        List<Task<Panel>> listTaskPanelHotDealBook;
        List<Task<Panel>> listTaskPanelAllBook;
        private readonly BookService _bookService;
        private readonly BookSoldService _bookSoldService;
        internal List<BookSold> listBookSold;
        List<Book> listBookBestSelling;
        List<Panel> listPanelBestSelling;
        internal readonly UserService _user;
        //Process Bar
        Guna2ProgressIndicator guna2ProgressIndicator;
        // Get Book form panel clicked
        Dictionary<Control, Book> getBookFromPanelAd;
        Dictionary<Control, Book> getBookFromPanelHotDeal;
        //Control
        Form formAd;
        Form formHotDeal;
        // Control.Collection 
        Control.ControlCollection collectionPanelAd;
        Control.ControlCollection collectionPanelHotDeal;
        Control.ControlCollection collectionPanelAll;
        // size properties
        public  int WITH = 1011;
        public const int HEIGHT = 626;
        // check button option view  click
        Dictionary<Control, bool> mapCheckButtonOptionViewIsClick;
        // Save main form 
        Panel pnSaveForm = new Panel();
        public NewShopMain()
        {
            _bookService = new BookService();
            _bookSoldService = new BookSoldService();
            collectionPanelAd = new Control.ControlCollection(new Panel());
            collectionPanelHotDeal = new Control.ControlCollection(new Panel());
            collectionPanelAll = new Control.ControlCollection(new Panel());
            _user = new UserService();
            listTask = new List<Task<PanelBook>>();
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
            getBookFromPanelHotDeal = new Dictionary<Control, Book>();
            listPanelBookAd = new List<Panel>();
            listPanelAllBook = new List<PanelBook>();
            listTaskPanelAllBook = new List<Task<Panel>>();
            listBookBestSelling = new List<Book>();
            listPanelBestSelling = new List<Panel>();
            // Create Data for book
            listBook = await _bookService.GetBooksAsync();
            listBookSold = await _bookSoldService.GetBoughtBooksAsync();
            // Add event handel for View option 
            foreach (Guna2Panel pn in pnOptionViewBook.Controls)
            {
                pn.MouseHover += new EventHandler(this.btnViewAll_MouseHover);
                pn.MouseLeave += new EventHandler(this.btnViewAll_MouseLeave);
                foreach (Control control in pn.Controls)
                {
                    control.MouseHover += new EventHandler(this.btnViewAll_MouseHover);
                    control.MouseLeave += new EventHandler(this.btnViewAll_MouseLeave);
                }
            }
            // Check click
            mapCheckButtonOptionViewIsClick = new Dictionary<Control, bool>();
            backgroundWorker1.RunWorkerAsync();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <listBook.Count; i++)
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
                
                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }
                formAd = new AdForm(listBook, this);
                activeFormChild(pnContainAd, formAd, null, ref actForm1);
                var bookSales = listBookSold
                            .GroupBy(b => b.BookId)
                            .Select(group => new { BookId = group.Key, SalesCount = group.Count() });

                // Join với bảng book để lấy thông tin sách chi tiết và sắp xếp theo lượt mua giảm dần
                        var topSellingBooks = bookSales
                     .Join(listBook, sale => sale.BookId, book => book.Id, (sale, book) => new
                     {
                         Book = book,
                         SalesCount = sale.SalesCount
                     })
                     .OrderByDescending(item => item.SalesCount)
                     .Select(item => item.Book) // Chỉ lấy đối tượng Book
                     .ToList(); // Chuyển kết quả thành List<Book>
                listBookBestSelling = topSellingBooks;
                var listBookSorted = listBook.OrderBy(b => b.Price).ToList();

                List<Task<Panel>> tasks = new List<Task<Panel>>();
                for (int i = 0; i < 10; i++)
                {
                    var tack = listBook[i].CreateBookPanelAsync(i, 4);
                    if (await tack != null)
                    {
                        tasks.Add(tack);
                        getBookFromPanelHotDeal[await tack] = listBook[i];
                    }
                }
                listHotDeal = ((await Task.WhenAll(tasks)).ToList());
                collectionPanelHotDeal.AddRange(listHotDeal.ToArray());
                List<Task<Panel>> tasksBestSelling  = new List<Task<Panel>>();
                for (int i = 0; i < listBookBestSelling.Count; i++)
                {
                    var tack = listBookBestSelling[i].CreateBookPanelAsync(i, 4);
                    if (await tack != null)
                    {
                        tasksBestSelling.Add(tack);
                        //getBookFromPanelHotDeal[await tack] = listBook[i];
                    }
                }

                listPanelBestSelling = ((await Task.WhenAll(tasksBestSelling)).ToList());

                foreach (Control item in collectionPanelHotDeal)
                {
                    item.Click += new EventHandler(this.bookHotDeal_Click);
                    foreach (Control control in item.Controls)
                        control.Click += new EventHandler(this.bookHotDeal_Click);
                }
                guna2ProgressIndicator.Stop();
                this.Controls.Remove(guna2ProgressIndicator);
                formHotDeal = new HotDealForm(listHotDeal, this, "HOT DEAL");
                activeFormChild(pnHotDeal, formHotDeal, null, ref actForm2);
                HotDealForm formBestSelling = new HotDealForm(listPanelBestSelling, this, "BEST SELLING ");
                Form actForm3 = new Form();
                activeFormChild(pnBestSelling, formBestSelling, null, ref actForm3);
                ReSize();
            }
        }
        internal void back_Click(object sender, EventArgs e)
        {
            pnMainForm.Size = new Size(this.Size.Width + WITH, this.Size.Height);
            pnProperties.Size = new Size(0, this.Height);
            pnContainSearch.Height = 200;
            pnOptionViewBook.Show();
            pnProperties.Dock = DockStyle.Right;
        }

        internal void bookAd_Click(object sender, EventArgs e)
        {
            
            pnMainForm.Size = new Size(this.Size.Width - WITH, this.Size.Height);
            pnProperties.Size = new Size(WITH, this.Height);
            pnProperties.Location = new Point(0, 0);
            activeFormChild(pnProperties, new PropertiesBookForm((sender as Advertisement).book, 4, this), e);
            pnProperties.Dock = DockStyle.Fill;
        }
        internal void bookClick(Book book)
        {
            pnProperties.Data1 = book;
            pnMainForm.Size = new Size(this.Size.Width - WITH, this.Size.Height);
            pnProperties.Size = new Size(WITH, this.Height);
            pnProperties.Location = new Point(0, 0);
            activeFormChild(pnProperties, new PropertiesBookForm(book, 4, this), null);
            
        }
        private void bookHotDeal_Click(object sender, EventArgs e)
        {
            
            PanelBook panelBook;
            if (sender is PanelBook)
            {
                panelBook = (PanelBook)sender;
               
            }
            else
            {
                panelBook = (PanelBook)FindControlContainer(collectionPanelHotDeal, sender as Control);
            }
            bookClick(panelBook.Data1);
           // activeFormChild(pnProperties, new PropertiesBookForm(panelBook.Data1, 4, this), e);
        }

        private void btnViewAll_MouseHover(object sender, EventArgs e)
        {
            if (sender is Guna2Panel)
            {
                var panelSender = (Guna2Panel)sender;
                panelSender.BorderColor = Color.Cyan;

                foreach (Label item in panelSender.Controls)
                {
                    item.ForeColor = Color.Cyan;
                }

            }
            else
            {
                var labelSender = (Label)sender;
                labelSender.ForeColor = Color.Cyan;
                Guna2Panel panel = (Guna2Panel)FindControlContainer(pnOptionViewBook.Controls, labelSender);
                panel.BorderColor = Color.Cyan;
            }
            if (sender is Guna2Panel)
            {
                mapCheckButtonOptionViewIsClick[sender as Control] = true;
            }
            else
            {
                mapCheckButtonOptionViewIsClick[FindControlContainer(pnOptionViewBook.Controls, sender as Control)] = true;
            }

        }

        private void btnViewAll_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna2Panel)
            {
                var panelSender = (Guna2Panel)sender;
                panelSender.BorderColor = Color.Black;

                foreach (Label item in panelSender.Controls)
                {
                    item.ForeColor = Color.Black;
                }
            }
            else
            {
                var labelSender = (Label)sender;
                labelSender.ForeColor = Color.Black;
                Guna2Panel panel = (Guna2Panel)FindControlContainer(pnOptionViewBook.Controls, labelSender);
                panel.BorderColor = Color.Black;
            }
            if (sender is Guna2Panel)
            {
                mapCheckButtonOptionViewIsClick[sender as Control] = false;
            }
            else
            {
                mapCheckButtonOptionViewIsClick[FindControlContainer(pnOptionViewBook.Controls, sender as Control)] = false;
            }
        }

        Guna2Panel btnClicked = new Guna2Panel();
        Label txtClicked = new Label();
        private void timerClick_Tick(object sender, EventArgs e)
        {
            if (btnClicked.Height > 40)
            {
                btnClicked.Width -= 1;
                btnClicked.Height -= 1;
                btnClicked.Location = new Point(btnClicked.Location.X + 1, btnClicked.Location.Y + 1);
                float size = (txtClicked.Font.Size - 0.2f);
                txtClicked.Font = new Font("Microsoft Sans Serif", size);
            }
            else
            {
                timerDownClick.Stop();
            }

        }

        private void btnViewAll_MouseDown(object sender, MouseEventArgs e)
        {
            btnClicked = sender as Guna2Panel;
            if (btnClicked.Height > 40)
                timerDownClick.Start();
        }

        private void btnViewAll_MouseUp(object sender, MouseEventArgs e)
        {
            timerDownClick.Stop();
            btnClicked = sender as Guna2Panel;
            timerUpClick.Start();
        }

        private void timerUpClick_Tick(object sender, EventArgs e)
        {
            if (btnClicked.Width < 109)
            {
                btnClicked.Width += 1;
                btnClicked.Height += 1;
                btnClicked.Location = new Point(btnClicked.Location.X - 1, btnClicked.Location.Y - 1);
                float size = (txtClicked.Font.Size + 0.2f);
                txtClicked.Font = new Font("Microsoft Sans Serif", size);
            }
            else
            {
                timerUpClick.Stop();

                BookForm allBookForm = new BookForm(listPanelBestSelling, this, "ALL BOOK");
                //Control.ControlCollection controls = new Control.ControlCollection(pnMainForm);
                //pnMainForm.Controls.Clear();
                activeFormChild(pnProperties, allBookForm, null, ref formMain);
                pnMainForm.Width = 0;
                pnProperties.Width = WITH;
                pnOptionViewBook.Hide();
                pnContainSearch.Height = 116;
            }
        }
        Form formMain;
        private void pnAd_Scroll(object sender, ScrollEventArgs e)
        {
            if(pnMainForm.AutoScrollPosition.X != 0)
            {
                pnOptionViewBook.Hide();
                pnContainSearch.Height = 116;

            }
            else
            {
                pnOptionViewBook.Show();
                pnContainSearch.Height = 200;
            }
        }

        private void pnSearchShop_Resize(object sender, EventArgs e)
        {
            
        }

        private void pnBestSelling_Resize(object sender, EventArgs e)
        {
        }

        private void pnHotDeal_Resize(object sender, EventArgs e)
        {
        }
        void ReSize()
        {
            pnSearchShop.Location = new Point((pnSearch.Width - pnSearchShop.Width) / 2, (pnSearch.Height - pnSearchShop.Height) / 2);

            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnContainSearch);
            pnMainForm.Size = new Size(this.Width - 30, pnMainForm.Height);
            pnContainSearch.Size = new Size (this.Width - 30, pnContainSearch.Height);

            pnAd.Size = new Size(pnMainForm.Width, pnAd.Height);
            pnBestSelling.Size = new Size(pnMainForm.Width, pnBestSelling.Height);
            pnHotDeal.Size = new Size(pnMainForm.Width, pnHotDeal.Height);
            pnContainAd.Location = new Point((pnAd.Width - pnContainAd.Width) / 2, (pnAd.Height - pnContainAd.Height) / 2);
            
        }
        private void NewShopMain_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show("HI");
            ReSize();
        }

        private void pnProperties_Resize(object sender, EventArgs e)
        {
            if (pnProperties.Width > 1000)
            {
                WITH = this.Width;
                pnProperties.Width = this.Width;
                bookClick(pnProperties.Data1);
            }
            
        }
    }
}
