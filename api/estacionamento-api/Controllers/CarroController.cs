using Microsoft.AspNetCore.Mvc;
using Projeto_Estacionamento.Contexts;
using Projeto_Estacionamento.DTOs;
using Projeto_Estacionamento.ORMModel;
using Projeto_Estacionamento.Services;
using Projeto_Estacionamento.Services.Carro;

namespace Projeto_Estacionamento.Controllers;

[Route("api/carros")]
[ApiController]
public class CarroController : Controller
{
    private readonly ICarroService _carService;
    
    public CarroController(ICarroService carService)
    {
        this._carService = carService;
    }
    
    [HttpGet("/listar-todos-os-carros")]
    public async Task<List<CarroDTO>> ListarTodosOsCarros()
    {
        return (await this._carService.ListarTodosOsCarros());
    }
    
}