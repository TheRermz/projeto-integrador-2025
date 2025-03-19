using api_mrp.Data;
using api_mrp.Objects.Models;
using Microsoft.EntityFrameworkCore;

namespace api_mrp;

public class ProductsRepositorio : IProductsRepositorio
{

    private readonly UserDBContext _dbContext;

    public ProductsRepositorio(UserDBContext context)
    {
        _dbContext = context;
    }

    public async Task<ProductsModel> AddProducts(ProductsModel products)
    {
        var machineId = await _dbContext.Machines.FirstOrDefaultAsync(x => x.id == products.id_Maquina);

        if (machineId == null)
        {
            throw new Exception("Maquina não encontrada não encontrado");
        }

        await _dbContext.Products.AddAsync(products);
        await _dbContext.SaveChangesAsync();
        return products;
    }

    public async Task<List<ProductsModel>> GetAllProducts()
    {
        return await _dbContext.Products.ToListAsync();
    }

    public async Task<ProductsModel> GetProducts(int id)
    {
        var products = await _dbContext.Products.FirstOrDefaultAsync(x => x.id == id);
        if (products == null)
        {
            throw new Exception("Produto não encontrado");
        }

        return products;
    }

    public async Task<bool> DeleteProducts(int id)
    {
        ProductsModel products = await GetProducts(id);
        if (products == null)
        {
            throw new Exception("Produto não encontrado");
        }

        _dbContext.Products.Remove(products);
        await _dbContext.SaveChangesAsync();
        return true;

    }
}
