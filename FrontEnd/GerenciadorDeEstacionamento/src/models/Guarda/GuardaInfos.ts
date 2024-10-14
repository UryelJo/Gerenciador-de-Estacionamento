import type { EstacionamentoModel } from "../Estacionamento/EstacionamentoModel";
import type { PessoaModel } from "../Pessoa/PessoaModel";

export class GuardaInfos{
    idPessoa: PessoaModel;
    estacionamento: EstacionamentoModel;
    salario: number;
    horarioTurno: string;

    constructor(id_pessoa: PessoaModel, estacionamento: EstacionamentoModel, salario: number, horario_turno: string){
        this.idPessoa = id_pessoa;
        this.estacionamento = estacionamento;
        this.salario = salario;
        this.horarioTurno = horario_turno;
    }
}