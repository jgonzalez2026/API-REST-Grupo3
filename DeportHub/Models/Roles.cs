// RESPONSABLE: Integrante 2
namespace DeportHub.Models;

/// <summary>Roles permitidos. Solo "Entrenador" o "Miembro".</summary>
public static class Roles
{
    public const string Entrenador = "Entrenador";
    public const string Miembro = "Miembro";

    public static bool EsValido(string? role) =>
        role == Entrenador || role == Miembro;
}
