using Projeto_Estacionamento.Entities;

namespace Projeto_Estacionamento.Models
{
    public class CarroImpl : Carro 
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ano { get; set; }
        public int QuantidadeDePortas { get; set; }
        public string ModeloDoMotor { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public MarcaImpl Marca { get; set; }
        public TipoCarroImpl TipoCarro { get; set; }

        public CarroImpl (Carro carro, Marca marca, TipoCarro tipoCarro)
        {
            this.Id = carro.Id;
            this.Nome = carro.Nome;
            this.Ano = carro.Ano;
            this.QuantidadeDePortas = carro.QuantidadeDePortas;
            this.ModeloDoMotor = carro.ModeloDoMotor;
            this.Placa = carro.Placa;
            this.Cor = carro.Cor;
            this.Marca = new MarcaImpl(marca);
            this.TipoCarro = new TipoCarroImpl(tipoCarro);
        }
        public CarroImpl (Carro carro, Marca marca)
        {
            this.Id = carro.Id;
            this.Nome = carro.Nome;
            this.Ano = carro.Ano;
            this.QuantidadeDePortas = carro.QuantidadeDePortas;
            this.ModeloDoMotor = carro.ModeloDoMotor;
            this.Placa = carro.Placa;
            this.Cor = carro.Cor;
            this.Marca = new MarcaImpl(marca);
        }
        public CarroImpl (Carro carro, TipoCarro tipoCarro)
        {
            this.Id = carro.Id;
            this.Nome = carro.Nome;
            this.Ano = carro.Ano;
            this.QuantidadeDePortas = carro.QuantidadeDePortas;
            this.ModeloDoMotor = carro.ModeloDoMotor;
            this.Placa = carro.Placa;
            this.Cor = carro.Cor;
            this.TipoCarro = new TipoCarroImpl(tipoCarro);
        }
    }
}
