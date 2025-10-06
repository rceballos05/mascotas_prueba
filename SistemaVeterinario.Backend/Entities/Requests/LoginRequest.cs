using System.ComponentModel.DataAnnotations;

namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class LoginRequest
    {
        [Required]
        [MaxLength(10)]
        public string rut { get; set; } = null!;
        [Required]
        [MaxLength(12, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string password { get; set; } = null!;
    }
}
