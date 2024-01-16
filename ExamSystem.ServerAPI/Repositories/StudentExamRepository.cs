using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class StudentExamRepository : IStudentExamRepository
    {
        private readonly AppDbContext _context;

        public StudentExamRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<StudentExam>> GetAllStudentExams()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return await context.StudentExams.ToListAsync();
            }
        }

        public async Task<StudentExam> GetStudentExamById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return await context.StudentExams.FindAsync(id);
            }
        }

        public async Task<bool> CreateStudentExam(StudentExam studentExam)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.StudentExams.Add(studentExam);
                return await context.SaveChangesAsync() > 0;
            }
        }

        public async Task<StudentExam> UpdateStudentExam(int id, StudentExam updatedStudentExam)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var existingStudentExam = await context.StudentExams.FindAsync(id);
                if (existingStudentExam != null)
                {
                    // Update properties of existingStudentExam with values from updatedStudentExam
                    // ...

                    await context.SaveChangesAsync();
                }
                return existingStudentExam;
            }
        }

        public async Task<bool> DeleteStudentExam(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var studentExamToDelete = await context.StudentExams.FindAsync(id);
                if (studentExamToDelete != null)
                {
                    context.StudentExams.Remove(studentExamToDelete);
                    return await context.SaveChangesAsync() > 0;
                }
                return false;
            }
        }
    }
}
