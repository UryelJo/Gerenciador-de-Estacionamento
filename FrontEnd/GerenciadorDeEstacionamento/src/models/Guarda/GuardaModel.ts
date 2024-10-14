
import type { EstacionamentoModel } from "../Estacionamento/EstacionamentoModel";
import type { PessoaModel } from "../Pessoa/PessoaModel";

export class GuardaModel{
    id?: number;
    idPessoa?: PessoaModel;
    estacionamento?: EstacionamentoModel;
    salario?: number;
    horarioTurno?: string;
}