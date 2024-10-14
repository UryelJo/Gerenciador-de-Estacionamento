import type { MarcaModel } from "../Marca/MarcaModel";
import type { TipoCarroModel } from "../TipoCarro/TipoCarroModel";


export class CarroInfos{
    nome: string;
    ano: number;
    quantidade_de_portas: number;
    modelo_do_motor: string;
    placa: string;
    cor: string;
    id_tipo_carro: TipoCarroModel;
    id_marca: MarcaModel;

    constructor(nome: string, ano: number, quantidade_de_portas: number, modelo_do_motor: string, placa: string, cor: string, id_tipo_carro: TipoCarroModel, id_marca: MarcaModel){
        this.nome = nome;
        this.ano = ano;
        this.quantidade_de_portas = quantidade_de_portas;
        this.modelo_do_motor = modelo_do_motor;
        this.placa = placa;
        this.cor = cor;
        this.id_tipo_carro = id_tipo_carro;
        this.id_marca = id_marca;
    }
}