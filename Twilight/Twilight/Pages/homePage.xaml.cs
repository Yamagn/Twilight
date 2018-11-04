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

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if(App.tokens == null)
            {
                await Navigation.PushAsync(new authPage());
            }
            
        }

        private async void newTweet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TweetPage());
        }
    }
}