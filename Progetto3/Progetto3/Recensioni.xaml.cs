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
	public partial class Recensioni : ContentPage
	{
		public Recensioni ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetReviewsAsync();
        }

        async void OnReviewAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewPage
            {
                BindingContext = new Review()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ReviewPage
                {
                    BindingContext = e.SelectedItem as Review
                });
            }
        }
    }

    internal class ReviewPage : Page
    {
      
            async void OnSaveButtonClicked(object sender, EventArgs e)
            {
                var note = (Review)BindingContext;
                await App.Database.SaveReviewAsync(note);
                await Navigation.PopAsync();
            }

            async void OnDeleteButtonClicked(object sender, EventArgs e)
            {
                var note = (Review)BindingContext;
                await App.Database.DeleteReviewAsync(note);
                await Navigation.PopAsync();
            }
     }
}
