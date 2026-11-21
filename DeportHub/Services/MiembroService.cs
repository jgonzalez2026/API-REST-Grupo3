// RESPONSABLE: Integrante 5
// TODO: ObtenerPorIdAsync -> leer documento "miembros/{id}" (null si no existe)
//       BuscarAsync -> Query sobre "miembros" con WhereEqualTo("Country", ...) y/o ("Username", ...)
//       El UserId del token NO se usa para filtrar.
using DeportHub.DTOs;
using DeportHub.Models;
using Google.Cloud.Firestore;

namespace DeportHub.Services;

public class MiembroService : IMiembroService
{
    private const string ColeccionMiembros = "miembros";

    private readonly FirestoreDb _db;

    public MiembroService(FirestoreDb db)
    {
        _db = db;
    }

    public Task<Miembro?> ObtenerPorIdAsync(string id)
    {
        throw new NotImplementedException("Pendiente: Integrante 5");
    }

    public Task<List<Miembro>> BuscarAsync(BuscarMiembroDto dto)
    {
        throw new NotImplementedException("Pendiente: Integrante 5");
    }
}
