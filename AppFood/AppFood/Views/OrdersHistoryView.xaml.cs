using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersHistoryView : ContentPage
    {
        public OrdersHistoryView()
        {
            InitializeComponent();
            LabelName.Text = "Lịch sử đặt hàng " + Preferences.Get("Username", "Guest") + ",";
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}