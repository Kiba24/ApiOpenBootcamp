
using System.ComponentModel.DataAnnotations;

namespace OpenBootcampAPI.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime DoB { get; set; }

        //Cursos a los que este matriculado (relacion varios a varios
        //un alumno puede estar en varios cursos y un curso tiene varios alumnos)
        public List<Course> Courses { get; set; }  = new List<Course>();

    }
}
