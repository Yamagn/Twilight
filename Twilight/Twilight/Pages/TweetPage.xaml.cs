using System;
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

        async void Tweet_Clicked(object sender, EventArgs e)
        {
            if(tweetContent.Text == "")
            {
                return;
            }
            MediaUploadResult image = new MediaUploadResult();
            await App.tokens.Statuses.UpdateAsync(status => tweetContent.Text);
            await Navigation.PopAsync();
        }

        async void Media_Clicked(object sender, EventArgs e)
        {

        }
	}
}