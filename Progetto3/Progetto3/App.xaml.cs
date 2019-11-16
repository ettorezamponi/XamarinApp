using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Progetto3
{
    public partial class App : Application
    {
        static NoteDatabase database;
        public static NoteDatabase Database
        {
            get
            {
                if (database==null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UmbrellaSQLite.db3"));
                }
                return database;
            }
        }

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
            // MainPage = new NavigationPage(new NotesPage());
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
