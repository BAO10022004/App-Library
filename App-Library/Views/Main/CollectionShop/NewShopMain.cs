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
        // check button option view  click
        Dictionary<Control, bool> mapCheckButtonOptionViewIsClick;
        public NewShopMain()
        {
            _bookService = new BookService();
            collectionPanelAd = new Control.ControlCollection(new Panel());
            collectionPanelHotDeal = new Control.ControlCollection(new Panel());
            collectionPanelAll = new Control.ControlCollection(new Panel());
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
            listPanelAllBook = new List<Panel>();
            listTaskPanelAllBook = new List<Task<Panel>>();
            // Create Data for book
            listBook = await _bookService.GetBooksAsync();
            // Add event handel for View option 
            foreach(Guna2Panel pn in pnOptionViewBook.Controls)
            {
                pn.MouseHover += new EventHandler(this.btnViewAll_MouseHover);
                pn.MouseLeave += new EventHandler(this.btnViewAll_MouseLeave);
                foreach(Control control in pn.Controls)
                {
                    control.MouseHover += new EventHandler(this.btnViewAll_MouseHover);
                    control.MouseLeave += new EventHandler(this.btnViewAll_MouseLeave);
                }
            }
            // Check click
            mapCheckButtonOptionViewIsClick = new Dictionary<Control, bool>();
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
                    bookPanel.Click += new EventHandler(this.bookAd_Click);
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
                guna2ProgressIndicator.Stop();
                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }
                formAd = new AdForm(listPanelBookAd, this);
                activeFormChild(pnAd, formAd, null, ref actForm1);
                List<Task<Panel>> tasks = new List<Task<Panel>>();
                var listBookSorted = listBook.OrderBy(b => b.Price).ToList();
                for (int i = 0; i < 10; i++)
                {
                    var tack = CreateBookPanelAsync(listBook[i], i, 4);
                    if(await tack != null)
                    {
                        tasks.Add(tack);
                        
                        getBookFromPanelHotDeal[await tack] = listBook[i];
                    }
                   
                }

                listHotDeal = ((await Task.WhenAll(tasks)).ToList());
                collectionPanelHotDeal.AddRange(listHotDeal.ToArray());
                foreach (Control item in collectionPanelHotDeal)
                {
                   item.Click += new EventHandler(this.bookHotDeal_Click);
                    foreach (Control control in item.Controls)
                        control.Click += new EventHandler(this.bookHotDeal_Click);
                }
                
                formHotDeal = new HotDealForm(listHotDeal, this);
                activeFormChild(pnHotDeal, formHotDeal, null, ref actForm2);
                
            }
        }

       
        
        private void bookAd_Click(object sender, EventArgs e)
        {
            pnMainForm.Size = new Size(this.Size.Width - WITH, this.Size.Height);
            pnProperties.Size = new Size(WITH, this.Height);
            //pnProperties.BackColor = Color.Black;
            pnProperties.Location = new Point(this.Size.Width + 300 - pnMainForm.Width, 0);
            activeFormChild(pnProperties, new PropertiesBookForm(getBookFromPanelAd[FindControlContainer(collectionPanelAd, sender as Control)]), e);
        }
        private void bookHotDeal_Click(object sender, EventArgs e)
        {
            pnMainForm.Size = new Size(this.Size.Width - WITH, this.Size.Height);
            pnProperties.Size = new Size(WITH, this.Height);
            //pnProperties.BackColor = Color.Black;
            pnProperties.Location = new Point(this.Size.Width + 300 - pnMainForm.Width, 0);
            activeFormChild(pnProperties, new PropertiesBookForm(getBookFromPanelHotDeal[FindControlContainer(collectionPanelHotDeal, sender as Control)]), e);
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

        private void btnViewAll_Click(object sender, EventArgs e)
        {
           

        }
        Guna2Panel btnClicked = new Guna2Panel();
        Label txtClicked = new Label();
        private void timerClick_Tick(object sender, EventArgs e)
        {
           
            
            if(btnClicked.Height > 40)
            {
                btnClicked.Width -= 1;
                btnClicked.Height -= 1;
                btnClicked.Location = new Point(btnClicked.Location.X +1, btnClicked.Location.Y + 1);
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
            if(btnClicked.Height > 40)
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
            if (btnClicked.Width <109)
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
                AllBookForm allBookForm = new AllBookForm(listHotDeal, this);
                activeFormChild(pnShopAllBook, allBookForm, null, ref actForm3);
            }
        }
    }
}
