using System;
using System.Collections.Generic;
using CoreTweet;
using Xamarin.Forms;

namespace Twilight.Pages
{
    public partial class tweetDetailPage : ContentPage
    {
        public tweetDetailPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            string[] vs = (BindingContext as Status).CreatedAt.ToString().Split(' ');
            string[] date = vs[0].Split('/');
            string[] time = vs[1].Split(':');
            string str = date[0] + "年" + date[1] + "月" + date[2] + "日" + time[0] + "時" + time[1] + "分" + time[2] + "秒";
            createdDate.Text = str;
        }
    }
}
