// RESPONSABLE: Integrante 3 (interfaz completa; el Integrante 4 implementa LoginAsync)
using DeportHub.DTOs;

namespace DeportHub.Services;

public interface IAuthService
{
    Task<AuthResponseDto> RegisterAsync(RegisterDto dto);
    Task<AuthResponseDto> LoginAsync(LoginDto dto);
}
