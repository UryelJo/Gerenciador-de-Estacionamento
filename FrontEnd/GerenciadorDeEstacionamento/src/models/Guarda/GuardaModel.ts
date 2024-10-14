
import type { EstacionamentoModel } from "../Estacionamento/EstacionamentoModel";
import type { PessoaModel } from "../Pessoa/PessoaModel";

export class GuardaModel{
    id?: number;
    id_pessoa?: PessoaModel;
    estacionamento?: EstacionamentoModel;
    salario?: number;
    horario_turno?: string;
}