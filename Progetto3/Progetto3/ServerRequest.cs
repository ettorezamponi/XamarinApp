using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace Progetto3
{
    class ServerRequest
    {
        private string URL;
        private HttpClient _client;
        private PopupView popupView;

        public ServerRequest(PopupView popupView,string URL)
        {
            this.popupView = popupView;
            this.URL = URL;
            this._client = new HttpClient();
        }

        public async void Login(string username, string password)
        {
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("username",username),
                new KeyValuePair<string, string>("password",password)
            });

            var response = await _client.PostAsync(URL, formcontent);
            if(response.IsSuccessStatusCode)
            {
                string responseText = response.Content.ReadAsStringAsync().Result.ToString();
                popupView.Insert_Result(responseText);
            }
            else
            {
                Debug.WriteLine("Errore nella connessione al server");
            }
        }
    }
}
