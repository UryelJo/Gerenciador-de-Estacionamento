import type { PessoaModel } from "../Pessoa/PessoaModel";

export class MotoristaInfos{
    pessoa: PessoaModel;

    constructor(pessoa: PessoaModel){
        this.pessoa = pessoa;
    }
}