using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class OrderDetails
    {
        public Guid OrderDetailsID { get; set; }
        public Guid ProductID { get; set; }
        public Guid OrderID { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }



    }
}
