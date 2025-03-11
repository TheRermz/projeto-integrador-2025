using api_mrp.Objects.Models;
using api_mrp.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_mrp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : Controller
    {
        public readonly IMachineRepository _machineRepository;

        public MachinesController(IMachineRepository machineRepository)
        {
            _machineRepository = _machineRepository;
        }

        [HttpGet("machines")]
        public async Task<ActionResult<List<MachinesModel>>> GetAllMachines()
        {
            List<MachinesModel> machines = await _machineRepository.GetAllMachines();
            return Ok(machines);
        }

        [HttpGet("machines/{id}")]
        public async Task<ActionResult<List<MachinesModel>>> GetMachineById(int id)
        {
            MachinesModel machines = await _machineRepository.GetMachines(id);
            return Ok(machines);
        }

        [HttpDelete("machines/delete/{id}")]
        public async Task<ActionResult<MachinesModel>> DeleteMachineById(int id)
        {
            bool deletado = await _machineRepository.DeleteMachines(id);
            return Ok(deletado);
        }
    }
}
