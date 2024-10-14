import type { MarcaModel } from "../Marca/MarcaModel";
import type { TipoCarroModel } from "../TipoCarro/TipoCarroModel";


export class CarroInfos{
    nome: string;
    ano: number;
    quantidadeDePortas: number;
    modeloDoMotor: string;
    placa: string;
    cor: string;
    idTipoCarro: TipoCarroModel;
    idMarca: MarcaModel;

    constructor(nome: string, ano: number, quantidade_de_portas: number, modelo_do_motor: string, placa: string, cor: string, id_tipo_carro: TipoCarroModel, id_marca: MarcaModel){
        this.nome = nome;
        this.ano = ano;
        this.quantidadeDePortas = quantidade_de_portas;
        this.modeloDoMotor = modelo_do_motor;
        this.placa = placa;
        this.cor = cor;
        this.idTipoCarro = id_tipo_carro;
        this.idMarca = id_marca;
    }
}