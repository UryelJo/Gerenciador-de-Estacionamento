using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.DTOs;

public class GuardaDTO
{
    public int Id { get; set; }
    public int IdEstacionamento { get; set; }
    public float Salario { get; set; }
    public string HorarioTurno { get; set; }
    public PessoaDTO Pessoa { get; set; }

    public GuardaDTO(GuardaORM guardaOrm)
    {
        this.Id = guardaOrm.Id;
        this.IdEstacionamento = guardaOrm.IdEstacionamento;
        this.Salario = guardaOrm.Salario;
        this.HorarioTurno = guardaOrm.HorarioTurno;
        this.Pessoa = new PessoaDTO(guardaOrm.Pessoa);
    }

    public static List<GuardaDTO> ConverterListaDeGuardaORMParaGuardaDTO(List<GuardaORM> guardasOrm)
    {
        return guardasOrm.Select(guarda => new GuardaDTO(guarda)).ToList();
    }
}