using Shared.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_Ap1_DelfryPaulino.API.ViewModels;

public class VehiculosRequest
{
    [Required(ErrorMessage = "Fecha es obligatorio")]
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage = "Descripción es obligatorio")]
    public string? Descripción { get; set; }
    [Required(ErrorMessage = "Costo es requerido")]
    [Range(0.01, 1000000000, ErrorMessage = "El costo debe estar 0.01 y 1000000000")]
    public double Costo { get; set; }
    public double Gastos { get; set; }

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalle> VehiculosDetalle { get; set; } = new List<VehiculosDetalle>();
}
