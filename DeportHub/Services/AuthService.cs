// RESPONSABLE: Integrante 3 (constructor y campos compartidos)
// La clase es "partial" para que el Integrante 3 (Register) y el Integrante 4 (Login)
// trabajen en archivos distintos y no tengan conflictos al fusionar.
using DeportHub.DTOs;
using Google.Cloud.Firestore;

namespace DeportHub.Services;

public partial class AuthService : IAuthService
{
    private const string ColeccionMiembros = "miembros";

    private readonly IHttpClientFactory _httpClientFactory;
    private readonly FirestoreDb _db;
    private readonly IConfiguration _config;

    public AuthService(IHttpClientFactory httpClientFactory, FirestoreDb db, IConfiguration config)
    {
        _httpClientFactory = httpClientFactory;
        _db = db;
        _config = config;
    }

    // Helper compartido: API Key de Firebase (appsettings: Firebase:ApiKey)
    private string ApiKey =>
        _config["Firebase:ApiKey"] ?? throw new InvalidOperationException("Falta Firebase:ApiKey.");
}
