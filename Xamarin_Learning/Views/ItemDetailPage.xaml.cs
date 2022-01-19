using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Learning.ViewModels;

namespace Xamarin_Learning.Views
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