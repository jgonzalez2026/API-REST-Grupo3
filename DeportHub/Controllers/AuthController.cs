//Julio Gonzalez - 62511637
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
        try
        {
            return Ok(await _authService.RegisterAsync(dto));
        }
        catch (AuthException ex)
        {
            return StatusCode(ex.StatusCode, new { message = ex.Message });
        }
    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponseDto>> Login([FromBody] LoginDto dto)
    {
        try
        {
            return Ok(await _authService.LoginAsync(dto));
        }
        catch (AuthException ex)
        {
            return StatusCode(ex.StatusCode, new { message = ex.Message });
        }
    }
}