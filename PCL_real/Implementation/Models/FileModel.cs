using PCL_real.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_real.Implementation.Models
{
    public class FileModel : IFileModel
    {
        public string FullSourcePath { get; set; }
        public string BasePath { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string TargetPath { get; set; }
        public string FullTargetPath { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Modification { get; set; }
    }
}
