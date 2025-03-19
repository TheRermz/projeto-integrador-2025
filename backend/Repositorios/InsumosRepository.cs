using api_mrp.Data;
using api_mrp.Objects.Models;
using api_mrp.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_mrp.Repositorios
{
    public class InsumosRepository : IInsumosRepository
    {
        private readonly UserDBContext _dbContext;

        public InsumosRepository(UserDBContext context)
        {
            _dbContext = context;
        }

        public async Task<InsumosModel> AddInsumos(InsumosModel insumos)
        {
            var userId = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == insumos.id);

            if (userId == null)
            {
                throw new Exception("Insumos não encontrados!");
            }

            await _dbContext.Insumos.AddAsync(insumos);
            await _dbContext.SaveChangesAsync();
            return insumos;
        }

        public async Task<bool> DeleteInsumos(int id)
        {
            InsumosModel insumos = await GetInsumos(id);

            if (insumos == null)
            {
                throw new Exception("Insumos não encontrados!");
            }

            _dbContext.Insumos.Remove(insumos);

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<InsumosModel>> GetAllInsumos()
        {
            return await _dbContext.Insumos.ToListAsync();
        }

        public async Task<InsumosModel> GetInsumos(int id)
        {
            var insumos = await _dbContext.Insumos.FirstOrDefaultAsync(x => x.id == id);
            if (insumos == null)
            {
                throw new Exception("Insumos não encontrados!");
            }
            return insumos;
        }
    }
}