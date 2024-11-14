using estacionamento_api.Contexts;
using estacionamento_api.Models.DTOs;
using estacionamento_api.Models.ORMs;
using estacionamento_api.Utils.Exceptions;

namespace estacionamento_api.Services.Auth;

public class AuthService : IAuthService
{
    private AuthContext _context;

    public AuthService(AuthContext context)
    {
        this._context = context;
    }

    //Esse método realisticamente falando é impraticável! único e exclusivo para Testes
    public UsuarioDTO buscarUmUsuario(String nick)
    {
        Usuario usuarioBuscado = this._context.BuscarUsuario(nick);
        if (usuarioBuscado == null) throw new NoContentException("Usuário não encontrado!");
        return new UsuarioDTO(usuarioBuscado);
    }
}