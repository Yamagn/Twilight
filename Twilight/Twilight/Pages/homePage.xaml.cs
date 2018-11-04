using System;
using Twilight.Models;

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

        private async void newTweet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TweetPage());
        }
    }
}