using QLBanMyPham.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public Guid ProductTypeID { get; set; }
        public Guid OriginID { get; set; }
        public string ImageUrl { get; set;}
        
        public string ProductName { get; set;}
        public string Description { get; set;}
        public int Quantity { get; set;}
        public decimal Price { get; set;}
        public StatusProduct Status { get; set;}
        public virtual List<CartItem> CartItem { get; set;}
        public virtual List<OrderDetails> OrderDetails { get; set; }
        public virtual List<ProductAttributes> ProductAttributes { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Origin Origin { get; set; }




    }
}
