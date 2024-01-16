using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.Models;

namespace ExamSystem.ServerAPI.Repositories
{
    public interface IStudentExamRepository
    {

        Task<List<StudentExam>> GetAllStudentExams();
        Task<StudentExam> GetStudentExamById(int id);
        Task<bool> CreateStudentExam(StudentExam studentExam);
        Task<StudentExam> UpdateStudentExam(int id, StudentExam updatedStudentExam);
        Task<bool> DeleteStudentExam(int id);

    }
}
