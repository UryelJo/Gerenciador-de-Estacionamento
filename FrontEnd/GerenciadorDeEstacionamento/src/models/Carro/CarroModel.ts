import type { MarcaModel } from "../Marca/MarcaModel";
import type { TipoCarroModel } from "../TipoCarro/TipoCarroModel";

export class CarroModel{
    id?: number;
    nome?: string;
    ano?: number;
    quantidade_de_portas?: number;
    modelo_do_motor?: string;
    placa?: string;
    cor?: string;
    id_tipo_carro?: TipoCarroModel;
    id_marca?: MarcaModel;
}