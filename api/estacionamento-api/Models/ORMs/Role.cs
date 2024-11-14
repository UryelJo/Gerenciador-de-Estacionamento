using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_api.Models.ORMs;

[Table("role", Schema = "public")]
public class Role
{  
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("descricao")]
    public string Descricao { get; set; }
    
    public virtual ICollection<Usuario> Usuarios { get; set; }
}