using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.DTOs;

public class PessoaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public int Idade { get; set; }
    
    public PessoaDTO(PessoaORM pessoaOrm)
    {
        this.Id = pessoaOrm.Id;
        this.Nome = pessoaOrm.Nome;
        this.Cpf = pessoaOrm.Cpf;
        this.Idade = pessoaOrm.Idade;
    }

    public static List<PessoaDTO> ConverterListaDePessoaORMParaPessoaDTO(List<PessoaORM> pessoas)
    {
        return pessoas.Select(pessoa => new PessoaDTO(pessoa)).ToList();
    }
}