using App_Library.Models;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionShop
{
    public partial class AnimationProperties : Form
    {
        Book book;
        private int Xo; 
        private int Yo; 
        private int Xf = 0;    
        private int Yf = 9;
        private int Widtho = 186;  
        private int Heighto = 262; 
        private int Widthf = 374;  
        private int Heightf = 397;
        private int stepCount = 50; 
        private int currentStep = 0; 
        PropertiesBookForm bookForm;
        public AnimationProperties(PanelBook panelBook,  NewShopMain controller , PropertiesBookForm formAct )
        {
            InitializeComponent();
            Controller = controller;
            book = panelBook.Data as Book;
            if (panelBook.Parent.Name == "pnNewItem")
            {
                Xo = controller.GetLocationFormNewItem(panelBook).X;
                Yo = controller.GetLocationFormNewItem(panelBook).Y;
            }
            else
            {
                Xo = controller.GetLocationFormsBestDeal(panelBook).X;
                Yo = controller.GetLocationFormsBestDeal(panelBook).Y;
            }
            picImage.Location = new Point(Xo, Yo);
            this.bookForm = formAct;
        }

        public NewShopMain Controller { get; }

        private async void AnimationProperties_Load(object sender, System.EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(book.Image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
            }
            currentStep = 0;
            timerGoHome.Start();    
        }
        int x;
        int y;
        private void timerGoHome_Tick(object sender, EventArgs e)
        {
            if (currentStep < stepCount)
            {
                // Tính tỷ lệ hoàn thành (từ 0 đến 1)
                float t = (float)currentStep / stepCount;

                // Hàm easing-out (chậm dần khi gần đích): 1 - (1 - t) * (1 - t)
                float easedT = 1 - (1 - t) * (1 - t);  // Easing-out: nhanh đầu, chậm cuối

                // Tính toán sự thay đổi vị trí và kích thước với easing-out
                int newX = Xo + (int)((Xf - Xo) * easedT);
                int newY = Yo + (int)((Yf - Yo) * easedT);

                int newWidth = Widtho + (int)((Widthf - Widtho) * easedT);
                int newHeight = Heighto + (int)((Heightf - Heighto) * easedT);

                // Cập nhật vị trí và kích thước của control
                picImage.Location = new System.Drawing.Point(newX, newY);
                picImage.Size = new System.Drawing.Size(newWidth, newHeight);

                // Tăng bước hiện tại
                currentStep++;
            }
            else
            {
                timerGoHome.Stop();
                Controller.openProp(bookForm);
            }

        }
    }
}
