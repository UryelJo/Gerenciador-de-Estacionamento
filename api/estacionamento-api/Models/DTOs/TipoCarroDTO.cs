using estacionamento_api.Models.ORMs;

namespace estacionamento_api.Models.DTOs;

public class TipoCarroDTO
{
    public int Id { get; set; }
    public String Descricao { get; set; }

    public TipoCarroDTO(TipoCarroORM tipoCarro)
    {
        this.Id = tipoCarro.Id;
        this.Descricao = tipoCarro.Descricao;
    }
}