using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.DTOs;

public class CarroDTO
{
    public int Id { get; set; }
    
    public string Nome { get; set; }
    
    public int Ano { get; set; }
    
    public int QuantidadeDePortas {  get; set; }
    
    public string ModeloDoMotor { get; set; }
    
    public string Placa { get; set; }
    
    public string Cor { get; set; }
    
    public string TipoCarro { get; set; }

    public MarcaDTO Marca { get; set; }

    public CarroDTO(CarroORM carro)
    {  
        this.Id = carro.Id;
        this.Nome = carro.Nome;
        this.Ano = carro.Ano;
        this.QuantidadeDePortas = carro.QuantidadeDePortas;
        this.ModeloDoMotor = carro.ModeloDoMotor;
        this.Placa = carro.Placa;
        this.Cor = carro.Cor;
        this.TipoCarro = carro.TipoCarro.Descricao;
        this.Marca = new MarcaDTO(carro.Marca);
    }

    public static List<CarroDTO> ConverterListaEmCarroDto(List<CarroORM> carroOrms)
    {
        return carroOrms.Select(carro => (new CarroDTO(carro))).ToList();
    }
}