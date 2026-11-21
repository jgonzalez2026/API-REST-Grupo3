// RESPONSABLE: Integrante 2
// TODO: agregar validaciones ([Required], [EmailAddress]).
namespace DeportHub.DTOs;

public class LoginDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
