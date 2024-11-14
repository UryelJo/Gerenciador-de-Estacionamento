using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_api.Models.ORMs;

[Table("usuario", Schema = "public")]
public class Usuario
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("nick")]
    public String Nick { get; set; }
    
    [Column("senha")]
    public String Senha { get; set; }
    
    [Column("cod_estacionamento")]
    public String CodigoEstacionamento { get; set; }
    
    public virtual ICollection<Role> Roles { get; set; }
}