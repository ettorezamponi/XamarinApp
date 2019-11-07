using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Progetto3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        private void ShowPopup(object sender,EventArgs e) //popuplogin
        {
            PopupNavigation.Instance.PushAsync(new PopupView());
        }
        private void ShowPopup2(object sender,EventArgs e) //popupregistrazione
        {
            PopupNavigation.Instance.PushAsync(new PopupView2());
        }
	}
}