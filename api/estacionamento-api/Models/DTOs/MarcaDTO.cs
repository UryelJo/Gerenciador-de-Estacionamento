
using estacionamento_api.Models.ORMs;

namespace estacionamento_api.Models.DTOs;

public class MarcaDTO
{
    public int Id { get; set; }
    public String Descricao { get; set; }
    public String Nome { get; set; }

    public MarcaDTO(MarcaORM marca)
    {
        this.Id = marca.Id = marca.Id;
        this.Descricao = marca.Descricao;
        this.Nome = marca.Nome;
    }
}