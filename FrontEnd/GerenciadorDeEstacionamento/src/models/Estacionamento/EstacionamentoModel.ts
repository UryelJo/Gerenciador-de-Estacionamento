import type { EnderecoModel } from "../Endereco/EnderecoModel";

export class EstacionamentoModel{
    id?: number;
    endereco?: EnderecoModel;
    quantidadeVagasP?: number;
    quantidadeVagasG?: number;
}