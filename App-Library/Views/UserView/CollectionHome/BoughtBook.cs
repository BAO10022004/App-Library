using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionHelp;
using App_Library.Views.ToolerForm;
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
        public BoughtBook(List<Book> booksBold)
        {

            InitializeComponent();
            //processing.S();
            this.booksBold = booksBold;
            pnContent.AutoScrollMinSize = new Size(0, ((booksBold.Count % 3) + 1) * 302);
            int count = 0;
            foreach (Book book in booksBold)
            {
                pnContent.Controls.Add(book.CreateBookPanel(this)); 
                count++;
            }
        }

        private void BoughtBook_Resize(object sender, EventArgs e)
        {
           
            
        }
        Form actForm;
        private void BoughtBook_Load(object sender, EventArgs e)
        {
        }
        Form actFormRead;
        public void clickRead(object sender, EventArgs e)
        {
            PanelBook panel = FindControlContainer(pnContent.Controls, (sender) as Button) as PanelBook;
            

            if (!string.IsNullOrEmpty(panel.Data1.PdfUrl))
            {
                (new PdfViewerForm(panel.Data1.PdfUrl)).ShowDialog();
                //pnContent.Controls.Clear();
                //activeFormChild(pnContent, (new PdfViewerForm(panel.Data1.PdfUrl)), null, ref actForm);
            }
            else
            {
                MessageBox.Show("No PDF available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
