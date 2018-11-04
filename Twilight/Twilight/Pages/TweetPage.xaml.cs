using System;
using Twilight.Models;
using CoreTweet;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TweetPage : ContentPage
	{
        public TweetPage ()
		{
			InitializeComponent ();
		}

        async void tweet_Clicked(object sender, EventArgs e)
        {
            if(tweetContent.Text == "")
            {
                return;
            }
            App.tokens.Statuses.Update(status => tweetContent.Text);
            await Navigation.PopAsync();
        }
	}
}