// RESPONSABLE: Integrante 4
// TODO: 1) POST https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={ApiKey}
//          body: { email, password, returnSecureToken: true }
//       2) Retornar AuthResponseDto (idToken, localId, email)
//       3) Credenciales invalidas -> throw new AuthException("mensaje", 401)
using DeportHub.DTOs;

namespace DeportHub.Services;

public partial class AuthService
{
    public Task<AuthResponseDto> LoginAsync(LoginDto dto)
    {
        throw new NotImplementedException("Pendiente: Integrante 4");
    }
}
