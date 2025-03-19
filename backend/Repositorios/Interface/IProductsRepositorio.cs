using api_mrp.Objects.Models;
using System.Collections.Generic;

namespace api_mrp;


public interface IProductsRepositorio
{
    Task<ProductsModel> AddProducts(ProductsModel products);
    Task<List<ProductsModel>> GetAllProducts();
    Task<ProductsModel> GetProducts(int id);
    Task<bool> DeleteProducts(int id);
}
