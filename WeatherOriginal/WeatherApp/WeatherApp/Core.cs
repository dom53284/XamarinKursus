using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "34eca85ba279224ae2ca92f34bef7c82";
            //string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="
            //    + zipCode + "&appid=" + key;

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + zipCode + "&units=metric&appid=" + key;

            var results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " C";
                weather.Wind = (string)results["wind"]["speed"] + " M/sek";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                //DateTime now = DateTime.Now;
                //DateTime time = new DateTime(now.Year, now.Month, now.Day);
                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]).ToLocalTime();
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]).ToLocalTime();
                //weather.Sunrise = sunrise.ToString() + " UTC";
                //weather.Sunset = sunset.ToString() + " UTC";
                weather.Sunrise = sunrise.Day.ToString() + "/" + sunrise.Month.ToString() + "-" + sunrise.Year.ToString() + " " + sunrise.TimeOfDay.ToString();
                weather.Sunset = sunset.Day.ToString() + "/" + sunset.Month.ToString() + "-" + sunset.Year.ToString() + " " + sunset.TimeOfDay.ToString();
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}