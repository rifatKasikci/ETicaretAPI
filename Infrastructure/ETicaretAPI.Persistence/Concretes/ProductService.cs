using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        { 
            new() {Id = Guid.NewGuid(), ProductName="Product 1",Price=100, Stock=10},
            new() {Id = Guid.NewGuid(), ProductName="Product 2",Price=150, Stock=15},
            new() {Id = Guid.NewGuid(), ProductName="Product 3",Price=200, Stock=20},
            new() {Id = Guid.NewGuid(), ProductName="Product 4",Price=250, Stock=25},
        };
    }
}
