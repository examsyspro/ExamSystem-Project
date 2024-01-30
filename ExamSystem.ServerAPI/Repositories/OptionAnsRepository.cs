using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.Repositories
{
    public class OptionAnsRepository : IOptionAnsRepository
    {
        private readonly AppDbContext _context;

        public OptionAnsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<OptionAns>> GetAllOptionAns()
        {
            return await _context.OptionAns.ToListAsync();
        }

        public async Task<OptionAns> GetOptionAnsById(int id)
        {
            return await _context.OptionAns.FindAsync(id);
        }

        public async Task<bool> CreateOptionAns(OptionAns optionAns)
        {
            _context.OptionAns.Add(optionAns);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<OptionAns> UpdateOptionAns(int id, OptionAns updatedOptionAns)
        {
            var existingOptionAns = await _context.OptionAns.FindAsync(id);
            if (existingOptionAns != null)
            {
                // Update properties of existingOptionAns with values from updatedOptionAns
                // ...

                await _context.SaveChangesAsync();
            }
            return existingOptionAns;
        }

        public async Task<bool> DeleteOptionAns(int id)
        {
            var optionAnsToDelete = await _context.OptionAns.FindAsync(id);
            if (optionAnsToDelete != null)
            {
                _context.OptionAns.Remove(optionAnsToDelete);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
