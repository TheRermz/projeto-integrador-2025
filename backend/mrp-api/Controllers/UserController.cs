using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mrp_api.Data;
using mrp_api.Objects.Models;
using mrp_api.Repositorios.Interface;

namespace mrp_api.Controllers
{
    [Route("Mrp/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepositorio _userRepositorio;
        private readonly MrpDBContext _dbContext;

        public UserController(IUserRepositorio userRepositorio, MrpDBContext dbContext)
        {
            _userRepositorio = userRepositorio;
            _dbContext = dbContext;
        }

        [HttpGet("/Users")]
        public async Task<ActionResult<List<UserModel>>> GetAllUsers()
        {
            List<UserModel> users = await _userRepositorio.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("/Users/{id}")]
        public async Task<ActionResult<UserModel>> GetUserById(int id)
        {
            UserModel user = await _userRepositorio.GetUserById(id);
            return Ok(user);
        }

        [HttpPost("/Register")]
        public async Task<ActionResult<UserModel>> RegisterUser([FromBody] UserModel userModel)
        {
            UserModel user = await _userRepositorio.AddUser(userModel);
            return Ok(new { message = "Usuario Registrado com sucesso" });
        }

        [HttpPost("/Login")]
        public async Task<ActionResult> Login([FromBody] LoginModel login)
        {
            var user = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.matricula == login.matricula && x.senha == login.senha);

            if (user == null)
                return Unauthorized("Matricula ou Senha incorretas");

            return Ok("Acesso Autorizado");
        }
    }
}
