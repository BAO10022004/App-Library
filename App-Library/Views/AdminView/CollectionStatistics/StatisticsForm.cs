using App_Library.Services;
using Guna.Charts.Interfaces;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.AdminView.CollectionStatistics
{
    public partial class StatisticsForm : Form
    {
        private UserService _userService;
        private BookService _bookService;
        private BookSoldService _bookSoldService;
        private CommentService _commentService;
        private StarsRatingService _starsRatingService;
        public StatisticsForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _bookService = new BookService();
            _bookSoldService = new BookSoldService();
            _commentService = new CommentService();
            _starsRatingService = new StarsRatingService();

            LoadTotalPanel();
            LoadDataUser();
            LoadDataBook();
            LoadDataBookSold();
            LoadDataComment();
            LoadDataHotBook();

        }

        private async void LoadTotalPanel()
        {
            var totalUser = (await _userService.GetUsersAsync()).Count();
            lblTotalUser.Text = totalUser.ToString();

            var totalBook = (await _bookService.GetBooksAsync()).Count();
            lblTotalBook.Text = totalBook.ToString();

            var totalBookSold = (await _bookSoldService.GetBooksSoldAsync()).Where(n => n.Status == "Approved").Count();
            lblTotalBookSold.Text = totalBookSold.ToString();
        }

        private async void LoadDataUser()
        {
            var lstUser = await _userService.GetUsersAsync();
            var lstPoint = lstUser.Where(n => n.CreatedAt.Date >= new DateTime(2024, 1, 13).Date && n.CreatedAt.Date <= new DateTime(2024, 11, 27).Date).GroupBy(n => n.CreatedAt.Date).Select(n => n.Key).ToList();

            var lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                var count = lstUser.Where(n => n.CreatedAt.Date == item.Date).Count();
                if (count > 0)
                {
                    lPointCollection.Add($"{item.Day}/{item.Month}/{item.Year}", count);
                }
            }
            datasetUser.DataPoints = lPointCollection;
        }
        private async void LoadDataBook()
        {
            var lstBook = await _bookService.GetBooksAsync();
            var lstPoint = lstBook.GroupBy(n => n.Genre).Select(x => x.Key).ToList();

            var lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                lPointCollection.Add(item, lstBook.Where(n => n.Genre == item).Count());
            }
            datasetBook.DataPoints = lPointCollection;
        }
        private async void LoadDataBookSold()
        {
            string format = "yyyy-MM-dd HH:mm";
            var lstBookSold = await _bookSoldService.GetBooksSoldAsync();
            var lPointCollection = lstBookSold.Where(n => n.CreatedAt.Date >= new DateTime(2024, 10, 10).Date && n.CreatedAt.Date <= new DateTime(2024, 11, 28).Date).GroupBy(n => n.CreatedAt.ToString(format)).Select(n => n.Key).ToList();

            var lPointCollectionRejected = new LPointCollection();
            var lPointCollectionPending = new LPointCollection();
            var lPointCollectionApproved = new LPointCollection();

            foreach (var item in lPointCollection)
            {
                var lstRejected = lstBookSold.Where(n => n.CreatedAt.ToString(format) == item && n.Status == "Rejected");
                var lstPending = lstBookSold.Where(n => n.CreatedAt.ToString(format) == item && n.Status == "Pending");
                var lstApproved = lstBookSold.Where(n => n.CreatedAt.ToString(format) == item && n.Status == "Approved");

                lPointCollectionRejected.Add(item, lstRejected.Count());
                lPointCollectionPending.Add(item, lstPending.Count());
                lPointCollectionApproved.Add(item, lstApproved.Count());
            }

            datasetBookRejected.DataPoints = lPointCollectionRejected;
            datasetBookPending.DataPoints = lPointCollectionPending;
            datasetBookApproved.DataPoints = lPointCollectionApproved;
        }
        private async void LoadDataComment()
        {
            var lstComment = (await _commentService.GetAllCommentAsync()).Comments;
            var lstPoint = lstComment.Where(n => n.CreatedAt.Date >= new DateTime(2024, 10, 11).Date && n.CreatedAt.Date <= new DateTime(2024, 11, 27).Date).GroupBy(n => n.CreatedAt.Date).Select(n => n.Key).ToList();

            var lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                var count = lstComment.Where(n => n.CreatedAt.Date == item.Date).Count();
                if (count > 0)
                {
                    lPointCollection.Add($"{item.Day}/{item.Month}/{item.Year}", count);
                }
            }
            datasetComment.DataPoints = lPointCollection;
        }
        private async void LoadDataHotBook()
        {
            var lstBook = await _bookService.GetBooksAsync();
            var lstPoint = lstBook.GroupBy(n => n.Genre).Select(x => x.Key).ToList();

            LPointCollection lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                lPointCollection.Add(item, lstBook.Where(n => n.Genre == item).Count());
            }
            datasetHotBook.DataPoints = lPointCollection;
        }
    }
}
