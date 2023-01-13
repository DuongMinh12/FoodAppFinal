using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppFood.Helpers;

namespace AppFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private async void btCatagory_Clicked(object sender, EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }

        private async void btProduct_Clicked(object sender, EventArgs e)
        {
            var afd = new AddFoodItemData();
            await afd.AddFoodItemAsync();
        }

        private void btcart_Clicked(object sender, EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
                DisplayAlert("Yay!", "Giỏ hàng đã được tạo", "Ok");
            else
                DisplayAlert("Error", "Giỏ hàng bị lỗi rồi...", "Ok");
        }

        private async void bthome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}