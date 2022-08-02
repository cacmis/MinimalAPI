using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalAPI.Entities;
using MinimalAPI.Services.Interfaces;

namespace MinimalAPI.Services
{
    public class ProductService : IProductService
    {
        
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 1.99m, Stock = 2 },
                new Product { Id = 2, Name = "Product 2", Price = 2.99m, Stock = 0 },
                new Product { Id = 3, Name = "Product 3", Price = 3.99m, Stock = 3 },
                new Product { Id = 4, Name = "Product 4", Price = 4.99m, Stock = 4 },
                new Product { Id = 5, Name = "Product 5", Price = 5.99m, Stock = 5 },
                new Product { Id = 6, Name = "Product 6", Price = 6.99m, Stock = 6 }
                
            };
        }
    }
    
}