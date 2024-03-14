using ExamSystem.ServerAPI.Models;
using ExamSystem.ServerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamSystem.ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ISystemRepository _usersRepo;
        public UsersController(ISystemRepository repo)
        {
            _usersRepo = repo;
        }
        // GET: api/<UsersController>
        [HttpGet("getallusers")]
        public async Task<List<User>> GetAllUsers()
        {
            return await _usersRepo.GetAllUsers();
        }

        // GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpGet("{id}")]
        public async Task<User> GetUser(string id)
        {
            return await _usersRepo.GetUserByUserId(id);
        }

        // POST api/<UsersController>
        [HttpPost("register")]
        public async Task<bool> Post_Register([FromBody] User user)
        {
            return await _usersRepo.UserRegister(user);
        }

        [HttpPost("login")]
        public async Task<User> Post_Login(User user)
        {
            return await _usersRepo.ValidateUser(user.PassWord, user.UserId);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {


        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
