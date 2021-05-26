using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Yamen.Views;

namespace Yamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LocalNews_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Localnews());
        }

        private void presdant_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Presedant());
        }

        private void Rebort_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Rebort());
        }

        private void Asker_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Asker());
        }

        private void Arabicnews_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new ArabicNews());
        }

        private void encome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Encome());
        }

        private void Sports_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Sports());
        }

        private void news_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Nashra());
        }

        private void Livenow_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Live());
        }
    }
}
