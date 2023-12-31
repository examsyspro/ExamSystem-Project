
using ExamSystem.ServerAPI.DbModels;
using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Services;
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
        public UsersRepository()
        {

        }




        #region Users Managger

        /// <summary>
        /// Add new usr to DB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> UserRegister(User user)
        {
            await using (UsersDbContext Db = new UsersDbContext())
            {
              user.PassWord = MD5Convertor.GetMd5Hash(user.PassWord);
                Db._Users.Add(user);
                return Db.SaveChanges() > 0;
            }
        }


        /// <summary>
        /// chack if the user exsit in db
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<bool> Check_ExistingUser(string userid)
        {

            await using (UsersDbContext Db = new UsersDbContext())
            {
                User? user = Db._Users.FirstOrDefault(x => x.UserId == userid);
                if (user != null)
                {
                    return true;
                }
            }
            return false;

        }

        public async Task<User> ValidateUser(string password, string userid)
        {

            User? user = null;
            await using (UsersDbContext Db = new UsersDbContext())
            {
                string convertedPass = MD5Convertor.GetMd5Hash(password);
                user = Db._Users.FirstOrDefault(x => x.UserId == userid && x.PassWord == convertedPass);

                return user;

            }


        }

        /// <summary>
        /// get all users from db to list
        /// </summary>
        /// <returns></returns>
        public async Task <List<User>> GetAllUsers()
        {
            List<User> users = new List<User>();
            await using (UsersDbContext Db = new UsersDbContext())
            {
                users = Db._Users.ToList();
            }
            return users;
        }

        #endregion



        //  public bool UserUpdate(User user) { }

        //   public bool UserDelete(User user) { return false; }






    }
}
