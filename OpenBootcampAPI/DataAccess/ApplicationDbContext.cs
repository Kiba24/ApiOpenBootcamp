using Microsoft.EntityFrameworkCore;
using OpenBootcampAPI.Models.DataModels;

namespace OpenBootcampAPI.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        //Un dbcontext representa una sesion con la base de datos
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //TODO: ADD DBSETS (Tables)
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Student> Students { get; set; }
        public DbSet<Chapter> Chapters { get; set; }

    }
}
