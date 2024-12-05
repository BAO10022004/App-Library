using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using SharpCompress.Compressors.Xz;
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

namespace App_Library.Views.Main.CollectionShop
{
    public partial class AdForm : FormHelper
    {
        List<Image> listBook;
        NewShopMain shop;
        Dictionary<Image, Book> books;
        // index Book in Ad
        int indexCurrentBookAd = 0;

        public AdForm(NewShopMain formParent)
        {
            
            InitializeComponent();
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);
            
            this.shop = formParent;
            books = new Dictionary<Image, Book>();

        }
        Form form1;
        private async void AdForm_Load(object sender, EventArgs e)
        {
            this.listBook = await getAllImage();
            timerAd.Start();
            loadAd(0);
        }
        void loadAd(int index)
        {
            timerAd.Interval = 15000;
            activeFormChild(pnAdMain, new Advertisement(listBook[index], books[listBook[index]], shop), null, ref form1);
            if(index != listBook.Count -1)
            {
                shop.loadImageAsync(picSubAd1, books[listBook[index +1]].Image);
            }
            if (index != listBook.Count - 2)
            {
                shop.loadImageAsync(picSubAd2, books[listBook[index + 2]].Image);
                return;
            }
            indexCurrentBookAd = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            indexCurrentBookAd++;
            loadAd(indexCurrentBookAd);
        }
       public async Task<List<Image>> getAllImage()
        {
            BookService bookService = new BookService();
            var resourceNames = typeof(Properties.Resources)
                           .GetProperties(BindingFlags.Static | BindingFlags.NonPublic)
                           .Select(p => p.Name)
                           .Where(name => name.ToLower().Contains("banner")) // Kiểm tra tên có chứa từ "banner"
                           .ToList();
            List<Image> images = new List<Image>();
            foreach (var resourceName in resourceNames)
            {
                var propertyInfo = typeof(Properties.Resources).GetProperty(resourceName, BindingFlags.Static | BindingFlags.NonPublic);
                Image image;
                if (propertyInfo != null)
                {
                    image = propertyInfo.GetValue(null) as Image; // Lấy ảnh từ tài nguyên
                    if (image != null)
                    {
                        images.Add(image);
                    }
                    switch (resourceName)
                    {
                        case "bannerBraveNewWord":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("brave-new-world");
                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                        case "bannerElonMusk":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("elon-musk");

                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                        case "bannerNhagiakim":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("nha-gia-kim");

                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                        case "bannerMatBiec":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("mat-biec");

                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                        case "bannerConan":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("case-closed");

                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                        case "bannerDoreamon":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("doraemon");

                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                        case "bannerTheGreatGatsby":
                            {
                                try
                                {
                                    books[image] = await bookService.GetBookBySlugAsync("the-great-gatsby");

                                }
                                catch
                                {
                                    images.Remove(image);
                                }
                                break;
                            }
                    }

                }

            }
            return images;
        }

        private void picSubAd1_Click(object sender, EventArgs e)
        {
            shop.bookClick(books[listBook[indexCurrentBookAd + 1]]);
        }

        private void picSubAd2_Click(object sender, EventArgs e)
        {
            shop.bookClick(books[listBook[indexCurrentBookAd + 2]]);

        }
    }
}
