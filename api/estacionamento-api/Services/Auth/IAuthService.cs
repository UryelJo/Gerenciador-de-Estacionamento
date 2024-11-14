using estacionamento_api.Models.DTOs;

namespace estacionamento_api.Services.Auth;

public interface IAuthService
{
    public UsuarioDTO buscarUmUsuario(String nick);
}