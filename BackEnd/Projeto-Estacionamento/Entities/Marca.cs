using System.ComponentModel.DataAnnotations;

namespace Projeto_Estacionamento.Entities;

public interface Marca
{
    [Key]
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public string Descricao  { get; set; }
}