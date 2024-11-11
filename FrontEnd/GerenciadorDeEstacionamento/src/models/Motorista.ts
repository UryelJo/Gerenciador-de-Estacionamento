import type { Pessoa } from "./Pessoa";

export class Motorista{
    id:number;
    pessoa: Pessoa;
    planoPago:boolean;

    constructor(id:number, pessoa: Pessoa, planoPago:boolean){
        this.id = id;
        this.pessoa = pessoa;
        this.planoPago = planoPago;
    }
}