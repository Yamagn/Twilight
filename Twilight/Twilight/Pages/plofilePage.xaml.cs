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
	public partial class plofilePage : ContentPage
	{
        public plofilePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }
	}
}