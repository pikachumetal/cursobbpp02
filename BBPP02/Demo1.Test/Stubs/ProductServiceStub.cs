using System;
using System.Collections.Generic;
using Demo1.Model;
using Demo1.Services;

namespace Demo1.Test.Stubs
{
    internal class ProductServiceStub : IProductService
    {
        public int AddProduct_Called { get; private set; }
        public void AddProduct(Product product)
        {
            AddProduct_Called++;
        }

        public IEnumerable<Product> GetAll()
        {
            return new[] {
                new Product() { Id =1, Name="ProductStub01", Price = 1},
                new Product() { Id = 2, Name = "ProductStub02", Price = 1 },
                new Product() { Id = 3, Name = "ProductStub03", Price = 10 } };
        }
    }
}