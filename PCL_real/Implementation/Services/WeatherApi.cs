using Newtonsoft.Json;
using PCL_real.Abstraction.Models;
using PCL_real.Abstraction.Services;
using PCL_real.Implementation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Implementation.Services
{
    public  class WeatherApi : IWeatherApi
    {
        public static string BaseUrI { get; set; } = @"http://api.openweathermap.org/data/2.5/";

        public async Task<WeatherModel> GetWeatherData(string city, string key)
        {
            WeatherModel weather = new WeatherModel();

            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync($"{BaseUrI}weather?q={city}&appid={key}");
                if (result.IsSuccessStatusCode)
                {
                    var response = await result.Content.ReadAsStringAsync();
                    weather = JsonConvert.DeserializeObject<WeatherModel>(response);
                }
            }

            return weather;
        }

        public IWeatherDto GetWeatherDto(WeatherModel model)
        {
            return new WeatherDto()
            {
                id = model.id,
                name = model.name,
                weather = model.weather,
                main = model.main
            };
        }

        public MemoryStream GetWeatherIcon(string iconId)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData($"http://openweathermap.org/img/wn/{iconId}@2x.png");

            return new MemoryStream(bytes);
        }

    }
}
