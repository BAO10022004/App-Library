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
        List<Panel> listPanelAllBook;
        List<Book> listBook;
        List<Panel> listHotDeal;
        List<Task<Panel>> listTaskPanelHotDealBook;
        List<Task<Panel>> listTaskPanelAllBook;
        private readonly BookService _bookService;
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
        public const int WITH = 450;
        public const int HEIGHT = 831;
        public NewShopMain()
        {
            _bookService = new BookService();
            collectionPanelAd = new Control.ControlCollection(new Panel());
            collectionPanelHotDeal = new Control.ControlCollection(new Panel());
            collectionPanelHotDeal = new Control.ControlCollection(new Panel());
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
            listBook = await _bookService.GetBooksAsync();

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                var bookPanel = CreateBookAdPanel(listBook[i], i, 4);
                if (bookPanel != null)
                {
                    getBookFromPanelAd[bookPanel] = listBook[i];
                    foreach (Control control in bookPanel.Controls)
                        control.Click += new EventHandler(this.bookAd_Click);
                    backgroundWorker1.ReportProgress(0, bookPanel);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var bookPanel = e.UserState as Panel;
            if (listPanelBookAd.Count < 6)
            {
                listPanelBookAd.Add(bookPanel);
                collectionPanelAd.Add(bookPanel);
            }

        }

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
                guna2ProgressIndicator.Stop();
                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }
                formAd = new AdForm(listPanelBookAd, this);
                activeFormChild(pnAd, formAd, null, ref actForm1);
                List<Task<Panel>> tasks = new List<Task<Panel>>();

                for (int i = 0; i < listBook.Count; i++)
                {
                    tasks.Add(CreateBookPanelAsync(listBook[i], i, 4));

                }

                listPanelAllBook = ((await Task.WhenAll(tasks)).ToList());
                collectionPanelHotDeal.AddRange(listPanelAllBook.ToArray());
                formHotDeal = new HotDealForm(listPanelAllBook, this);
                activeFormChild(pnHotDeal, formHotDeal, null, ref actForm2);
            }

        }

        private void bwkCreateHotDeal_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bwkCreateHotDeal_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listTaskPanelAllBook.Add(e.UserState as Task<Panel>);
        }
        Form actForm1;
        Form actForm2;
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



            }
        }
        private void bookAd_Click(object sender, EventArgs e)
        {
            pnMainForm.Size = new Size(this.Size.Width - WITH, this.Size.Height);
            pnProperties.Size = new Size(WITH, this.Height);
            //pnProperties.BackColor = Color.Black;
            pnProperties.Location = new Point(this.Size.Width + 300 - pnMainForm.Width, 0);
            //foreach(Control control in FindControlContainer(collectionPanelAd, sender as Control).Controls)
            //{
            //    MessageBox.Show(control.Text);
            //}
            activeFormChild(pnProperties, new PropertiesBookForm(getBookFromPanelAd[FindControlContainer(collectionPanelAd, sender as Control)]), e);
        }
    }
}
