using Projeto_Estacionamento.ORMModel;

namespace Projeto_Estacionamento.DTOs;

public class MotoristaDTO
{
    public int Id { get; set; }
    public PessoaDTO? Pessoa { get; set; }
    public List<CarroDTO>? Carros { get; set; }

    public MotoristaDTO(MotoristaORM motoristaOrm)
    {
        this.Id = motoristaOrm.Id;
        if (motoristaOrm.PessoaOrm != null) this.Pessoa = new PessoaDTO(motoristaOrm.PessoaOrm);
        if (motoristaOrm.Carros != null) this.Carros = CarroDTO.ConverterListaEmCarroDto(motoristaOrm.Carros.ToList());
    }

    public static List<MotoristaDTO> ConverterListaDeMotoristaORMParaMotoristaDTO(List<MotoristaORM> motoristas)
    {
        return motoristas.Select(motorista => new MotoristaDTO(motorista)).ToList();
    }
}