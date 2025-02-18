﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PCL_real.Abstraction.Models
{
    public interface IFileModel
    {
        string FullSourcePath { get; set; }
        string BasePath { get; set; }
        string FileName { get; set; }
        string Extension { get; set; }
        string TargetPath { get; set; }
        string FullTargetPath { get; set; }
        DateTime Creation { get; set; }
        DateTime Modification { get; set; }
    }
}
