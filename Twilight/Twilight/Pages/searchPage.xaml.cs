﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twilight.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class searchPage : ContentPage
	{
		public searchPage ()
		{
			InitializeComponent ();
		}

        async void serachTweet(object sender, EventArgs e)
        {
            string word = searchWord.Text;
            await Navigation.PushAsync(new searchResultPage
            {
                BindingContext = word as string
            });
        }
    }
}