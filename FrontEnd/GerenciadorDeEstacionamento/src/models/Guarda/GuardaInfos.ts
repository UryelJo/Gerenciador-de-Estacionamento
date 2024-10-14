import type { EstacionamentoModel } from "../Estacionamento/EstacionamentoModel";
import type { PessoaModel } from "../Pessoa/PessoaModel";

export class GuardaInfos{
    id_pessoa: PessoaModel;
    estacionamento: EstacionamentoModel;
    salario: number;
    horario_turno: string;

    constructor(id_pessoa: PessoaModel, estacionamento: EstacionamentoModel, salario: number, horario_turno: string){
        this.id_pessoa = id_pessoa;
        this.estacionamento = estacionamento;
        this.salario = salario;
        this.horario_turno = horario_turno;
    }
}