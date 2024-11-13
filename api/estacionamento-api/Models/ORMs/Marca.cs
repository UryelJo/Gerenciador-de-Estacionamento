using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_api.Models.ORMs;

[Table("marca", Schema = "public")]
public class MarcaORM
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("descricao")]
    public String Descricao { get; set; }
    
    [Column("nome")]
    public String Nome { get; set; }
}