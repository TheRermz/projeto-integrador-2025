using api_mrp.Models;

namespace api_mrp.Repositorios.Interface
{
    public interface IUserRepostorio
    {
        Task<List<UserModel>> GetAllUsers();
        Task<UserModel> GetUser(int id);
        Task<UserModel> AddUser(UserModel user);
    }
}
