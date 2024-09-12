using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Repositories;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class ProductApiController : ControllerBase
    {
        public IProductService _service;
        public ProductApiController(IProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_service.GetAllProducts());
        }


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _service.GetProductById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpGet("Category")]
        public IActionResult GetAllProductsByCategory(string Category)
        {
            return Ok(_service.GetAllProductsByCategory(Category));
        }

        [HttpGet("OutOfStockProducts")]
        public IActionResult OutOfStockProducts()
        {
            return Ok(_service.OutOfStockProducts());
        }

        [HttpGet("ProductsRange")]
        public IActionResult ProductsRange(int Min, int Max)
        {
            return Ok(_service.ProductsRange(Min, Max));
        }

        [HttpGet("getCategories")]
        public IActionResult GetCategories()
        {
            return Ok(_service.GetCategories());
        }

        [HttpPost]
        public IActionResult AddProduct(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "Prod Details added to db" });
        }

        [HttpPut]

        public IActionResult EditProduct(Product obj)
        {
            string str = _service.EditProduct(obj);
            return Ok(new { status = str });
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {
            string str = _service.DeleteProduct(id);
            if (str.Equals("1"))
            {
                return Ok(new { status = "Product deleted from database" });
            }
            else
            {
                return NotFound(new { status = "Product not found" });
            }
        }


    }
}
