using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BilderApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();
           //notwendig für die Navigation
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
