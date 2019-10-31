using Rg.Plugins.Popup.Pages;
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
	public partial class PopupView : PopupPage
	{
		public PopupView ()
		{
			InitializeComponent ();
		}

        void Log_Clicked(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }

	}
}