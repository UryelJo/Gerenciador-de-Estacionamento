using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Estacionamento.ORMModel;

[Table("carro", Schema = "public")]
public class CarroORM
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
    [Column("ano")]
    public int Ano { get; set; }

    [Required]
    [Column("quantidade_de_portas")]
    public int QuantidadeDePortas { get; set; }

    [Required]
    [Column("modelo_do_motor")]
    public string ModeloDoMotor { get; set; }

    [Required]
    [Column("placa")]
    public string Placa { get; set; }

    [Required]
    [Column("cor")]
    public string Cor { get; set; }

    [Column("id_tipo_carro")]
    public int TipoCarroId { get; set; }

    [ForeignKey("TipoCarroId")]
    public TipoCarroORM? TipoCarro { get; set; }

    [Column("id_marca")]
    public int MarcaId { get; set; }

    [ForeignKey("MarcaId")]
    public MarcaORM? Marca { get; set; }
    
    [Column("id_motorista")]
    public int MotoristaId { get; set; }

    [ForeignKey("MotoristaId")]
    public MotoristaORM? MotoristaOrm { get; set; }
}