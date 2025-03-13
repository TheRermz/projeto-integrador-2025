using api_mrp.Data;
using api_mrp.Objects.Models;
using api_mrp.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_mrp.Repositorios
{
    public class MachineRepository : IMachineRepository
    {
        private readonly UserDBContext _dbContext;

        public MachineRepository(UserDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MachinesModel> AddMachines(MachinesModel machines)
        {
            var userId = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == machines.idUser);

            if (userId == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            await _dbContext.Machines.AddAsync(machines);
            await _dbContext.SaveChangesAsync();
            return machines;
        }

        public async Task<MachinesModel> DefineFunctions(MachinesModel machines)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteMachines(int id)
        {
            MachinesModel machines = await GetMachines(id);
            if (machines == null)
            {
                throw new Exception("Máquina não encontrada");
            }

            _dbContext.Machines.Remove(machines);

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<MachinesModel>> GetAllMachines()
        {
            return await _dbContext.Machines.ToListAsync();
        }

        public async Task<MachinesModel> GetMachines(int id)
        {
            return await _dbContext.Machines.FirstOrDefaultAsync(x => x.id == id);
        }
    }
}
