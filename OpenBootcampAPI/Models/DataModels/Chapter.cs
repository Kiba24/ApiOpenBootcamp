using System.ComponentModel.DataAnnotations;

namespace OpenBootcampAPI.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        [Required]
        public string Chapters { get; set; } = string.Empty;

        public int CourseId { get; set; }
        public Course Course { get; set; } = new Course();
    }
}
