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

        public async Task<bool> UpdateExam(int id, Exam updatedExam)
        {
            try
            {

               // updatedExam.ExamId = id;
                var existingExam = await _context.Exams
                .Include(e => e.questions)
                .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(e => e.ExamId == id);


                if (existingExam != null)
                {
                    _context.Entry(existingExam).CurrentValues.SetValues(updatedExam);
                    await _context.SaveChangesAsync();
                    return true; // Return true indicating successful update
                }
                else
                {
                    return false; // Return false if the exam with the specified ID is not found
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as appropriate for your application
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false; // Return false in case of an exception
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
