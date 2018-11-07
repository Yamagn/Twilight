using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoreTweet;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Twilight
{
    public partial class App : Application
	{
        public static Tokens tokens;
        public static User user;
        public App ()
		{
			InitializeComponent();

			MainPage = new Pages.homeMasterDetailPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
