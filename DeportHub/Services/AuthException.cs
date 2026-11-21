// RESPONSABLE: Integrante 1 (contrato compartido: no lo modifiquen sin avisar al grupo)
// Los services lanzan esta excepcion y el controller la convierte en respuesta HTTP.
namespace DeportHub.Services;

public class AuthException : Exception
{
    public int StatusCode { get; }

    public AuthException(string message, int statusCode = StatusCodes.Status400BadRequest)
        : base(message)
    {
        StatusCode = statusCode;
    }
}
