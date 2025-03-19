using api_mrp.Objects.Models;

namespace api_mrp.Repositorios.Interface
{
    public interface IInsumosRepository
    {
        Task<InsumosModel> AddInsumos(InsumosModel insumos);
        Task<List<InsumosModel>> GetAllInsumos();
        Task<InsumosModel> GetInsumos(int id);
        Task<bool> DeleteInsumos(int id);
    }
}