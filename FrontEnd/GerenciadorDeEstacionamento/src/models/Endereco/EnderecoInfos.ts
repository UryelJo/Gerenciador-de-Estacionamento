export class EnderecoInfos{
    rua: string;
    numero: number;
    bairro: string;
    cidade: string;
    estado: string;
    cep: string;

    constructor(rua: string, numero: number, bairro: string, cidade: string, estado: string, cep: string){
        this.rua = rua;
        this.numero = numero;
        this.bairro = bairro;
        this.cidade = cidade;
        this.estado = estado;
        this.cep = cep;
    }
}