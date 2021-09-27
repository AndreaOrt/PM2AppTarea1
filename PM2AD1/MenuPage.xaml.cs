using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PM2AD1
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void btnAppOpe_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void btnAppPer_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DatosPersonaPage());
        }

    }
}
