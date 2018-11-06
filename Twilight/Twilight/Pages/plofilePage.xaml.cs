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
	public partial class plofilePage : ContentPage
	{
        public plofilePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (App.user != null)
            {
                BindingContext = App.user;
                string str = App.user.ProfileImageUrl.Replace("_normal", "");
                userImage.Source = str;
                friends.Text = App.user.FriendsCount.ToString() + "フォロー";
                followers.Text = App.user.FollowersCount.ToString() + "フォロワー";
                userTimeLine.ItemsSource = await App.tokens.Statuses.UserTimelineAsync(user_id => App.tokens.UserId, screen_name => App.tokens.ScreenName);
            }
        }

        async void tweet_Selected(object sernder, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new tweetDetailPage
            {
                BindingContext = e.SelectedItem as Status
            });
        }

    }
}