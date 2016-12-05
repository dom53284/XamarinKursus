using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.ViewModel;
using Xamarin.Forms;

namespace WeatherStation.Pages
{
    public partial class WeatherPage2 : ContentPage
    {
        private WeatherViewModel weatherViewModel;

        public WeatherPage2(WeatherViewModel weatherViewModel)
        {
            weatherViewModel = weatherViewModel;

            BindingContext = this.weatherViewModel;

            InitializeComponent();

        }
    }
}
