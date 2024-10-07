using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estacionamento.ORMModel;

[Table("motorista",Schema = "public")]
public class MotoristaORM
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("id_pessoa")]
    public int IdPessoa { get; set; }

    [ForeignKey("IdPessoa")]
    public PessoaORM? PessoaOrm { get; set; }
    
    public ICollection<CarroORM>? Carros { get; set; }
}