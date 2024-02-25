using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;

namespace ExamSystem.ServerAPI.Repositories
{
    public interface IErrorRepository
    {
        Task<List<Error>> GetAllErrors();
        Task<Error> GetErrorById(int id);
        Task<bool> CreateError(Error error);
        Task<bool> UpdateError(Error updatedError);
        Task<bool> DeleteError(int id);
    }
}
