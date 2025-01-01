using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionShop
{
     

    public partial class AdFormNew : FormHelper
    {
        class BookColor
        {
            private Book data;
            private Color color;
            public BookColor()
            {
                data = new Book();
            }
            public Book Data { get => data; set => data = value; }
            public Color Color { get => color; set => color = value; }
        }
        List<Image> listBook;
        NewShopMain shop;
        Dictionary<Image, BookColor> books;
        // index Book in Ad
        int indexCurrentBookAd = 0;

        public AdFormNew(NewShopMain formParent)
        {

            InitializeComponent();
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);

            this.shop = formParent;
            books = new Dictionary<Image, BookColor>();

        }
        Form form1;
        private void AdForm_Load(object sender, EventArgs e)
        {
            listBook = new List<Image>();
            getAllImage();
            timerAd.Start();
            loadAd(0);
        }
        void loadAd(int index)
        {
            timerAd.Interval = 15000;
            activeFormChild(pnAdMain, new Advertisement(listBook[index], books[listBook[index]].Data, shop, books[listBook[index]].Color), null, ref form1);
            if (index != listBook.Count - 1)
            {
                shop.loadImageAsync(picSubAd1, books[listBook[index + 1]].Data.Image);
            }
            if (index != listBook.Count - 2)
            {
                shop.loadImageAsync(picSubAd2, books[listBook[index + 2]].Data.Image);
                return;
            }
            indexCurrentBookAd = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            indexCurrentBookAd++;
            loadAd(indexCurrentBookAd);
        }
        public async void getAllImage()
        {
            BookService bookService = new BookService();
            var resourceNames = typeof(Properties.Resources)
                           .GetProperties(BindingFlags.Static | BindingFlags.NonPublic)
                           .Select(p => p.Name)
                           .Where(name => name.ToLower().Contains("banner")) // Kiểm tra tên có chứa từ "banner"
                           .ToList();
            resourceNames.ForEach(async x =>
            {
                var propertyInfo = typeof(Properties.Resources).GetProperty(x, BindingFlags.Static | BindingFlags.NonPublic);
                if (propertyInfo != null)
                {
                    Image image = propertyInfo.GetValue(null) as Image;
                    listBook.Add(image);
                    books[image] = new BookColor();
                    switch (x)
                    {
                        case "bannerBraveNewWord":
                            {
                                try
                                {

                                    books[image].Data = await bookService.GetBookBySlugAsync("brave-new-world");
                                    books[image].Color = Color.OrangeRed;
                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerElonMusk":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("elon-musk");
                                    books[image].Color = Color.Black;

                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerNhagiakim":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("nha-gia-kim");
                                    books[image].Color = Color.DarkOrange;

                                }
                                catch
                                {
                                    //listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerMatBiec":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("mat-biec");
                                    books[image].Color = Color.Orange;

                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerConan":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("case-closed");
                                    books[image].Color = Color.RoyalBlue;
                                }
                                catch
                                {
                                    //listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerDoreamon":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("doraemon");
                                    books[image].Color = Color.RoyalBlue;

                                }
                                catch
                                {
                                    //listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerTheGreatGatsby":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("the-great-gatsby");
                                    books[image].Color = Color.DarkGray;
                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                    }

                }
            });


        }

        private void picSubAd1_Click(object sender, EventArgs e)
        {
            shop.bookClick(books[listBook[indexCurrentBookAd + 1]].Data);
        }

        private void picSubAd2_Click(object sender, EventArgs e)
        {
            shop.bookClick(books[listBook[indexCurrentBookAd + 2]].Data);

        }
    }
}
