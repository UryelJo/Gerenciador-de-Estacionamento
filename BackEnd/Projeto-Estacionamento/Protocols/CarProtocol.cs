using Projeto_Estacionamento.Entities;

namespace Projeto_Estacionamento.Protocols;

public interface CarProtocol
{
    public List<Carro> ListarTodosOsCarros();

    public CarroComMarcaETipo BuscarCarroPorPlaca(string placa);
}