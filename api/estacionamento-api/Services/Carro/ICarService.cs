using Projeto_Estacionamento.DTOs;

namespace Projeto_Estacionamento.Services.Carro;

public interface ICarroService
{
    Task<List<CarroDTO>> ListarTodosOsCarros();
}