using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherStation.Pages;
using WeatherStation.ViewModel;
using Xamarin.Forms;

namespace WeatherStation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var viewModel = new WeatherViewModel();
            //this.MainPage = new WeatherPage(viewModel);

            // Samme som ovenstående...
            this.MainPage = new WeatherPage(new WeatherViewModel());


            // Bindings.......











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
