using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class VehiculosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    [ForeignKey("Vehiculos")]
    public int VehiculoId { get; set; }
    [ForeignKey("Accesorios")]
    public int AccesorioId { get; set; }
    [Required(ErrorMessage = "Valor es requerido")]
    [Range(0.01, 1000000000, ErrorMessage = "El Valor debe estar 0.01 y 1000000000")]
    public double Valor { get; set; }
}
