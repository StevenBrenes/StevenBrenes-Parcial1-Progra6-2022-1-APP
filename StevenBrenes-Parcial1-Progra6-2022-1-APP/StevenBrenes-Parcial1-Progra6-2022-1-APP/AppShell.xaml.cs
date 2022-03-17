using StevenBrenes_Parcial1_Progra6_2022_1_APP.ViewModels;
using StevenBrenes_Parcial1_Progra6_2022_1_APP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace StevenBrenes_Parcial1_Progra6_2022_1_APP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
