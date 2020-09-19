using System;
using Xamarin.Forms;

namespace Industrial.Views
{
    public partial class ItemsPage : ContentPage
    { 

        public ItemsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            suppliesList.ItemsSource = await App.supplyManager.AvailableSuppliesAsync();
        }

    }
}