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
        protected SQLiteConnection database;
        
        public Prenotazione()
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
            InitializeComponent();
            if (database.Get<Item>(1).value == 0)
            {
                ombrellone1.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone1.Source = "umbrella_busy.png";
            }

            if (database.Get<Item>(2).value == 0) 
            {
                ombrellone2.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone2.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(3).value == 0)
            {
                ombrellone3.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone3.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(4).value == 0)
            {
                ombrellone4.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone4.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(5).value == 0)
            {
                ombrellone5.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone5.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(6).value == 0)
            {
                ombrellone6.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone6.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(7).value == 0)
            {
                ombrellone7.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone7.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(8).value == 0)
            {
                ombrellone8.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone8.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(9).value == 0)
            {
                ombrellone9.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone9.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(10).value == 0)
            {
                ombrellone10.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone10.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(11).value == 0)
            {
                ombrellone11.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone11.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(12).value == 0)
            {
                ombrellone12.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone12.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(13).value == 0)
            {
                ombrellone13.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone13.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(14).value == 0)
            {
                ombrellone14.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone14.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(15).value == 0)
            {
                ombrellone15.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone15.Source = "umbrella_busy.png";
            }
            if (database.Get<Item>(16).value == 0)
            {
                ombrellone16.Source = "umbrella_free.png";
            }
            else
            {
                ombrellone16.Source = "umbrella_busy.png";
            }

        }

        

        public void Libero1(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("Name"))
            {               
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone1.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='1'").ToString();                   
                }else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }

        public void Libero2(object sender, EventArgs e)
        {
           
            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone2.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='2'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero3(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone3.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='3'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero4(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone4.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='4'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero5(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone5.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='5'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero6(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone6.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='6'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero7(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone7.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='7'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero8(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone8.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='8'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero9(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone9.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='9'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero10(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone10.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='10'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero11(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone11.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='11'").ToString();
                }
                else
                {
                    DisplayAlert("Ombellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero12(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone12.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='12'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero13(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone13.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='13'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero14(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone14.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='14'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero15(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone15.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='15'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
        public void Libero16(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                
                var imageSource = (Image)sender;
                var selectedImage = imageSource.Source as FileImageSource;
                if (selectedImage.File == "umbrella_free.png")
                {
                    ombrellone16.Source = "umbrella_busy.png";
                    DisplayAlert("Prenotazione effettuata", null, "Ok");
                    database.Execute("UPDATE " + "Item" + " Set value= '" + "1" + "' WHERE id='16'").ToString();
                }
                else
                {
                    DisplayAlert("Ombrellone già prenotato", null, "Ok");
                }
            }
            else
            {
                DependencyService.Get<Toast>().Show("Per poter prenotare un ombrellone devi registrarti!");
            }
        }
    }
}