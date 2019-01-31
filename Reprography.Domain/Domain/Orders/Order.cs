using Reprography.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprography.Domain.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Detail { get; set; }
        public string DeliveryInstructions { get; set; }
        public DateTime? DateTimeRequired { get; set; }
        public string Remarks { get; set; }
        public string PhoneNumber { get; set; }


        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<OrderStatus> OrderStatus { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }



    }
}
