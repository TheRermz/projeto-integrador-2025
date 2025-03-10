using api_mrp.Objects.Models;
using api_mrp.Repositorios.Interface;

namespace api_mrp.Repositorios
{
    public class MachineRepository : IMachineRepository
    {
        public Task<MachinesModel> AddMachines(MachinesModel machines)
        {
            throw new NotImplementedException();
        }

        public Task<MachinesModel> DefineFunctions(MachinesModel machines)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMachines(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MachinesModel>> GetAllMachineModels()
        {
            throw new NotImplementedException();
        }

        public Task<MachinesModel> GetMachines(int id)
        {
            throw new NotImplementedException();
        }
    }
}
