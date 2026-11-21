// RESPONSABLE: Integrante 2 - Jesús Peña
// TODO: agregar validaciones ([Required], [EmailAddress], [MinLength(6)] en Password).
// NO incluir Role ni UserId: los asigna el backend.
// RESPONSABLE: Integrante 2 - Jesús Peña

namespace DeportHub.DTOs;
using System.ComponentModel.DataAnnotations;


public class RegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;

    [Required]
    public string DisplayName { get; set; } = string.Empty;

    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public string Country { get; set; } = string.Empty;

    [Required]
    public string Bio { get; set; } = string.Empty;
}

