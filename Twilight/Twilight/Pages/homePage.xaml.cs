using System;
using Twilight.Models;
using CoreTweet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class homePage : ContentPage
	{
		public homePage ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if(App.tokens == null)
            {
                await Navigation.PushAsync(new authPage());
            }
            else
            {
                App.user = await App.tokens.Users.ShowAsync(user_id => App.tokens.UserId, screen_name => App.tokens.ScreenName);
                var statuses = await App.tokens.Statuses.HomeTimelineAsync(count => 100);
                timeLine.ItemsSource = statuses;
            }
        }

        async void tweet_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new tweetDetailPage
            {
                BindingContext = e.SelectedItem as Status
            });
        }

        async void refreshTL(object sender, EventArgs e)
        {
            timeLine.ItemsSource = await App.tokens.Statuses.HomeTimelineAsync(count => 100);
            timeLine.IsRefreshing = false;
        }

        async void fav_Clicked(object sender, EventArgs e)
        {

        }

        async void RT_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void newTweet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TweetPage());
        }
    }
}