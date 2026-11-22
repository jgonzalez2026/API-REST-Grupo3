// RESPONSABLE: Integrante 2 - Jesús Peña
// Respuesta de register y login: idToken, localId y email.
namespace DeportHub.DTOs;

public class AuthResponseDto
{
    public string IdToken { get; set; } = string.Empty;
    public string LocalId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
