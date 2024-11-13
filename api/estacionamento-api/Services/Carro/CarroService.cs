using estacionamento_api.Contexts;
using estacionamento_api.Models.DTOs;
using estacionamento_api.Models.ORMs;
using estacionamento_api.Utils.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace estacionamento_api.Services.Carro;

public class CarroService : ICarroService
{
    private CarroContext _context;
    
    public CarroService(CarroContext context)
    {
        this._context = context;
    }
    
    public List<CarroDTO> ListarTodosOsCarros()
    {
        DbSet<CarroORM> ListaDeCarrosORM = this._context.ListarTodosOsCarros();
        
        if (!ListaDeCarrosORM.Any()) throw new 
            NoContentException("Não existem carros cadastrados.");
        
        return ListaDeCarrosORM
            .Select(carroORM => new CarroDTO(carroORM))
            .ToList();
    }
}