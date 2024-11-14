using estacionamento_api.Models.DTOs;
using estacionamento_api.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento_api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    private IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        this._authService = authService;
    }

    [HttpGet("/buscar-por-nick/{nick}")]
    public IActionResult ObterUsuario(string nick)
    {
        return Ok(this._authService.buscarUmUsuario(nick));
    }
}