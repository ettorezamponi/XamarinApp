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

namespace Progetto3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupView2 : PopupPage
	{
		public PopupView2 ()
		{
			InitializeComponent ();
		}
        void Reg_Clicked(object o, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            ServerRequest request = new ServerRequest(this,"http://programmazionemobile.altervista.org/aggiungi_utente_post.php");
            request.SetUtentePost(new Utente(-1, entryUsername.Text.ToString(), entryPassword.Text.ToString()));
            
        }
        
        public class Utente
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            
            public Utente (int id, string username, string password)
            {
                Id = id;
                Username = username;
                Password = password;

            }
        }

        class ServerRequest
        {
            private string URL;
            private HttpClient _client;
            private PopupView2 popupview2;

            public ServerRequest(PopupView2 popupview2, string URL)
            {
                this.popupview2 = popupview2;
                this.URL = URL;
                this._client = new HttpClient();
            }

            public async void SetUtentePost(Utente ut)
            {
                HttpContent formcontent = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string,string>("username",ut.Username),
                new KeyValuePair<string, string>("password",ut.Password)
            });

                var response = await _client.PostAsync(URL, formcontent);
                if (response.IsSuccessStatusCode)
                {
                    string responseText = response.Content.ReadAsStringAsync().Result.ToString();
                    //popupview2.Insert_Result(responseText);
                } else
                {
                    Debug.WriteLine("Error while inserting User in Post");
                }
            }
        }

 
    }
}