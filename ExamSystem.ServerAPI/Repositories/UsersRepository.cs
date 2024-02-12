using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.ServerAPI.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context)
        {
            _context = context;
        }

        #region Users Manager

        public async Task<bool> UserRegister(User user)
        {
            user.PassWord = MD5Convertor.GetMd5Hash(user.PassWord);
            _context.Users.Add(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<User> GetUserByUserId(string userId)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                return new User();
            }

            return user;
        }

        public async Task<User> ValidateUser(string password, string userId)
        {
            string convertedPass = MD5Convertor.GetMd5Hash(password);
            return await _context.Users.FirstOrDefaultAsync(x => x.UserId == userId && x.PassWord == convertedPass);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        #endregion
    }
}
