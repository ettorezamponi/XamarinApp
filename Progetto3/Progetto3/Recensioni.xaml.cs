using Rg.Plugins.Popup.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Progetto3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recensioni : ContentPage
    {
        public Recensioni()
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
            database.CreateTable<Recensione>();
            var reviews = database.Table<Recensione>().ToList();
            InitializeComponent();
            reviewslist.ItemsSource = reviews;
        }

        protected SQLiteConnection database;

        public void new_recensione(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("Name"))
            {
                PopupNavigation.Instance.PushAsync(new PopupRecensioni());
                database = DependencyService.Get<IDatabase>().DBConnect();
                database.CreateTable<Recensione>();
                var reviews = database.Table<Recensione>().ToList();
            }
            else
            {
                DependencyService.Get<Toast>().Show("Devi essere registrato per inserire una recensione");
            }
        }

        public void new_pressed(object sender, EventArgs e)
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
            database.CreateTable<Recensione>();
            var reviews = database.Table<Recensione>().ToList();
            reviewslist.ItemsSource = reviews;
        }
    }
}