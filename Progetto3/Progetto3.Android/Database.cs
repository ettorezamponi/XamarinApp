using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Progetto3.Droid;
using SQLite;
using Xamarin.Forms;
using static Progetto3.Prenotazione;

[assembly:Dependency(typeof(Database_Android))]

namespace Progetto3.Droid
{
    public class Database_Android : IDatabase
    {
        public Database_Android() { }

        public SQLiteConnection DBconnect()
        {
            var filename = "UmbrellaSQLite.db3";
            string folder =
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}