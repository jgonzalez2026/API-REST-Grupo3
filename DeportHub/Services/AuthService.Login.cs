//Julio Gonzalez - 62511637
using System.Net.Http.Json;
using System.Text.Json;
using DeportHub.DTOs;

namespace DeportHub.Services;

public partial class AuthService
{
    public async Task<AuthResponseDto> LoginAsync(LoginDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={ApiKey}";

        var response = await client.PostAsJsonAsync(url, new
        {
            email = dto.Email,
            password = dto.Password,
            returnSecureToken = true
        });

        if (!response.IsSuccessStatusCode)
        {
            var errorJson = await response.Content.ReadAsStringAsync();
            throw new AuthException(ObtenerMensajeLogin(errorJson), StatusCodes.Status401Unauthorized);
        }

        var firebase = await response.Content.ReadFromJsonAsync<FirebaseLoginResponse>()
            ?? throw new AuthException("Respuesta inválida de Firebase.", StatusCodes.Status502BadGateway);

        return new AuthResponseDto
        {
            IdToken = firebase.IdToken,
            LocalId = firebase.LocalId,
            Email = firebase.Email
        };
    }

    private static string ObtenerMensajeLogin(string errorJson)
    {
        try
        {
            using var doc = JsonDocument.Parse(errorJson);
            var codigo = doc.RootElement.GetProperty("error").GetProperty("message").GetString();
            return codigo switch
            {
                "USER_DISABLED" => "La cuenta está deshabilitada.",
                "TOO_MANY_ATTEMPTS_TRY_LATER" => "Demasiados intentos, intenta más tarde.",
                _ => "Correo o contraseña incorrectos."
            };
        }
        catch
        {
            return "No se pudo iniciar sesión.";
        }
    }

    private sealed class FirebaseLoginResponse
    {
        public string IdToken { get; set; } = string.Empty;
        public string LocalId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}