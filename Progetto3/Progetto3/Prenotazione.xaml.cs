using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Rg.Plugins.Popup.Services;

namespace Progetto3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Prenotazione : ContentPage
	{
		public Prenotazione ()
		{
			InitializeComponent ();
            //faccio tutte le 16 insert e poi riprendo value con la select/get<Item>(1)
            //cambio dinamico di immagine guarda naming di xaml e cambia il source

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(folder, "UmbrellaSQLite.db3");

            var database = new SQLite.SQLiteConnection(databasePath);
            database = DependencyService.Get<IDatabase>().DBConnect();

            database.CreateTable<Item>();

            var item = new Item { id = 0, value = false };
            item = new Item { id = 1, value = false };
            item = new Item { id = 2, value = false };
            item = new Item { id = 3, value = false };
            item = new Item { id = 4, value = false };
            item = new Item { id = 5, value = false };
            item = new Item { id = 6, value = false };
            item = new Item { id = 7, value = false };
            item = new Item { id = 8, value = false };
            item = new Item { id = 9, value = false };
            item = new Item { id = 10, value = false };
            item = new Item { id = 11, value = false };
            item = new Item { id = 12, value = false };
            item = new Item { id = 13, value = false };
            item = new Item { id = 14, value = false };
            item = new Item { id = 15, value = false };

            database.Insert(item);
        }

        //databse.get(item)=false --> umbrella_free
        //database.get(item) = true-->umbrella_busy
        //database.get(item) value = true
        //database update
        //database non me la vede
        public void Libero0(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("Name"))
            {
                DisplayAlert("Prenotazione effettuata", null, "Ok");
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;

                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone0.Source = "umbrella_busy.png";
                }
                
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
    }
}