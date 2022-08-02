using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalAPI.Entities;

namespace MinimalAPI.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}