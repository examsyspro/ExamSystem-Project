using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;

namespace ExamSystem.ServerAPI.Repositories
{
    public interface IParticipationRepository
    {
        Task<List<Participation>> GetAllParticipations();
        Task<Participation> GetParticipationById(int id);
        Task<bool> CreateParticipation(Participation participation);
        Task<bool> UpdateParticipation(Participation updatedParticipation);
        Task<bool> DeleteParticipation(int id);
    }
}