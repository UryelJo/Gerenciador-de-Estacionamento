using Microsoft.EntityFrameworkCore;
using Projeto_Estacionamento.Contexts;
using Projeto_Estacionamento.Entities;
using Projeto_Estacionamento.Models;
using Projeto_Estacionamento.ORMModel;
using Projeto_Estacionamento.Protocols;

namespace Projeto_Estacionamento.Actions.CarroActions;

public class ListarTodosOsCarros
{
    private CarContext _contextoCarros;
    
    public ListarTodosOsCarros(CarContext contextoCarros)
    {
        this._contextoCarros = contextoCarros;
    }

    public async Task<List<CarroImpl>> Execute()
    {
        List<CarroORM> carros = await this._contextoCarros.ListarTodosOsCarros();

        if (carros == null) throw new NullReferenceException("Não existem dados cadastrados no banco de dados");
        
        return carros.Select(carro => (new CarroImpl(carro, carro.Marca, carro.TipoCarro))).ToList();
    }
    
}