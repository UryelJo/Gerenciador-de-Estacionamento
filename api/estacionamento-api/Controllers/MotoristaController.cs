using Microsoft.AspNetCore.Mvc;
using Projeto_Estacionamento.DTOs;
using Projeto_Estacionamento.Services.Motorista;

namespace Projeto_Estacionamento.Controllers;

[Route("api/motoristas")]
[ApiController]
public class MotoristaController : Controller
{
    private readonly IMotoristaService _motoristaService;

    public MotoristaController(IMotoristaService motoristaService)
    {
        this._motoristaService = motoristaService;
    }

    public async Task<List<MotoristaDTO>> ListarTodosOsMotoristas()
    {
        return await this._motoristaService.ListarTodosOsMotoristas();
    }
    
}