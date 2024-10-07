using Microsoft.EntityFrameworkCore;
using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.Contexts;

public class PessoaContext : DbContext
{
    public PessoaContext(DbContextOptions<PessoaContext> options) : base(options) {}
    
    DbSet<PessoaORM> Pessoas { get; set; }
    DbSet<GuardaORM> Guardas { get; set; }
    DbSet<MotoristaORM> Motoristas { get; set; }

    public async Task<List<PessoaORM>> ListarPessoas()
    {
        return await this.Pessoas.ToListAsync();
    }

    public async Task<List<GuardaORM>> ListarGuardas()
    {
        return await this.Guardas
            .Include(guarda => guarda.Pessoa)
            .ToListAsync();
    }
    
    public async Task<List<MotoristaORM>> ListarMotoristas()
    {
        return await this.Motoristas
            .Include(motorista => motorista.Carros)
            .Include(motorista => motorista.PessoaOrm)
            .ToListAsync();
    }
}