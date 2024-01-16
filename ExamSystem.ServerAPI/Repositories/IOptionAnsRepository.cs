using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.Models;


namespace ExamSystem.ServerAPI.Repositories
{
    public interface IOptionAnsRepository
    {
        Task<List<OptionAns>> GetAllOptionAns();
        Task<OptionAns> GetOptionAnsById(int id);
        Task<bool> CreateOptionAns(OptionAns optionAns);
        Task<OptionAns> UpdateOptionAns(int id, OptionAns updatedOptionAns);
        Task<bool> DeleteOptionAns(int id);
    }
}
