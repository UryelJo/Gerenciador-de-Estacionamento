using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_api.Models.ORMs;

[Table("tipocaro", Schema = "public")]
public class TipoCarroORM
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("descricao")]
    public String Descricao { get; set; }
}