using QLBanMyPham.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Application.Interfaces.Service
{
    public interface IProductService
    {
        List<Product> GetAllBooks();
        Product GetProductById(Guid id);
    }
}
