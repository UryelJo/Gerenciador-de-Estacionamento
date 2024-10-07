using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;
using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.Contexts;

public class CarroContext : DbContext
{
    public CarroContext(DbContextOptions<CarroContext> options) : base(options) { }
    
    private DbSet<CarroORM> Carros { get; set; }
    private DbSet<TipoCarroORM> Tipos { get; set; }
    private DbSet<MarcaORM> Marcas { get; set; }

    public async Task<List<CarroORM>> ListarTodosOsCarros()
    {
        return await this.Carros
            .Include(c => c.Marca)
            .Include(c => c.TipoCarro)
            .ToListAsync();
    }

    public async Task<CarroORM?> BuscarCarroPorPlaca(string placa)
    {
        return await this.Carros
            .Include(c => c.Marca)
            .Include(c => c.TipoCarro)
            .FirstOrDefaultAsync(carro => carro.Placa == placa);
    }
}