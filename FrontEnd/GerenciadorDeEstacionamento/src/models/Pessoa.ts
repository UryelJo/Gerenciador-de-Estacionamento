export class Pessoa{
    id?: number;
    nome?: string;
    cpf?: string;
    idade?: number;

    constructor(id: number, nome: string, cpf: string, idade: number){
        this.id = id;
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
    }
}