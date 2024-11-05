using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class ProductType
    {
        public Guid ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
