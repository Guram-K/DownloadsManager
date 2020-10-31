using PCL_real.Abstraction.Models;
using PCL_real.Implementation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Abstraction.Services
{
    public interface IWeatherApi
    {
        Task<WeatherModel> GetWeatherData(string city, string key);
        IWeatherDto GetWeatherDto(WeatherModel model);
        MemoryStream GetWeatherIcon(string iconId);
    }
}
