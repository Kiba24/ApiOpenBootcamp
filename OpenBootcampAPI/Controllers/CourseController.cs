using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenBootcampAPI.DataAccess;
using OpenBootcampAPI.Models.DataModels;

namespace OpenBootcampAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetAll()
        {
            return Ok(await _context.Courses.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetById(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                return BadRequest("Course not found");
            return Ok(course);
        }

        [HttpPut]
        public async Task<ActionResult<Course>> Put(Course course)
        {
            var NewCourse = await _context.Courses.FindAsync(course.Id);
            if (NewCourse == null)
                return BadRequest("Course not found");

            NewCourse.ShortDesc = course.ShortDesc;
            NewCourse.Clevel = course.Clevel;
            NewCourse.Name = course.Name;
            NewCourse.Objectives = course.Objectives;

            await _context.SaveChangesAsync();
            return Ok(NewCourse);
        }

        [HttpPost]
        public async Task<ActionResult<List<Course>>> Post(Course course)
        {
             await _context.AddAsync(course);
            await _context.SaveChangesAsync();
            return Ok(await _context.Courses.ToListAsync());

        }

        [HttpDelete]
        public async Task<ActionResult<List<Course>>> DeleteCourse(int id)
        {
            var ToDelete = await _context.Courses.FindAsync(id);
            if (ToDelete == null)
                return BadRequest("Course not found");
             _context.Courses.Remove(ToDelete);

            await _context.SaveChangesAsync();

            return Ok(await _context.Courses.ToListAsync());
        }
    }
}
