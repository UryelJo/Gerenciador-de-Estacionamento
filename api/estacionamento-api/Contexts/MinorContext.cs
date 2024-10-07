using Microsoft.EntityFrameworkCore;
using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.Contexts;

public class MinorContext : DbContext
{
     public MinorContext(DbContextOptions<MinorContext> options) : base(options) { }
     
     public DbSet<TipoCarroORM> Tipos { get; set; }
     
     public DbSet<MarcaORM> Marcas { get; set; }
}