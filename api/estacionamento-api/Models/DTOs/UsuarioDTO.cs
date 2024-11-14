using estacionamento_api.Models.ORMs;

namespace estacionamento_api.Models.DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }
    public String Nick { get; set; }

    public UsuarioDTO(Usuario usuario)
    {
        this.Id = usuario.Id;
        this.Nick = usuario.Nick;
    }
}