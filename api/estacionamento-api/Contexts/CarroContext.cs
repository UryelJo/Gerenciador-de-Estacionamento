using estacionamento_api.Models.ORMs;
using Microsoft.EntityFrameworkCore;

namespace estacionamento_api.Contexts;

public class CarroContext : DbContext
{
    public CarroContext (DbContextOptions<CarroContext> options) : base(options) {}
    
    private DbSet<CarroORM> Carros { get; set; }

    public DbSet<CarroORM> ListarTodosOsCarros()
    {
        return this.Carros;
    }

    public CarroORM BuscarCarroPorPlaca(String placa)
    {
        return this.Carros.First(carro => carro.Placa == placa);
    }
}