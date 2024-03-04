using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Accesorios
{
    [Key]
    public int AccesorioId { get; set; }
    [Required(ErrorMessage = "Descripción es obligatorio")]
    public string? Descripción { get; set; }
}
