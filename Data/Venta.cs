using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControldeVentasIdentity.Data
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Número de Ventas del Día")]
        public int NumVentas { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el Monto de Venta del Día")]
        public decimal MontoVentaDia { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la fecha de las Ventas Capturadas")]
        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }
    }
}
