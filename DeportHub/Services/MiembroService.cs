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
 public async Task<Miembro?> ObtenerPorIdAsync(string id)
    {
        var documento = await _db
            .Collection(ColeccionMiembros)
            .Document(id)
            .GetSnapshotAsync();

   if (!documento.Exists)
        {
            return null;
        }
return documento.ConvertTo<Miembro>();
    }

    public async Task<List<Miembro>> BuscarAsync(
        BuscarMiembroDto dto)
    {
        Query consulta = _db.Collection(ColeccionMiembros);

        // Filtrar por país si viene informado
        if (!string.IsNullOrWhiteSpace(dto.Country))
        {
            consulta = consulta.WhereEqualTo(
                "Country",
                dto.Country
            );
        }

     if (!string.IsNullOrWhiteSpace(dto.Username))
        {
            consulta = consulta.WhereEqualTo(
                "Username",
                dto.Username
            );
        }

  var resultado = await consulta.GetSnapshotAsync();
List<Miembro> miembros = resultado.Documents
            .Select(documento => documento.ConvertTo<Miembro>())
            .ToList();

        return miembros;
    }
}
