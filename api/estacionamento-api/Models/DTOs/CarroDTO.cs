using estacionamento_api.Models.ORMs;

namespace estacionamento_api.Models.DTOs;

public class CarroDTO
{
    
    public int Id { get; set; }
    public int Ano { get; set; }
    public String NomeModelo { get; set; }
    public int QuantidadeDePortas { get; set; }
    public String ModeloDoMotor { get; set; }
    public String Placa { get; set; }
    public TipoCarroDTO TipoCarro { get; set; }
    public MarcaDTO Marca { get; set; }
    
    public CarroDTO(CarroORM carro)
    {
        this.Id = carro.Id;
        this.Ano = carro.Ano;
        this.NomeModelo = carro.NomeModelo;
        this.QuantidadeDePortas = carro.QuantidadeDePortas;
        this.ModeloDoMotor = carro.ModeloDoMotor;
        this.Placa = carro.Placa;
        this.TipoCarro = new TipoCarroDTO(carro.TipoCarro);
        this.Marca = new MarcaDTO(carro.Marca);
    }
}