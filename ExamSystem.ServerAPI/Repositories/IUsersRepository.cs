using ExamSystem.ServerAPI.Models;

namespace ExamSystem.ServerAPI.Repositories
{
    public interface IUsersRepository
    {
        Task<bool> Check_ExistingUser(string userid);
        Task<List<User>> GetAllUsers();
        Task<bool> UserRegister(User user);
        Task<User> ValidateUser(string name, string userid);
    }
}