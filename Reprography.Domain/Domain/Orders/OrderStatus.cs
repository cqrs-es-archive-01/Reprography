using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Domain.Orders
{
    public class OrderStatus
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }

        public DateTime TakenOn { get; set; }
        public bool Active { get; set; }


        public Guid OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
