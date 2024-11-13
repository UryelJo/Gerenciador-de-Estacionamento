using estacionamento_api.Models.DTOs;

namespace estacionamento_api.Services.Carro;

public interface ICarroService
{
    public List<CarroDTO> ListarTodosOsCarros();
}