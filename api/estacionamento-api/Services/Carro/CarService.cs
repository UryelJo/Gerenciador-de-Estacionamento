using System.Net;
using Projeto_Estacionamento.Contexts;
using Projeto_Estacionamento.DTOs;

namespace Projeto_Estacionamento.Services.Carro;

public class CarroService : ICarroService
{
    private readonly CarroContext _context;

    public CarroService(CarroContext _context)
    {
        this._context = _context;
    }
    
    public async Task<List<CarroDTO>> ListarTodosOsCarros()
    {
        var listaDeCarrosORM = await this._context.ListarTodosOsCarros();
        if (listaDeCarrosORM == null) throw new BadHttpRequestException("Não foram encontrados registros de carros!", 204);
        return CarroDTO.ConverterListaEmCarroDto(listaDeCarrosORM);
    }
}