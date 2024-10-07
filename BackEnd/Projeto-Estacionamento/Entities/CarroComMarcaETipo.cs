namespace Projeto_Estacionamento.Entities;

public class CarroComMarcaETipo : Carro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Ano { get; set; }
    public int QuantidadeDePortas {  get; set; }
    public string ModeloDoMotor { get; set; }
    public string Placa { get; set; }
    public string Cor { get; set; }
    public Marca? Marca { get; set; }
    public TipoCarro? TipoCarro { get; set; }
}