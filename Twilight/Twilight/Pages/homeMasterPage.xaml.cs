using System;
using System.Collections.Generic;
using Twilight.Models;

using Xamarin.Forms;

namespace Twilight.Pages
{
    public partial class homeMasterPage : ContentPage
    {
        public homeMasterPage()
        {
            InitializeComponent();

            var homeMasterPageItems = new List<homeMasterPageItem>
            {
                new homeMasterPageItem
                {
                    Title = "ダイレクトメッセージ",
                    Image = "comments.png",
                    TargetType = typeof(MainPage)
                }
            };
            listView.ItemsSource = homeMasterPageItems;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (App.user != null)
            {
                BindingContext = App.user;
            }
        }
    }
}
