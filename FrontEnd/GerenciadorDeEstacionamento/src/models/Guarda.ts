import type { Pessoa } from "./Pessoa";

export class Guarda{
    id:number;
    pessoa:Pessoa;
    salarioTotalRecebido:number;

    constructor(id:number, pessoa:Pessoa, salarioTotalRecebido:number){
        this.id = id;
        this.pessoa = pessoa;
        this.salarioTotalRecebido = salarioTotalRecebido;
    }
}