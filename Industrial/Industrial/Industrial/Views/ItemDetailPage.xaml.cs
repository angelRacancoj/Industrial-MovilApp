using System.ComponentModel;
using Xamarin.Forms;
using Industrial.ViewModels;

namespace Industrial.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}