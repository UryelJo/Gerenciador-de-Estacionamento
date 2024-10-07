using Projeto_Estacionamento.DTOs;

namespace Projeto_Estacionamento.Services.Motorista;

public interface IMotoristaService
{
    Task<List<MotoristaDTO>> ListarTodosOsMotoristas();
}