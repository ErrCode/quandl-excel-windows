﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quandl.Shared.Models
{
    public interface IDataStructure
    {
        List<DataColumn> Column { get; set; }
    }
}
