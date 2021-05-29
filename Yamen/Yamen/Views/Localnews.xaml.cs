using Android.Service.Controls;
using Android.Webkit;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Xaml;

namespace Yamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Localnews : ContentPage
    {
        public Localnews()
        {
            InitializeComponent();


        }
        void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }

        void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;

        }
        protected override bool OnBackButtonPressed()
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
                return true;
            }

            return base.OnBackButtonPressed();
        }
        async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
            await Task.Delay(3000);
            myRefreshView.IsRefreshing = false;
        }
       
    }
}

