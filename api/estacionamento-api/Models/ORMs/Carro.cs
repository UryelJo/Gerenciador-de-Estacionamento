using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_api.Models.ORMs;

[Table("carro", Schema = "public")]
public class CarroORM
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("ano")]
    public int Ano { get; set; }
    
    [Column("nome_modelo")]
    public String NomeModelo { get; set; }
    
    [Column("qnt_portas")]
    public int QuantidadeDePortas { get; set; }
    
    [Column("modelo_motor")]
    public String ModeloDoMotor { get; set; }
    
    [Column("placa")]
    public String Placa { get; set; }
    
    [Column("id_tipo_carro")]
    [ForeignKey("TipoCarro")]
    public int IdTipoCarro { get; set; }
    
    [Column("id_marca")]
    [ForeignKey("Marca")]
    public int IdMarca { get; set; }
    
    public TipoCarroORM TipoCarro { get; set; }
    
    public MarcaORM Marca { get; set; }
    
    
}