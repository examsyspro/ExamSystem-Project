using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class ErrorRepository : IErrorRepository
    {
        private readonly AppDbContext _context;

        public ErrorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Error>> GetAllErrors()
        {
            List<Error> errors = await _context.Errors.ToListAsync();
            return errors;
        }

        public async Task<Error> GetErrorById(int id)
        {
            var error = await _context.Errors
                .FirstOrDefaultAsync(e => e.ErrorId == id);

            return error;
        }

        public async Task<bool> CreateError(Error error)
        {
            try
            {
                _context.Errors.Add(error);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }

        public async Task<bool> UpdateError(Error updatedError)
        {
            try
            {
                _context.Errors.Update(updatedError);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return false;
            }
        }

        public async Task<bool> DeleteError(int id)
        {
            var errorToDelete = await _context.Errors.FindAsync(id);
            if (errorToDelete != null)
            {
                _context.Errors.Remove(errorToDelete);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
