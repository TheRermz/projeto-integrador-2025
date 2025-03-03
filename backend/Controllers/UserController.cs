using api_mrp.Models;
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
        public UserController(IUserRepostorio userRepostorio)
        {
            _userRepostorio = userRepostorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> GetAllUsers()
        {
            List<UserModel> users = await _userRepostorio.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUserById(int id)
        {
            UserModel user = await _userRepostorio.GetUser(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> AddUser([FromBody] UserModel userModel)
        {
            UserModel user = await _userRepostorio.AddUser(userModel);
            return Ok(user);
        }
    }
}
