using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.View;

namespace WeatherApp.Presenter
{
    public class WeatherPresenter : IWeatherAppPresenter
    {
        private readonly FormWeatherApp _viewWeatherApp;
    

        public WeatherPresenter(FormWeatherApp view)
        {
            _viewWeatherApp = view;
        }

        public WeatherPresenter()
        {

        }

        public void StartApplication()
        {
            _viewWeatherApp.StartApplication();
        }

        public string DetermineLocation()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"http://api.ipstack.com/check?access_key=fc3e2a13f4fe42814bff600fac16ac9b");
                var data = JObject.Parse(result);

                return (string)data["city"];
            }
        }



        public void UnitsSet(string Units)
        {
            Options.Units = Units;
        }

        public JObject WeatherSet()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?q={WeatherModel.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={Options.Units}");
                var data = JObject.Parse(result);
                return data;
            }
        }

        public JObject ForecastSet()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/forecast?q={WeatherModel.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={Options.Units}");
                var data = JObject.Parse(result);
                return data;
            }
        }

        public void TodayWeatherSet()
        {
            var data = WeatherSet();
            WeatherModel.City = (string)data["name"];
            WeatherModel.Description = (string)data["weather"][0]["description"];
            WeatherModel.Temperature = (float)data["main"]["temp"];
            WeatherModel.MinTemperature = (int)data["main"]["temp_min"];
            WeatherModel.MaxTemperature = (int)data["main"]["temp_max"];
            WeatherModel.Speed = (float)data["wind"]["speed"];
            WeatherModel.Clouds = (int)data["clouds"]["all"];
            WeatherModel.Pressure = (float)data["main"]["pressure"];
            WeatherModel.Humidity = (float)data["main"]["humidity"];
            WeatherModel.Picture = (string)data["weather"][0]["icon"];
        }

        public void TommorowWeatherSet()
        {
            var data = ForecastSet();
            WeatherModel.City = (string)data["city"]["name"];
            for (int i = 6; i < 13; i++) // Подсчет средней минимальной и максимальной погоды
            {
                if ((int)data["list"][i]["main"]["temp_min"] < WeatherModel.MinTemperature)
                {
                    WeatherModel.MinTemperature = (int)data["list"][i]["main"]["temp_min"];
                }
                if ((int)data["list"][i]["main"]["temp_max"] > WeatherModel.MaxTemperature)
                {
                    WeatherModel.MaxTemperature = (int)data["list"][i]["main"]["temp_max"];
                }
            }
            WeatherModel.Description = (string)data["list"][WeatherModel.TommorowShowIndex]["weather"][0]["description"];
            WeatherModel.Temperature = (float)data["list"][WeatherModel.TommorowShowIndex]["main"]["temp"];
            WeatherModel.Speed = (float)data["list"][WeatherModel.TommorowShowIndex]["wind"]["speed"];
            WeatherModel.Clouds = (int)data["list"][WeatherModel.TommorowShowIndex]["clouds"]["all"];
            WeatherModel.Pressure = (float)data["list"][WeatherModel.TommorowShowIndex]["main"]["pressure"];
            WeatherModel.Humidity = (float)data["list"][WeatherModel.TommorowShowIndex]["main"]["humidity"];
            WeatherModel.Date = (string)data["list"][WeatherModel.TommorowShowIndex]["dt_txt"];
            WeatherModel.Picture = (string)data["list"][WeatherModel.TommorowShowIndex]["weather"][0]["icon"];
        }

       
    
    }
}
