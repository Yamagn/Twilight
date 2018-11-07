using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoreTweet;
using SQLite;
using System.IO;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Twilight
{
    public partial class App : Application
	{
        public static Tokens tokens;
        public static User user;
        public static DatabaseControll tokenDatabase;

        public App ()
		{
			InitializeComponent();

			MainPage = new Pages.homeMasterDetailPage();
            if(tokenDatabase == null)
            {
                return;
            }
            var tk = tokenDatabase.GetItemsAsync().Result;
            if (tk != null)
            {
                tokens = tk[0].myToken;
            }
		}

        public static DatabaseControll TokenDatabase
        {
            get
            {
                if(tokenDatabase == null)
                {
                    tokenDatabase = new DatabaseControll(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tokenDB.db3"));
                }
                return tokenDatabase;

            }
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
