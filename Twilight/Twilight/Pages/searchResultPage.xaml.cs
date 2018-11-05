using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTweet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class searchResultPage : ContentPage
	{
		public searchResultPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var res = await App.tokens.Search.TweetsAsync(count => 100, q => (string)BindingContext);
            searchTweets.ItemsSource = res;
        }

        async void tweet_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new tweetDetailPage
            {
                BindingContext = e.SelectedItem as Status
            });
        }

        async void refreshSearch(object sender, EventArgs e)
        {
            var res = await App.tokens.Search.TweetsAsync(count => 100, q => (string)BindingContext);
            searchTweets.ItemsSource = res;

        }

        async void fav_Clicked(object sender, EventArgs e)
        {

        }

        async void RT_Clicked(object sender, EventArgs e)
        {

        }

        async void serachTweet(object sender, EventArgs e)
        {
            string word = searchWord.Text;
            await Navigation.PushAsync(new searchResultPage
            {
                BindingContext = word
            });
        }
    }
}