using Projeto_Estacionamento.Entities;

namespace Projeto_Estacionamento.Models;

public class MarcaImpl : Marca
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao  { get; set; }

    public MarcaImpl(Marca marca)
    {
        this.Id = marca.Id;
        this.Nome = marca.Nome;
        this.Descricao = marca.Descricao;
    }
}