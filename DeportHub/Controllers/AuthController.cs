// RESPONSABLE: Integrante 4
// Sin [Authorize]. Sin logica de negocio: solo llama al service.
// TODO: capturar AuthException y devolver StatusCode(ex.StatusCode, new { message = ex.Message })
using DeportHub.DTOs;
using DeportHub.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeportHub.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<AuthResponseDto>> Register([FromBody] RegisterDto dto)
    {
        var result = await _authService.RegisterAsync(dto);
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponseDto>> Login([FromBody] LoginDto dto)
    {
        var result = await _authService.LoginAsync(dto);
        return Ok(result);
    }
}
