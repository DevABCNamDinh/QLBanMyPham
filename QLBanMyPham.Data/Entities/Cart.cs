﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Data.Entities
{
    public class Cart
    {
        public Guid CartID { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public virtual List<CartItem> CartItems { get; set;}
    }
}
