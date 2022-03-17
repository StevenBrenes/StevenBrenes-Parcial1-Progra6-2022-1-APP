using StevenBrenes_Parcial1_Progra6_2022_1_APP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StevenBrenes_Parcial1_Progra6_2022_1_APP.Views
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