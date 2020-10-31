 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Abstraction.Models
{
    public interface IWeatherInfoDTO
    {
        int id { get; set; }
        string main { get; set; }
        string description { get; set; }
        string icon { get; set; }
    }
}
