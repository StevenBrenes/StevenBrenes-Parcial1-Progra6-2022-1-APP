using StevenBrenes_Parcial1_Progra6_2022_1_APP.Services;
using StevenBrenes_Parcial1_Progra6_2022_1_APP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StevenBrenes_Parcial1_Progra6_2022_1_APP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
