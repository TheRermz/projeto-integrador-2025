using api_mrp;
using api_mrp.Objects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly IProductsRepositorio _productsRepositorio;

        public ProductsController(IProductsRepositorio productsRepositorio)
        {
            _productsRepositorio = productsRepositorio;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ProductsModel>> AddProducts([FromBody] ProductsModel products)
        {
            ProductsModel Products = await _productsRepositorio.AddProducts(products);
            return Ok(products);
        }

        [HttpGet("products")]
        public async Task<ActionResult<List<ProductsModel>>> GetAllProducts()
        {
            List<ProductsModel> products = await _productsRepositorio.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("products/{id}")]
        public async Task<ActionResult<List<ProductsModel>>> GetProductsById(int id)
        {
            ProductsModel products = await _productsRepositorio.GetProducts(id);
            return Ok(products);
        }

        [HttpDelete("products/delete/{id}")]
        public async Task<ActionResult<ProductsModel>> DeleteProductsById(int id)
        {
            bool deletado = await _productsRepositorio.DeleteProducts(id);
            return Ok(deletado);
        }
    }
}
