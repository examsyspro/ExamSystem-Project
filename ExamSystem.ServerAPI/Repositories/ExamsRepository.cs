using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class ExamsRepository : IExamsRepository
    {
        private readonly AppDbContext _context;

        public ExamsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Exam>> GetAllExams()
        {
            List<Exam> exams = await _context.Exams
                .Include(e => e.questions)
                    .ThenInclude(q => q.Options)
                .ToListAsync();

            return exams;
        }

        public async Task<Exam> GetExamById(int id)
        {


            var exam = await _context.Exams
           .Include(e => e.questions)
           .ThenInclude(q => q.Options)
           .FirstOrDefaultAsync(e => e.ExamId == id);

            return exam;
        }

        public async Task<bool> CreateExam(Exam exam)
        {
            try
            {
                _context.Exams.Add(exam);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }

        public async Task<bool> UpdateExam(Exam updatedExam)
        {
            try
            {
                _context.Exams.Update(updatedExam);
                return await _context.SaveChangesAsync() > 0;

            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public async Task<List<Exam>> GetExamsByCourseType(Course_Enum courseType)
        {
            var exam = await _context.Exams
                .Include(e => e.questions)
                    .ThenInclude(q => q.Options)
                .Where(e => e.CourseType == courseType)
                .ToListAsync();

            return exam;
        }

        public async Task<bool> DeleteExam(int id)
        {
            var examToDelete = await _context.Exams
                .Include(e => e.questions)
                .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(e => e.ExamId == id);

            if (examToDelete != null)
            {
                // Manually remove options associated with questions
                foreach (var question in examToDelete.questions)
                {
                    _context.OptionAns.RemoveRange(question.Options);
                }

                // Manually remove questions associated with the exam
                _context.Questions.RemoveRange(examToDelete.questions);

                // Remove the exam itself
                _context.Exams.Remove(examToDelete);

                // Save changes to the database
                return await _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
