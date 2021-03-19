using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using AutoMapper;
using Core.Contracts;
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
            public async Task<ActionResult<IList<ProductDto>>> GetProductsAsync()
            {
                  var products = await _repository.GetProductsAsync();
                  if (products.Count < 0)
                  {
                        return BadRequest("Unable to retrieve products");
                  }
                  return Ok(products);
            }

            [HttpGet("{productId}")]
            public async Task<ActionResult<ProductDto>> GetProductByIdAsync(int productId)
            {
                  var product = await _repository.GetProductByIdAsync(productId);
                  if (product == null)
                  {
                        return NotFound("Unable to find specified product.");
                  }
                  return Ok(product);
            }
      }
}