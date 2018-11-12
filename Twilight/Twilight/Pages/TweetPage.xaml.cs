using System;
using CoreTweet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Twilight;
using System.IO;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TweetPage : ContentPage
	{
        FileInfo[] info = new FileInfo[4];
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
            if(info.Length >= 4)
            {
                return;
            }
            var path = await GalleryClient.PickPhotoAsync();
            info.SetValue(new FileInfo(path), info.Length);
        }
	}
}