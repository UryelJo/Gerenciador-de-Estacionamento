import type { EnderecoModel } from "../Endereco/EnderecoModel";

export class EstacionamentoInfos{
    endereco: EnderecoModel;
    quantidadeVagasP: number;
    quantidadeVagasG: number;

    constructor(endereco: EnderecoModel, quantidade_vagas_p: number, quantidade_vagas_g: number){
        this.endereco = endereco;
        this.quantidadeVagasP = quantidade_vagas_p;
        this.quantidadeVagasG = quantidade_vagas_g;
    }
}