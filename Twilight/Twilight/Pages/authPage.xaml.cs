using CoreTweet;
using System;
using Twilight.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Twilight;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class authPage : ContentPage
	{
        private OAuth.OAuthSession session;
		public authPage ()
		{
			InitializeComponent ();

            session = OAuth.AuthorizeAsync(Key.consumerKey, Key.consumerSecret).Result;
            Device.OpenUri(new Uri(session.AuthorizeUri.AbsoluteUri));
        }

        async void submit_Clicked(object sender, EventArgs e)
        {
            string pincode = pin.Text;
            try
            {   
                Tokens _tokens = await OAuth.GetTokensAsync(session, pincode);
                App.tokens = _tokens;
                var tk = new Token
                {
                    accessToken = _tokens.AccessToken,
                    accessSecret = _tokens.AccessTokenSecret
                };
                await App.TokenDatabase.SaveItemAsync(tk);
            
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