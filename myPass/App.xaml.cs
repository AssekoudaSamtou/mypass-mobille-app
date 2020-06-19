using System;
using Walkthrough.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myPass
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WalkthroughView();
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
