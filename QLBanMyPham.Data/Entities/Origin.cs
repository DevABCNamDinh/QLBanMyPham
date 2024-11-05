using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class Origin
    {
        public Guid OriginID { get; set; }
        public string OriginName { get; set; }
        public virtual List<Product> Products { get; set;}
    }
}
