using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StevenBrenes_Parcial1_Progra6_2022_1_APP.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}