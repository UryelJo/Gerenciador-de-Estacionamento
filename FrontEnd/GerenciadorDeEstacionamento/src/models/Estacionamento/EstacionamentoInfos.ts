import type { EnderecoModel } from "../Endereco/EnderecoModel";

export class EstacionamentoInfos{
    endereco: EnderecoModel;
    quantidade_vagas_p: number;
    quantidade_vagas_g: number;

    constructor(endereco: EnderecoModel, quantidade_vagas_p: number, quantidade_vagas_g: number){
        this.endereco = endereco;
        this.quantidade_vagas_p = quantidade_vagas_p;
        this.quantidade_vagas_g = quantidade_vagas_g;
    }
}