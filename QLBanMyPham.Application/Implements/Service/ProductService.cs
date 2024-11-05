using QLBanMyPham.Application.Interfaces.Repositories;
using QLBanMyPham.Application.Interfaces.Service;
using QLBanMyPham.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanMyPham.Application.Implements.Service
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _BookRepository;
        public ProductService(IGenericRepository<Product> BookRepository)
        {
            _BookRepository = BookRepository;
        }
        public List<Product> GetAllBooks()
        {
            return _BookRepository.GetAll();
        }

        public Product GetProductById(Guid id)
        {
            return _BookRepository.GetById(id);
        }
    }
}
