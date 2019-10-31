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
    public partial class Informazioni : ContentPage
    {
        public Informazioni()
        {
            InitializeComponent();
        }

        private void wifitap(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("La struttura offre una copertura WIFi in tutto il locale e in un raggio d'azione entro 50 metri dalla struttura stessa.");
        }
        private void parktap(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("Tra le comodità offerte dal nostro stabilimento, incluso nel prezzo dell'ombrellone avrete accesso al parcheggio privato custodito che troverete appena arrivati e seguendo le indicazioni stradali.");
        }
        private void showertap(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("Quattro docce grauite a tutti i bagnanti dello stabilimento e possibilità di una doccia calda a €0.50.");

        }
        private void restauranttap(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("MENU: Spaghetti alle vongole, Arrosto misto o Frittura, Dolce e caffe'.");
        }
    }
}