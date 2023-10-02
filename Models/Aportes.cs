using System.ComponentModel.DataAnnotations;
namespace Abraham_API1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Fecha")]

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Es obligatorio introducir la Persona")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El nombre solo debe contener letras y espacios.")]
        public string? Persona { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Observación")]
        public string? Observacion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Monto")]
        [Range(1, 7922816251426433759, ErrorMessage = "El monto debe ser mayor que cero")]
        public decimal Monto { get; set; }

    }
}
