using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.Models;



namespace ExamSystem.ServerAPI.Repositories
{

    public interface IExamsRepository
    {
        Task<List<Exam>> GetAllExams();
        Task<Exam> GetExamById(int id);
        Task<bool> CreateExam(Exam exam);
        Task<bool> UpdateExam(Exam updatedExam);
        Task<bool> DeleteExam(int id);
        Task<List<Exam>> GetExamsByCourseType(Course_Enum courseType);

    }
}
