using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estacionamento.ORMModel;

[Table("pessoa",Schema = "public")]
public class PessoaORM
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    
    [Required]
    [Column("nome")]
    public string Nome { get; set; }
    
    [Required]
    [Column("cpf")]
    public string Cpf { get; set; }
    
    [Required]
    [Column("idade")]
    public int Idade { get; set; }
}