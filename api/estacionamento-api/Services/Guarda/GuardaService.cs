using Projeto_Estacionamento.Contexts;
using Projeto_Estacionamento.DTOs;

namespace Projeto_Estacionamento.Services.Guarda;

public class GuardaService : IGuardaService
{
    private PessoaContext _pessoaContext { get; set; }

    public GuardaService(PessoaContext pessoaContext)
    {
        this._pessoaContext = pessoaContext;
    }

    public async Task<List<GuardaDTO>> ListarTodosOsGuardas()
    {
        return GuardaDTO.ConverterListaDeGuardaORMParaGuardaDTO(await this._pessoaContext.ListarGuardas());
    }
}