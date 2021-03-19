using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
      [ApiController]
      [Route("api/[controller]")]
      public class ProductsController : ControllerBase
      {
            private readonly IProductRepository _repository;
            public ProductsController(IProductRepository repository)
            {
                  _repository = repository;
            }

            [HttpGet]
            public async Task<ActionResult<IReadOnlyList<Product>>> GetProductsAsync()
            {
                  try
                  {
                        var products = await _repository.GetProductsAsync();
                        return Ok(products);
                  }
                  catch
                  {
                        return BadRequest("Unable to retrieve products.");
                  }
            }

            [HttpGet("{productId}")]
            public async Task<ActionResult<Product>> GetProductByIdAsync(int productId)
            {
                  try
                  {
                        var product = await _repository.GetProductByIdAsync(productId);
                        return Ok(product);
                  }
                  catch
                  {
                        return BadRequest("Unable to find requested product.");
                  }
            }
      }
}