using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BilderApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kartenansicht : ContentPage
    {
        public Kartenansicht()
        {
            InitializeComponent();
            PlatzhalterId.Text = Statisch1.idQuelle;
            PlatzhalterFrage.Text = Statisch1.frageQuelle;
            PlatzhalterAntwort.Text = Statisch1.antwortQuelle;
        }

        private void AntwortAnzeigen_Click(object sender, EventArgs e)
        {
            PlatzhalterAntwort.Opacity = 100;
        }
    }
}