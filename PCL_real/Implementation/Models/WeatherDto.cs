using PCL_real.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Implementation.Models
{
    public class WeatherDto : IWeatherDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public IEnumerable<IWeatherInfoDTO> weather { get; set; }
        public IMainDTO main { get; set; }
    }

    public class WeatherInfoDTO : IWeatherInfoDTO
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class MainDTO : IMainDTO
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }
}
