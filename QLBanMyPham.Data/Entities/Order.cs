using QLBanMyPham.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class Order
    {
        public Guid OrderID { get; set; }
        public Guid UserID { get; set; }

        public DateTime OrderDate { get; set; }
        public StatusOrder Status { get; set; }
        public virtual User User { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }


    }
}
