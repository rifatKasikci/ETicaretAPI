using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task<int> Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, ProductName = "Product 1", Price = 500, Stock = 100},
                new() {Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, ProductName = "Product 2", Price = 550, Stock = 150},
                new() {Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, ProductName = "Product 3", Price = 600, Stock = 200},
            });
            return await _productWriteRepository.SaveAsync();
        }
    }
}
