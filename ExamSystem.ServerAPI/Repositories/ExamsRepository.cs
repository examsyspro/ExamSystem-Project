using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace ExamSystem.ServerAPI.Repositories
{
    public class ExamsRepository : IExamsRepository
    {
        public async Task<List<Exam>> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();
            await using (AppDbContext Db = new AppDbContext())
            {
                exams = await Db.Exams.ToListAsync();
            }
            return exams;
        }

        public async Task<Exam> GetExamById(int id)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                return await Db.Exams.FindAsync(id);
            }
        }

        public async Task<bool> CreateExam(Exam exam)
        {
            await using (AppDbContext Db = new AppDbContext())
            {
                Db.Exams.Add(exam);
                return await Db.SaveChangesAsync() > 0;
            }
        }

        public async Task<Exam> UpdateExam(int id, Exam updatedExam)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var existingExam = await Db.Exams.FindAsync(id);
                if (existingExam != null)
                {
                    // Update properties of existingExam with values from updatedExam
                    // ...

                    await Db.SaveChangesAsync();
                }
                return existingExam;
            }
        }

        public async Task<bool> DeleteExam(int id)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var examToDelete = await Db.Exams.FindAsync(id);
                if (examToDelete != null)
                {
                    Db.Exams.Remove(examToDelete);
                    return await Db.SaveChangesAsync() > 0;
                }
                return false;
            }
        }
    }
}
