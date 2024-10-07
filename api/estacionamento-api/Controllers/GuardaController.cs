using Microsoft.AspNetCore.Mvc;
using Projeto_Estacionamento.DTOs;
using Projeto_Estacionamento.Services.Guarda;

namespace Projeto_Estacionamento.Controllers;

[Route("api/guardas")]
[ApiController]
public class GuardaController : Controller
{
    private readonly IGuardaService _guardaService;

    public GuardaController(IGuardaService guardaService)
    {
        this._guardaService = guardaService;
    }

    [HttpGet("/listar-todos-os-guardas")]
    public async Task<List<GuardaDTO>> ListarTodosOsGuardas()
    {
        return await this._guardaService.ListarTodosOsGuardas();
    }
}