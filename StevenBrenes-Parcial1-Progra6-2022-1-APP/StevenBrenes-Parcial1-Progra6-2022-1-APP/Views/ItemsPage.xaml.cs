using StevenBrenes_Parcial1_Progra6_2022_1_APP.Models;
using StevenBrenes_Parcial1_Progra6_2022_1_APP.ViewModels;
using StevenBrenes_Parcial1_Progra6_2022_1_APP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StevenBrenes_Parcial1_Progra6_2022_1_APP.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}