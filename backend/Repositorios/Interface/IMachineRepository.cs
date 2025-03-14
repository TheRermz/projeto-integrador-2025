using api_mrp.Objects.Models;

namespace api_mrp.Repositorios.Interface
{
    public interface IMachineRepository
    {
        Task<List<MachinesModel>> GetAllMachines();
        Task<MachinesModel> GetMachines(int id);
        Task<MachinesModel> AddMachines(MachinesModel machines);
        Task<MachinesModel> DefineFunctions(MachinesModel machines);
        Task<bool> DeleteMachines(int id);
    }
}
