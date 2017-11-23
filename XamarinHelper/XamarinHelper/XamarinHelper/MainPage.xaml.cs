using System;
using Xamarin.Forms;

namespace XamarinHelper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisabledPage());
        }
    }
}
