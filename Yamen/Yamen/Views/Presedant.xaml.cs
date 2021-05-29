using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Presedant : ContentPage
    {
        public Presedant()
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
    }
}