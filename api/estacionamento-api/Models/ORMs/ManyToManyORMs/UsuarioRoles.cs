using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_api.Models.ORMs.ManyToManyORMs;

[Table("usuario_roles", Schema = "public")]
public class UsuarioRoles
{
    [Column("id_usuario")]
    public int IdUsuario { get; set; }
    
    [Column("id_role")]
    public int IdRole { get; set; }
    
    public Usuario Usuario { get; set; } = null!;
    public Role Role { get; set; } = null!;
}