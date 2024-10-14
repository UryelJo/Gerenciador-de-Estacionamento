import type { EnderecoModel } from "../Endereco/EnderecoModel";

export class EstacionamentoModel{
    id?: number;
    endereco?: EnderecoModel;
    quantidade_vagas_p?: number;
    quantidade_vagas_g?: number;
}