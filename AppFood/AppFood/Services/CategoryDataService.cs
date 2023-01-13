using AppFood.Model;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace AppFood.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://foodsapp-9db14-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories").OnceAsync<Category>()).Select(c => new Category

            {
                CategoryID = c.Object.CategoryID,
                CategoryName = c.Object.CategoryName,
                CategoryPoster = c.Object.CategoryPoster,
                ImageUrl = c.Object.ImageUrl

            }).ToList();

            return categories;
        }
    }
}
