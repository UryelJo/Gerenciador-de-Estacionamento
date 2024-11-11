export class Estacionamento{
    id:number;
    nome:string;
    endereco:string;
    quantidadeVagasP:number;
    quantidadeVagasG:number;

    constructor(id:number, nome:string, endereco:string, quantidadeVagasP:number, quantidadeVagasG:number){
        this.id = id;
        this.nome = nome;
        this.endereco = endereco;
        this.quantidadeVagasP = quantidadeVagasP;
        this.quantidadeVagasG = quantidadeVagasG;
    }
}