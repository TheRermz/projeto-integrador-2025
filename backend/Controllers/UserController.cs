using System.ComponentModel;
using api_mrp.Data;
using api_mrp.Objects.Models;
using api_mrp.Repositorios.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_mrp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepostorio _userRepostorio;
        private readonly MrpDBContext _dbContext;

        public UserController(IUserRepostorio userRepostorio, MrpDBContext dbContext)
        {
            _dbContext = dbContext;
            _userRepostorio = userRepostorio;
        }

        [HttpGet("usuarios")]
        public async Task<ActionResult<List<UserModel>>> GetAllUsers()
        {
            List<UserModel> users = await _userRepostorio.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("usuarios/{id}")]
        public async Task<ActionResult<UserModel>> GetUserById(int id)
        {
            UserModel user = await _userRepostorio.GetUser(id);
            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserModel>> AddUser([FromBody] UserModel userModel)
        {
            UserModel user = await _userRepostorio.AddUser(userModel);
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserModel>> Login([Bind("matricula, senha")] ValidationModel login)
        {
            UserModel user = await _userRepostorio.AuthenticUser(login);
            return Ok(new { message = "Login realizado com sucesso" });

        }
    }
}
