using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Progetto3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupView : PopupPage
	{
		public PopupView ()
		{
			InitializeComponent ();
		}

       public async void Log_Clicked(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);

            if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await DisplayAlert("Attenzione", "Non sei connesso a internet", "Ok");
            } else
            {
                if (string.IsNullOrEmpty(entryUsername2.Text) || string.IsNullOrEmpty(entryPassword2.Text))
                {
                    await DisplayAlert("Attenzione", "Riempi tutti i campi", "Ok");
                }
                if(entryUsername2.Text.Contains('=') || entryPassword2.Text.Contains('='))
                {
                    DependencyService.Get<Toast>().Show("Alcuni caratteri non sono permessi");
                }
                else
                {
                    ServerRequest request = new ServerRequest(this, "http://programmazionemobile.altervista.org/login.php");
                    request.Login(entryUsername2.Text.ToString(), entryPassword2.Text.ToString());
                }
            }

        }

        public void Insert_Result(string ans)
        {
            if(ans=="1")
            {
                DependencyService.Get<Toast>().Show("Utente loggato.");
                App.Current.Properties["Name"] = 1;
            }
            else
            {
                DisplayAlert("Attenzione", "I dati inseriti sono errati", "Ok");
            }
        }
	}
}