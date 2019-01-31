using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Domain.Orders
{
    public class OrderIemOption
    {
        public bool SingleSided { get; set; }
        public bool BlackWhite { get; set; }
        public PrintFormat Format { get; set; }

    }
}
