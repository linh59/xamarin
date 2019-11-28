using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_tabs_carousel.Services;
using xamarin_tabs_carousel.Views;

namespace xamarin_tabs_carousel
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
