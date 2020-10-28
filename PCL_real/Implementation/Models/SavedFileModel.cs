using PCL_real.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_real.Implementation.Models
{
    public class SavedFileModel : ISavedFileModel
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
    }
}
