﻿namespace WeatherApp
{
    public class Weather
    {
        public string Place { get; set; }
        public string Altitude { get; set; }
        public string DatoTid { get; set; }



        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Weather()
        {
            //Because labels bind to these values, set them to an empty string to
            //ensure that the label appears on all platforms by default.

            this.Place = "";
            this.Altitude = "981 meters";
            this.DatoTid = "";

            this.Title = " ";
            this.Temperature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrise = " ";
            this.Sunset = " ";
        }
    }
}