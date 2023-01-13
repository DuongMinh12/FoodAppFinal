using AppFood.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppFood.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItems { get; set; }
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://foodsapp-9db14-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                new FoodItem
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageUrl = "MainBurger",
                    Name = "Combo Burger 1",
                    Description = "Burger - Coca - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ImageUrl = "burger1.jpg",
                    Name = "Combo Burger 2",
                    Description = "Burger - Chips - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 40
                },
                new FoodItem
                {
                    ProductID = 3,
                    CategoryID = 1,
                    ImageUrl = "burger2.jpg",
                    Name = "Cheese Burger",
                    Description = "Burger - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 4,
                    CategoryID = 1,
                    ImageUrl = "burger3.jpg",
                    Name = "Combo Burger 3",
                    Description = "Burger - Chips - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 50
                },
                new FoodItem
                {
                    ProductID = 5,
                    CategoryID = 2,
                    ImageUrl = "MainPizza",
                    Name = "Pizza",
                    Description = "Pizza - Breakfast",
                    Rating = " 4.4",
                    RatingDetail = " (120 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 55
                },
                new FoodItem
                {
                    ProductID = 6,
                    CategoryID = 2,
                    ImageUrl = "pizza1.jpg",
                    Name = "Pizza Hawaii",
                    Description = "Pizza v- Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (156 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 50
                },
                new FoodItem
                {
                    ProductID = 7,
                    CategoryID = 3,
                    ImageUrl = "MainDessert",
                    Name = "Ice Creams",
                    Description = "Icecream - Breakfast",
                    Rating = " 4.4",
                    RatingDetail = " (120 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 30
                },
                new FoodItem
                {
                    ProductID = 8,
                    CategoryID = 3,
                    ImageUrl = "tm1.jpg",
                    Name = "Chocolate Cakes",
                    Description = "Cool Cakes- Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (156 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 9,
                    CategoryID = 2,
                    ImageUrl = "pizza3.jpg",
                    Name = "Cheese Pizza",
                    Description = "Pizza- Breakfast",
                    Rating = " 4.6",
                    RatingDetail = " (135 raitings)",
                    HomeSelected = "EmptyHeart",
                    Price = 45
                },
                new FoodItem
                {
                    ProductID = 10,
                    CategoryID = 3,
                    ImageUrl = "tm4.jpg",
                    Name = "Ice Creams",
                    Description = "Icecream - Breakfast",
                    Rating = " 4.2",
                    RatingDetail = " (140 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 40
                },
                new FoodItem
                {
                    ProductID = 11,
                    CategoryID = 7,
                    ImageUrl = "d2.jpg",
                    Name = "Orange Juice",
                    Description = "Drink - Breakfast",
                    Rating = " 4.7",
                    RatingDetail = " (151 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 35
                },
             };
        }
        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        HomeSelected = item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
