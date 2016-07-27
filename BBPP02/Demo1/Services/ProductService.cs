using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Model;
using Demo1.Data;

namespace Demo1.Services
{
    public class ProductService : IProductService
    {
        public void AddProduct(Product product)
        {
            using (var db = new DemoDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using(var db = new DemoDbContext())
            {
                return db.Products.ToList();
            }
        }
    }
}
