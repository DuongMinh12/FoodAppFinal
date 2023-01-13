using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void txtsetting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SettingPage());
        }

        private async void btRegister_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignIn());
        }
    }
}