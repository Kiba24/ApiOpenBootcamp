using Microsoft.EntityFrameworkCore;
using OpenBootcampAPI.Models.DataModels;

namespace OpenBootcampAPI.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //TODO: ADD DBSETS (Tables)
        public DbSet<User> Users { get; set; }
        public DbSet<Curso> Curso { get; set; } 
    }
}
