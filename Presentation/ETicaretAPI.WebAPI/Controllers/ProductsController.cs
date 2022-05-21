using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
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


        // Controller method for testing structure
        [HttpGet]
        public async Task Get()
        {
            Product product = await _productReadRepository.GetByIdAsync("8db7726a-3038-4fbd-8b9a-c33e2d771755");
            product.ProductName = "Product 1(New)";
            _productWriteRepository.Update(product);
            await _productWriteRepository.SaveAsync();
        }

       
    }
}
