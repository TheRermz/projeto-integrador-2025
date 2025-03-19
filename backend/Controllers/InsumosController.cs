using api_mrp.Objects.Models;
using api_mrp.Repositorios;
using api_mrp.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_mrp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsumosController : Controller
    {
        public readonly IInsumosRepository _insumosRepository;

        public InsumosController(IInsumosRepository insumosRepository)
        {
            _insumosRepository = insumosRepository;
        }

        [HttpPost("insumos")]
        public async Task<ActionResult<InsumosModel>> AddInsumos([FromBody] InsumosModel insumos)
        {
            InsumosModel Insumos = await _insumosRepository.AddInsumos(insumos);
            return Ok(insumos);
        }

        [HttpGet("insumos")]
        public async Task<ActionResult<List<InsumosModel>>> GetAllInsumos()
        {
            List<InsumosModel> insumosModels = await _insumosRepository.GetAllInsumos();
            return Ok(insumosModels);
        }

        [HttpGet("insumos/{id}")]
        public async Task<ActionResult<List<InsumosModel>>> GetInsumosById(int id)
        {
            InsumosModel insumos = await _insumosRepository.GetInsumos(id);
            return Ok(insumos);
        }

        [HttpDelete("insumos/delete/{id}")]
        public async Task<ActionResult<MachinesModel>> DeleteInsumosById(int id)
        {
            bool deletado = await _insumosRepository.DeleteInsumos(id);
            return Ok(deletado);
        }
    }
}