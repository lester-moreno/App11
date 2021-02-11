using System.ComponentModel;
using App11.ViewModels;
using Xamarin.Forms;

namespace App11.Views
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