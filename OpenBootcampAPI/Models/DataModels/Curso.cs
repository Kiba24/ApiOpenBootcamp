using System.ComponentModel.DataAnnotations;

namespace OpenBootcampAPI.Models.DataModels
{
    public class Curso : BaseEntity
    {
        public enum Nivel
        {
            Basico = 1,
            Intermedio = 2,
            Avanzado = 3
        };

        [Required, StringLength(120)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required]
        public Nivel ValorNivel { get; set; }
        [Required]
        public string Requisitos { get; set; } = string.Empty;
        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;
        [Required]
        public string Objetivos { get; set; } = string.Empty;


    }
}
