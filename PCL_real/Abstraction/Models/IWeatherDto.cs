using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Abstraction.Models
{
    public interface IWeatherDto
    {
        IEnumerable<IWeatherInfoDTO> weather { get; set; }
        IMainDTO main { get; set; }
        int id { get; set; }
        string name { get; set; }
    }
}
