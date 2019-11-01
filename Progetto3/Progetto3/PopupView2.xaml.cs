using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Progetto3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView2 : PopupPage
    {
        public PopupView2()
        {
            InitializeComponent();
        }
        public async void Reg_Clicked(object o, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await DisplayAlert("Attenzione", "Non sei connesso a internet", "Ok");
            }
            else
            {
                if (string.IsNullOrEmpty(entryUsername.Text) || string.IsNullOrEmpty(entryPassword.Text) || string.IsNullOrEmpty(entryEmail.Text))
                {
                    await DisplayAlert("Attenzione", "Riempi tutti i campi", "Ok");
                }
                else
                {
                    ServerRequest2 request = new ServerRequest2(this, "http://programmazionemobile.altervista.org/aggiungi_utente_post.php");
                    request.SetUtentePost(new Utente(-1, entryUsername.Text.ToString(), entryPassword.Text.ToString(), entryEmail.Text.ToString()));
                }
            }

        }

        public void Insert_Result2(string ans)
        {
            if (ans == "1")
            {
                DependencyService.Get<Toast>().Show("Registrazione effettuata.");
            }
            else
            {
                DisplayAlert("Attenzione", "I dati inseriti sono errati", "Ok");
            }
        }
    }
}