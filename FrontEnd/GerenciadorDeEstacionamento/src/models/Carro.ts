import type { Marca } from "./Marca";
import type { TipoCarro } from "./TipoCarro";

export class Carro{
    id:number;
    modelo:string;
    ano:string;
    quantidadeDePortas:number;
    modeloDoMotor:string;
    placa:string;
    cor:string;
    tipoCarro:TipoCarro;
    marca:Marca;

    constructor(id:number, modelo:string, ano:string, quantidadeDePortas:number, modeloDoMotor:string, placa:string, cor:string, tipoCarro:TipoCarro, marca:Marca){
        this.id = id;
        this.modelo = modelo;
        this.ano = ano;
        this.quantidadeDePortas = quantidadeDePortas;
        this.modeloDoMotor = modeloDoMotor;
        this.placa = placa;
        this.cor = cor;
        this.tipoCarro = tipoCarro;
        this.marca = marca;
    }
}