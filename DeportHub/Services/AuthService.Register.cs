// RESPONSABLE: Integrante 3
// TODO: 1) POST https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={ApiKey}
//          body: { email, password, returnSecureToken: true }
//       2) Crear Miembro (Id = localId, Role = Roles.Miembro, CreatedAt = DateTime.UtcNow,
//          BirthDate en UTC) y guardarlo en Firestore: coleccion "miembros", documento = localId
//       3) Retornar AuthResponseDto (idToken, localId, email)
//       4) Errores (EMAIL_EXISTS, WEAK_PASSWORD) -> throw new AuthException("mensaje", 400)
using DeportHub.DTOs;

namespace DeportHub.Services;

public partial class AuthService
{
    public Task<AuthResponseDto> RegisterAsync(RegisterDto dto)
    {
        throw new NotImplementedException("Pendiente: Integrante 3");
    }
}
