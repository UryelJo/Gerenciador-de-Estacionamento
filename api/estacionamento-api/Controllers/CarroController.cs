using estacionamento_api.Models.DTOs;
using estacionamento_api.Services.Carro;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento_api.Controllers;

[ApiController]
[Route("carros")]
public class CarroController : ControllerBase
{
    private ICarroService _carroService;

    public CarroController(ICarroService carroService)
    {
        this._carroService = carroService;
    }
    
    [HttpGet("/listar-carros")]
    public IActionResult ListarTodosOsCarros()
    {
        return Ok(this._carroService.ListarTodosOsCarros());
    }
}