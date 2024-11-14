using estacionamento_api.Models.ORMs;
using Microsoft.EntityFrameworkCore;

namespace estacionamento_api.Contexts;

public class AuthContext : DbContext
{
    private DbSet<Usuario> Usuarios { get; set; }
    private DbSet<Role> Roles { get; set; }
    
    public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Usuarios)
            .UsingEntity(
                "usuario_roles",
                j => j.HasOne(typeof(Role)).WithMany().HasForeignKey("id_role").OnDelete(DeleteBehavior.Cascade),
                j => j.HasOne(typeof(Usuario)).WithMany().HasForeignKey("id_usuario").OnDelete(DeleteBehavior.Cascade)
            );
    }

    public Usuario BuscarUsuario(String nick)
    {
        return this.Usuarios.FirstOrDefault(usuario => usuario.Nick == nick);
    }
}
