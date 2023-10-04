using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BilderApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

   //damit beim Öffnen der nächsten Seite die Daten erhalten bleiben,
   //wird ein temporärer Speicher benötigt. Hierzu nutzen wir
   //statische Variablen. Diese können ohne Instanziierung
   //unter Nennung der Klasse genutzt werden
        private  void AusgewähltesBild(object sender, EventArgs args)
        {         
            Statisch1.idQuelle = Lbl2.Text;
            Statisch1.frageQuelle = Lbl3.Text;
            Statisch1.antwortQuelle = Lbl4.Text;
            Navigation.PushAsync(new Kartenansicht());            
        }

    }
}
