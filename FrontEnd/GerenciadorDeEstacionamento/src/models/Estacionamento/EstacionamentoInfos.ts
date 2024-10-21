

export class EstacionamentoInfos{
    nome?: string;
    endereco?: string;
    quantidadeVagasP: number;
    quantidadeVagasG: number;

    constructor(nome:string , endereco: string, quantidade_vagas_p: number, quantidade_vagas_g: number){
        this.nome = nome;
        this.endereco = endereco;
        this.quantidadeVagasP = quantidade_vagas_p;
        this.quantidadeVagasG = quantidade_vagas_g;
    }
}