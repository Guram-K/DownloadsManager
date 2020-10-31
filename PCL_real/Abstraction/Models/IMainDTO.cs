using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Abstraction.Models
{
    public interface IMainDTO
    {
        double temp { get; set; }
        int pressure { get; set; }
        int humidity { get; set; }
        double temp_min { get; set; }
        double temp_max { get; set; }
    }
}
