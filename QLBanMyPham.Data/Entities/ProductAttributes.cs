using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class ProductAttributes
    {
        public Guid ProductAttributesID { get; set; }
        public Guid ProductID { get; set; }
        public string AtributesName { get; set; }
        public string AtributesValue { get; set; }
        public virtual Product Products { get; set; }


    }
}
