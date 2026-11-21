// RESPONSABLE: Integrante 2 - Jesús Peña
// Ambos campos son opcionales: se filtra por country y/o username.
namespace DeportHub.DTOs;

public class BuscarMiembroDto
{
    public string? Country { get; set; }
    public string? Username { get; set; }
}
