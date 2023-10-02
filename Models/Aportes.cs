using System.ComponentModel.DataAnnotations;
namespace Abraham_API1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la persona")]
        public string Persona { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Observación")]
        public string Observacion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Monto")]
        [Range(1, double.MaxValue, ErrorMessage = "El monto debe ser mayor que cero")]
        public double Monto { get; set; }

    }
}
