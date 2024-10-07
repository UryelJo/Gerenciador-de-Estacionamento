using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.DTOs;

public class MarcaDTO
{
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public string Descricao  { get; set; }

    public MarcaDTO(MarcaORM marca)
    {
        this.Id = marca.Id;
        this.Nome = marca.Nome;
        this.Descricao = marca.Descricao;
    }
}