using System.ComponentModel.DataAnnotations;

namespace taanbus.Data.Models
{
    public class SugerenciaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La descripción es un campo requerido")]
        public string? Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Status { get; set; } = 0;
        public int? UserId { get; set; }
        public string? Ciudadano { get; set; }
    }
}