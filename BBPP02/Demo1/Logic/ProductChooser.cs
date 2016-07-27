using Demo1.Model;
using Demo1.Services;
using System.Collections.Generic;
using System;

namespace Demo1.Logic
{
    public class ProductChooser
    {
        private readonly IProductService _svc;

        public ProductChooser(IProductService svc)
        {
            _svc = svc;
        }

        public IEnumerable<Product> FilterByPrice(decimal minPrice)
        {
            var products = _svc.GetAll();

            foreach(var product in products)
            {
                if(product.Price >= minPrice)
                {
                    yield return product;
                }
            }
        }

        public void Add(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                _svc.AddProduct(product);
            }
        }

        public void Add(Product product)
        {
            _svc.AddProduct(product);
        }
    }
}
