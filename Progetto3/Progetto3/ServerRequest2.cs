using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Diagnostics;

namespace Progetto3
{
    class ServerRequest2
    {
        private string URL;
        private HttpClient _client2;
        private PopupView2 popupView2;

        public ServerRequest2(PopupView2 popupView2, string URL)
        {
            this.popupView2 = popupView2;
            this.URL = URL;
            this._client2 = new HttpClient();
        }

        public async void SetUtentePost(Utente ut)
        {
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("username",ut.Username),
                new KeyValuePair<string, string>("password",ut.Password),
                new KeyValuePair<string,string>("email",ut.Email),
                //Potrebbe mancare l'id?
            });

            var response = await _client2.PostAsync(URL, formcontent);
            if (response.IsSuccessStatusCode)
            {
                string responseText = response.Content.ReadAsStringAsync().Result.ToString();
                popupView2.Insert_Result2(responseText);
                Debug.WriteLine("Inserimento corretto");
            }
            else
            {

                Debug.WriteLine("Error while inserting User in Post");
            }
        }
    }
}
