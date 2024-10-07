using Projeto_Estacionamento.DTOs;

namespace Projeto_Estacionamento.Services.Guarda;

public interface IGuardaService
{
    Task<List<GuardaDTO>> ListarTodosOsGuardas();
}