using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Progetto3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupRecensioni : PopupPage
    {
        public PopupRecensioni()
        {
            InitializeComponent();
        }

        protected SQLiteConnection database;

        public void insert_recensione(object sender, EventArgs e)
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
            database.CreateTable<Recensione>();
            string name = entryRecensione.Text;
            database.Query<Recensione>("INSERT INTO Recensione (Description) values('" + name + "')");
            var reviews = database.Table<Recensione>().ToList();
            PopupNavigation.PopAsync();
            DependencyService.Get<Toast>().Show("Recensione inserita con successo");
        }
    }
}