using System.ComponentModel.DataAnnotations;

namespace OpenBootcampAPI.Models.DataModels
{
    public enum Level
    {
        Basic = 1,
        Intermediate = 2,
        Advanced = 3
    };


    public class Course : BaseEntity
    {


        [Required, StringLength(120)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDesc { get; set; } = string.Empty;
        [Required]
        public Level Clevel { get; set; } = Level.Basic;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public string PublicScope { get; set; } = string.Empty;
        [Required]
        public string Objectives { get; set; } = string.Empty;

        //Relaciones

        [Required]
        public List<Student> Students { get; set; } = new List<Student>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
    }
}
