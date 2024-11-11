import type { Plano } from "./Plano";

export class Pessoa{
    id: number;
    nome: string;
    cpf: string;
    idade: number;
    plano: Plano;

    constructor(id: number, nome: string, cpf: string, idade: number, plano: Plano){
        this.id = id;
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.plano = plano;
    }
}