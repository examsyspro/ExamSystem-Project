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
            List<Exam> exams = await _context.Exams.ToListAsync();

            foreach (var exam in exams)
            {
                await _context.Entry(exam)
                    .Collection(e => e.questions) // Include the related Questions
                    .Query()
                    .Include(q => q.Options) // Include the related OptionAns entities for each Question
                    .LoadAsync();
            }

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

        public async Task<bool> UpdateExam( Exam updatedExam)
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




        public async Task<bool> DeleteExam(int id)
        {
            var examToDelete = await _context.Exams.FindAsync(id);
            if (examToDelete != null)
            {
                _context.Exams.Remove(examToDelete);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
