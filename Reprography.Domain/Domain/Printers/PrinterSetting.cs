﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Domain.Domaine.Printers
{
    public class PrinterSetting
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public int CapacityPerHour { get; set; }
    }
}
