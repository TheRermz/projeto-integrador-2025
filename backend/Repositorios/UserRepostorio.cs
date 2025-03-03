using api_mrp.Data;
using api_mrp.Models;
using api_mrp.Repositorios.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

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
    }
}
