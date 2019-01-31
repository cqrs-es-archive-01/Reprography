using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Domain.Orders
{
    public enum Status
    {
        Draft,
        Pending,
        Validated,
        Shipped,
        Done

    }
}
