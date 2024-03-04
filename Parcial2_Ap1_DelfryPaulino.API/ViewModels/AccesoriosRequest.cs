using System.ComponentModel.DataAnnotations;

namespace Parcial2_Ap1_DelfryPaulino.API.ViewModels;

public class AccesoriosRequest
{
    [Required(ErrorMessage = "Descripción es obligatorio")]
    public string? Descripción { get; set; }
}
