using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenBootcampAPI.DataAccess;
using OpenBootcampAPI.Models.DataModels;

namespace OpenBootcampAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return BadRequest("User not found");
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> PutUser(User user)
        {
            var newuser = await _context.Users.FindAsync(user.Id);
            if (newuser == null)
                return BadRequest("User not found");

            newuser.Name = user.Name;
            newuser.Email = user.Email;
            newuser.LastName = user.LastName;

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
                
        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var toDelete = await _context.Users.FindAsync(id);
            if (toDelete == null)
                return BadRequest("User not found");

            _context.Users.Remove(toDelete);
            await _context.SaveChangesAsync();
            return Ok(await _context.Users.ToListAsync());
        }
    }
}
