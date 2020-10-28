using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Abstraction.Models
{
    public interface ISavedFileModel
    {
        string FullPath { get; set; }
        string FileName { get; set; }
        string Extension { get; set; }
    }
}
