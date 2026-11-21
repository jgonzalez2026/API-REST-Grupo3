
using DeportHub.DTOs;
using DeportHub.Models;

namespace DeportHub.Services;

public interface IMiembroService
{
    Task<Miembro?> ObtenerPorIdAsync(string id);

    
    Task<List<Miembro>> BuscarAsync(BuscarMiembroDto dto);
}

