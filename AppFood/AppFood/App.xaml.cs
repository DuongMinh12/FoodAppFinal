using AppFood.ViewModels;
using AppFood.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new SettingPage();
            //MainPage = new NavigationPage (new SignIn());
            string uname = Preferences.Get("Username", string.Empty);
            if (String.IsNullOrEmpty(uname))
            {
                MainPage = new LoginPage();
            }
            else
            {

                MainPage = new NavigationPage(new ProductPage());

            }
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
