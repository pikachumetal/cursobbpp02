using Demo1.Model;
using System.Collections.Generic;

namespace Demo1.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        void AddProduct(Product product);
    }
}
