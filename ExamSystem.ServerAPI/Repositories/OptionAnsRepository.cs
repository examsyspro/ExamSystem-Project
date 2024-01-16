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
        public async Task<List<OptionAns>> GetAllOptionAns()
        {
            List<OptionAns> optionAnsList = new List<OptionAns>();
            await using (AppDbContext Db = new AppDbContext())
            {
                optionAnsList = await Db.OptionAns.ToListAsync();
            }
            return optionAnsList;
        }

        public async Task<OptionAns> GetOptionAnsById(int id)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                return await Db.OptionAns.FindAsync(id);
            }
        }

        public async Task<bool> CreateOptionAns(OptionAns optionAns)
        {
            await using (AppDbContext Db = new AppDbContext())
            {
                Db.OptionAns.Add(optionAns);
                return await Db.SaveChangesAsync() > 0;
            }
        }

        public async Task<OptionAns> UpdateOptionAns(int id, OptionAns updatedOptionAns)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var existingOptionAns = await Db.OptionAns.FindAsync(id);
                if (existingOptionAns != null)
                {
                    // Update properties of existingOptionAns with values from updatedOptionAns
                    // ...

                    await Db.SaveChangesAsync();
                }
                return existingOptionAns;
            }
        }

        public async Task<bool> DeleteOptionAns(int id)
        {
            using (AppDbContext Db = new AppDbContext())
            {
                var optionAnsToDelete = await Db.OptionAns.FindAsync(id);
                if (optionAnsToDelete != null)
                {
                    Db.OptionAns.Remove(optionAnsToDelete);
                    return await Db.SaveChangesAsync() > 0;
                }
                return false;
            }
        }
    }
}
