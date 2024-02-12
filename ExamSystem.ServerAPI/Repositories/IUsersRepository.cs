using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.Models;

namespace ExamSystem.ServerAPI.Repositories
{
    public interface IUsersRepository
    {
        Task<bool> UserRegister(User user);
        Task<User> GetUserByUserId(string userId);
        Task<User> ValidateUser(string password, string userId);
        Task<List<User>> GetAllUsers();
    }
}
