using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Progetto3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Prenotazione : ContentPage
	{
		public Prenotazione ()
		{
			InitializeComponent ();

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(folder, "UmbrellaSQLite.db3");

            var database = new SQLite.SQLiteConnection(databasePath);
            database = DependencyService.Get<IDatabase>().DBconnect();

            database.CreateTable<Item>();
        }

        public interface IDatabase
        {
            SQLiteConnection DBconnect();
        }

        private void Libero0(object sender,EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("Name"))
            {
                DependencyService.Get<Toast>().Show("Shared funziona");
            }else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
	}
}