using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionHelp;
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

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class BoughtBook : FormHelper
    {
        internal Double percentWidthForNumber = 0.07;
        internal Double percentWidthForNameBook = 0.516;
        internal Double percentWidthForAuthor = 0.07;
        List<Book> booksBold;
        bool isViewGrid = true;
        public BoughtBook(List<Book> booksBold)
        {
            InitializeComponent();
            this.booksBold = booksBold;
            pnContent.AutoScrollMinSize = new Size(0, ((booksBold.Count % 3) + 1) * 302);   
        }

        private void BoughtBook_Resize(object sender, EventArgs e)
        {
           
            
        }
        Form actForm;
        private void BoughtBook_Load(object sender, EventArgs e)
        {
            if(!(booksBold == null )||! (booksBold.Count == 0))
            {
                pnContent.Controls.Clear();
                for (int i = 0; i < booksBold.Count; i++)
                {
                    pnContent.Controls.Add(createPanel(booksBold[i], i));
                }
            }
            
        }
        
         Guna2Panel createPanel(Book book, int index)
        {
            Form form = null;
            Guna2Panel gn = new Guna2Panel();
            gn.Size = new System.Drawing.Size(200, 300);
            gn.TabIndex = index;
            activeFormChild(gn, new BookItem(book, this), null, ref form);
            return gn;
        }
        Guna2Panel createPanelList(Book book, int index)
        {
            Form form = null;
            Guna2Panel gn = new Guna2Panel();
            gn.Size = new System.Drawing.Size(1000, 250);
            gn.TabIndex = index;
            activeFormChild(gn, new BookItemList(book), null, ref form);
            return gn;
        }
        Form actFormRead;
        public void clickRead(object sender, EventArgs e)
        {
            //PanelBook panel = FindControlContainer(pnContent.Controls, (sender) as Button) as PanelBook;
        }
        private void btnGrid_Click(object sender, EventArgs e)
        {
            if(!isViewGrid)
            {
                pnContent.Controls.Clear();
                for (int i = 0; i < booksBold.Count; i++)
                {
                    pnContent.Controls.Add(createPanel(booksBold[i], i));
                }
                pnContent.AutoScrollMinSize = new Size(0, ((booksBold.Count % 3) + 1) * 302);
                isViewGrid = true;
            }
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (isViewGrid)
            {
                pnContent.Controls.Clear();
                for (int i = 0; i < booksBold.Count; i++)
                {
                    pnContent.Controls.Add(createPanelList(booksBold[i], i));
                }
                pnContent.AutoScrollMinSize = new Size(0, ((booksBold.Count) + 1) * 252);
                isViewGrid = false;
            }
        }

    }
}
