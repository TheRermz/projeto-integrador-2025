using api_mrp.Models;
using api_mrp.Repositorios.Interface;

namespace api_mrp.Repositorios
{
    public class UserRepostorio : IUserRepostorio
    {
        public Task<UserModel> AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetAllUsers(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
