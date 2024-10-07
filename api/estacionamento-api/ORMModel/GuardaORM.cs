using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estacionamento.ORMModel;

[Table("guarda", Schema = "public")]
public class GuardaORM
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("id_pessoa")]
    [Required]
    public int IdPessoa { get; set; }
    
    [Required]
    [Column("id_estacionamento")]
    public int IdEstacionamento { get; set; }
    
    [Column("salario")]
    public float Salario { get; set; }
    
    [Column("horario_turno")]
    public string HorarioTurno { get; set; }
    
    [ForeignKey("IdPessoa")]
    public PessoaORM Pessoa { get; set; }
}