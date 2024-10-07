using Projeto_Estacionamento.Entities;

namespace Projeto_Estacionamento.Models;

public class TipoCarroImpl : TipoCarro
{
    public int Id { get; set; }
    public string Descricao { get; set; }

    public TipoCarroImpl(TipoCarro tipoCarro)
    {
        this.Id = tipoCarro.Id;
        this.Descricao = tipoCarro.Descricao;
    }
}