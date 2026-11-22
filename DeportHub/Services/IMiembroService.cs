// RESPONSABLE: Integrante 5
using DeportHub.DTOs;
using DeportHub.Models;

namespace DeportHub.Services;

public interface IMiembroService
{
    /// <summary>Devuelve el miembro o null si no existe.</summary>
    Task<Miembro?> ObtenerPorIdAsync(string id);

    /// <summary>Filtra por Country y/o Username (los que vengan con valor).</summary>
    Task<List<Miembro>> BuscarAsync(BuscarMiembroDto dto);
}
