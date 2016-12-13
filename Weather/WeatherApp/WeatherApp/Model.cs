using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Model
    {
        private DataService dataService;

        public Model(DataService dataService)
        {
            this.dataService = dataService;
        }

        public async Task<Weather> GetWeather()
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "34eca85ba279224ae2ca92f34bef7c82";

            //string latitude = "55.676098";
            //string longitude = "12.5683";
            string cityID = "2618425";

            string queryString = "http://api.openweathermap.org/data/2.5/forecast?id="
                + cityID + "&units=metric&cnt=3&appid=" + key;

            //string queryString = "http://api.openweathermap.org/data/2.5/weather?lat="
            //    + latitude + "&lon=" + longitude + "&units=metric&appid=" + key;

            //string queryString = "http://api.openweathermap.org/data/2.5/forecast?q="
            //    + "copenhagen&units=metric&appid=" + key;

            var results = await dataService.getDataFromService(queryString).ConfigureAwait(false);

//            Debug.WriteLine(queryString);

//            if (results["weather"] != null)  // Med "weather" API skal man validere på "weather"
            if (results["city"] != null)     //   Med "forecast" API skal man validere på "city"
            {
                    Debug.WriteLine("OKOKOK");
                Weather weather = new Weather();
                weather.Place = (string)results["city"]["name"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);                    // Viser dato for det første forecast
                DateTime dt = time.AddSeconds((double)results["list"][0]["dt"]).ToLocalTime();
                weather.DatoTid = dt.ToString("dddd', d.'dd MMMM yyyy", new CultureInfo("da"));


                //weather.Temperature = (string)results["main"]["temp"] + " C";
                //weather.Wind = (string)results["wind"]["speed"] + " M/sek";
                //weather.Humidity = (string)results["main"]["humidity"] + " %";
                //weather.Visibility = (string)results["weather"][0]["main"];







                return weather;
            }
            else
            {
                return null;
            }
        }




        //public async Task<Weather> GetWeather()
        //{
        //    //Currently we are always using Copenhagen as reference. In a real live scenario, we would use dependency injection to inject the native GPS service into
        //    //this class in order to get the proper latitude and longitude

        //    //Sign up for a free API key at http://openweathermap.org/appid
        //    string key = "34eca85ba279224ae2ca92f34bef7c82";

        //    string queryString = "http://api.openweathermap.org/data/2.5/forecast?q=copenhagen"
        //        + "&units=metric&appid=" + key;

        //    var results = await dataService.getDataFromService(queryString).ConfigureAwait(false);

        //    if (results["weather"] != null)
        //    {
        //        Weather weather = new Weather();
        //        weather.Place = (string)results["name"];
        //        weather.Altitude = "??"; //have not yet figured out how to retrieve the altitude


        //        //parsing date/time
        //        var timeUnixEpochString = (string)results["dt"];
        //        double timeUnixEpochDouble;
        //        var unixEpochParsedOk = Double.TryParse(timeUnixEpochString, out timeUnixEpochDouble);
        //        if (unixEpochParsedOk)
        //        {
        //            DateTime localtime = UnixTimestampToDateTime(timeUnixEpochDouble);
        //            weather.DateString = localtime.ToString("dddd, MMMM d");
        //            weather.TimeString = localtime.ToString("HH:mm");
        //        }

        //        weather.Humidity = (string)results["main"]["humidity"];

        //        weather.TemperatureCelcius = (string)results["main"]["temp"];

        //        //parsing winddirection
        //        var windDirectionString = (string)results["wind"]["deg"];
        //        double windDirectionDouble;
        //        var windParsedOk = Double.TryParse(windDirectionString, out windDirectionDouble);
        //        if (windParsedOk)
        //        {
        //            weather.WindDirection = windDirectionDouble;
        //        }
        //        return weather;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static DateTime UnixTimestampToDateTime(double unixTime)
        //{
        //    var unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        //    long unixTimeStampInTicks = (long)(unixTime * TimeSpan.TicksPerSecond);
        //    var utcDateTime = new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);
        //    //Now add an hour to get danish time, as Unix time in UTC
        //    return utcDateTime.AddHours(1); //note that this should normally be done in a valueconverter, so that the model is not poluted with local data.
        //}


    }
}
