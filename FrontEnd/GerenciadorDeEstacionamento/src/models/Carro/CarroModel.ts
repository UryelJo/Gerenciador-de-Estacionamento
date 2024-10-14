import type { MarcaModel } from "../Marca/MarcaModel";
import type { TipoCarroModel } from "../TipoCarro/TipoCarroModel";

export class CarroModel{
    id?: number;
    nome?: string;
    ano?: number;
    quantidadeDePortas?: number;
    modeloDoMotor?: string;
    placa?: string;
    cor?: string;
    idTipoCarro?: TipoCarroModel;
    idMarca?: MarcaModel;
}