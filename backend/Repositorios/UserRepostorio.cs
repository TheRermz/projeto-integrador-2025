using Microsoft.AspNetCore.Http;
using api_mrp.Data;
using api_mrp.Repositorios.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_mrp.Objects.Models;

namespace api_mrp.Repositorios
{
    public class UserRepostorio : IUserRepostorio
    {

        private readonly UserDBContext _dbContext;

        public UserRepostorio(UserDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserModel> AddUser(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public Task<UserModel> GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserModel> AuthenticUser(ValidationModel login)
        {
            var usuario = await _dbContext.Users.FirstOrDefaultAsync(u => u.matricula == login.matricula);

            if (usuario == null)
            {
                throw new Exception($"Usuario ou Senha Incorretos");
            }

            if (usuario.senha != login.senha)
            {
                throw new Exception($"Usuario ou Senha Incorretos");
            }

            return usuario;

        }

    }
}
