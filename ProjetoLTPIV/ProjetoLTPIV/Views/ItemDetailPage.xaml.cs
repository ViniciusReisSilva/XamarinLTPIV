using System.ComponentModel;
using Xamarin.Forms;
using ProjetoLTPIV.ViewModels;

namespace ProjetoLTPIV.Views
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