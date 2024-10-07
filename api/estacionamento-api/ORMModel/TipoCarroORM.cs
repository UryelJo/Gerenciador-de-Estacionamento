using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estacionamento.ORMModel;

[Table("tipo_carro", Schema = "public")]
public class TipoCarroORM
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("descricao")]
    public string Descricao { get; set; }
    
    public ICollection<CarroORM> Carros { get; set; }
}