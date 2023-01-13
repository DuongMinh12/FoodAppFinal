using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppFood.Droid;
using AppFood.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace AppFood.Droid
{
    class SQLite_Android : ISQLite
    {
        SQLiteConnection ISQLite.GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}