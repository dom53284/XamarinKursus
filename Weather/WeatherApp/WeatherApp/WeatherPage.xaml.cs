using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        private ViewModel myViewModel;

        public WeatherPage(ViewModel viewModel)
        {
            InitializeComponent();

            this.myViewModel = viewModel;

            BindingContext = myViewModel.CurrentWeather;

            GetNewWeather();

        }

        public async void GetNewWeather()
        {
            await myViewModel.UpdateAllWeather();
            BindingContext = myViewModel.CurrentWeather;

            //Weather weather = await Core.GetWeather("København");
            //if (weather != null)
            //{
            //    this.BindingContext = weather;
            //    //getWeatherBtn.Text = "Søg igen";
            //}

        }



        //private WeatherViewModel weatherViewModel;

        //public WeatherPage2(WeatherViewModel weatherViewModel)
        //{
        //    weatherViewModel = weatherViewModel;

        //    BindingContext = this.weatherViewModel;

        //    InitializeComponent();

        //}








        //public WeatherPage()
        //{
        //    InitializeComponent();
        //    this.Title = "Sample Weather App";
        //    getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

        //    //Set the default binding to a default object for now
        //    this.BindingContext = new Weather();
        //}

        //private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        //{
        //    //if (!String.IsNullOrEmpty(zipCodeEntry.Text))
        //    if (!String.IsNullOrEmpty(byNavnEntry.Text))
        //    {
        //        //Weather weather = await Core.GetWeather(zipCodeEntry.Text);
        //        Weather weather = await Core.GetWeather(byNavnEntry.Text);
        //        if (weather != null)
        //        {
        //            this.BindingContext = weather;
        //            getWeatherBtn.Text = "Søg igen";
        //        }
        //    }
        //}


    }
}