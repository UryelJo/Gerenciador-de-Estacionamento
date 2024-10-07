using Projeto_Estacionamento.Entities;
using Projeto_Estacionamento.Models;
using Projeto_Estacionamento.Protocols;

namespace Projeto_Estacionamento.Actions.CarroActions;

public class BuscarCarroPorPlaca
{
    private CarProtocol _contextoCarros;
    private string _placa;
    
    public BuscarCarroPorPlaca(CarProtocol contextoCarros, string placa)
    {
        this._contextoCarros = contextoCarros;
        this._placa = placa;
    }

    public CarroImpl Execute()
    {
        CarroComMarcaETipo carro = this._contextoCarros.BuscarCarroPorPlaca(_placa);

        if (carro == null) throw new NullReferenceException("Não existe nenhum carro cadastrado com a placa :: " + _placa);

        return new CarroImpl(carro, carro.Marca, carro.TipoCarro);
    }
}