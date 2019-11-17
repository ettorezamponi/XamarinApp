using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Progetto3
{
    public partial class App : Application
    {
        public App()
        {
            if (!Application.Current.Properties.ContainsKey("BlockPref"))
            {
                Application.Current.Properties["BlockPref"] = 0;
                Database DB = new Database();
                DB.Riempi2();
            }
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
