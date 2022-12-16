using System.ComponentModel.DataAnnotations;

namespace OpenBootcampAPI.Models.DataModels
{
    public class BaseEntity
    {
        //Clase base para establecer requisitos para todas las tablas
        [Required]
        [Key]
        public int Id { get; set; }
        
        public string CreatedBy { get; set; } = string.Empty;
        public string DeletedBy { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime DeleteddAt { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

    }
}
