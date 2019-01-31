using Reprography.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Domain.Orders
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string DocumentName { get; set; }
        public string Attachement { get; set; }
        public int Qte { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }


        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }

        public Guid OrderItemOptionId { get; set; }
        public virtual OrderIemOption OrderIemOption { get; set; }


    }
}
