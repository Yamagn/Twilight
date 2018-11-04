using System;
using Twilight.Models;

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

        void Content_Changed(object sender, TextChangedEventArgs e)
        {
           
        }

        async void tweet_Clicked(object sender, EventArgs e)
        {
        }
	}
}