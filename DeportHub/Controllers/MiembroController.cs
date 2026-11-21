// RESPONSABLE: Integrante 5
// Todo el controller lleva [Authorize]. El UserId SIEMPRE sale del claim del JWT.
// TODO: GET api/Miembro      -> UserId = User.FindFirst("user_id")?.Value ?? User.FindFirst("sub")?.Value
//       GET api/Miembro/{id} -> 404 si el service devuelve null
//       POST api/Miembro/buscar -> llama a BuscarAsync (el UserId no se usa para filtrar)
using DeportHub.DTOs;
using DeportHub.Models;
using DeportHub.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeportHub.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class MiembroController : ControllerBase
{
    private readonly IMiembroService _miembroService;

    public MiembroController(IMiembroService miembroService)
    {
        _miembroService = miembroService;
    }

    [HttpGet]
    public Task<ActionResult<Miembro>> ObtenerMiPerfil()
    {
        throw new NotImplementedException("Pendiente: Integrante 5");
    }

    [HttpGet("{id}")]
    public Task<ActionResult<Miembro>> ObtenerPorId(string id)
    {
        throw new NotImplementedException("Pendiente: Integrante 5");
    }

    [HttpPost("buscar")]
    public Task<ActionResult<List<Miembro>>> Buscar([FromBody] BuscarMiembroDto dto)
    {
        throw new NotImplementedException("Pendiente: Integrante 5");
    }
}
