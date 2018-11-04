using CoreTweet;
using System;
using Twilight.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Twilight;
using static CoreTweet.OAuth;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class authPage : ContentPage
	{
        private OAuthSession session;
		public authPage ()
		{
			InitializeComponent ();

            session = AuthorizeAsync(Key.consumerKey, Key.consumerSecret).Result;
            Device.OpenUri(new Uri(session.AuthorizeUri.AbsoluteUri));
        }

        async void submit_Clicked(object sender, EventArgs e)
        {
            string pincode = pin.Text;
            try
            {   
                Tokens _tokens = await OAuth.GetTokensAsync(session, pincode);
                App.tokens = _tokens;
            
                if (App.tokens != null)
                {
                    await Navigation.PopAsync();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
        }
	}
}