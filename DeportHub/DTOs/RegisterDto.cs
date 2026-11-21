// RESPONSABLE: Integrante 2
// TODO: agregar validaciones ([Required], [EmailAddress], [MinLength(6)] en Password).
// NO incluir Role ni UserId: los asigna el backend.
namespace DeportHub.DTOs;

public class RegisterDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Country { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
}
