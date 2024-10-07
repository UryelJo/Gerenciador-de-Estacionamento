using Projeto_Estacionamento.Contexts;
using Projeto_Estacionamento.DTOs;

namespace Projeto_Estacionamento.Services.Motorista;

public class MotoristaService : IMotoristaService
{
    private readonly PessoaContext _pessoaContext;

    public MotoristaService(PessoaContext pessoaContext)
    {
        this._pessoaContext = pessoaContext;
    }

    public async Task<List<MotoristaDTO>> ListarTodosOsMotoristas()
    {
        return MotoristaDTO.ConverterListaDeMotoristaORMParaMotoristaDTO(await this._pessoaContext.ListarMotoristas());
    }
}