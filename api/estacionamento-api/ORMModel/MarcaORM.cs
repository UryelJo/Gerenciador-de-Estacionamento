using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estacionamento.ORMModel;

[Table("marca", Schema = "public")]
public class MarcaORM 
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("nome")]
    public string Nome { get; set; }
    
    [Column("descricao")]
    public string Descricao  { get; set; }
    
    public ICollection<CarroORM>? Carros { get; set; }
}