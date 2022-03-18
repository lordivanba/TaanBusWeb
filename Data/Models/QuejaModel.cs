using System.ComponentModel.DataAnnotations;

namespace taanbus.Data.Models
{
    public class QuejaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El motivo es un campo requerido")]
        public string? MotivoQueja { get; set; }
        public DateTime FechaHechos { get; set; }
        [Required(ErrorMessage = "La descripción es un campo requerido")]
        public string? Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Status { get; set; } = 0;
        public int? UserId { get; set; }
        public string? Ciudadano { get; set; }
    }
}