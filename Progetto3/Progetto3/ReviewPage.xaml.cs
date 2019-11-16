using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Progetto3
{
    public partial class ReviewEntryPage : ContentPage
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
