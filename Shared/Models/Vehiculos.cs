
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Vehiculos
{
    [Key]
    public int VehiculoId { get; set; }
    [Required(ErrorMessage ="Fecha es obligatorio")]
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage ="Descripción es obligatorio")]
    public string? Descripción { get; set; }
    [Required(ErrorMessage ="Costo es requerido")]
    [Range(0.01, 1000000000,ErrorMessage = "El costo debe estar 0.01 y 1000000000")]
    public double Costo { get; set; }
    public double Gastos { get; set; }

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalle> VehiculosDetalle { get; set; } = new List<VehiculosDetalle>();
}
