
import type { Carro } from "./Carro";
import type { Estacionamento } from "./Estacionamento";
import type { Motorista } from "./Motorista";

export class Registro{
    id: number;
    motorista: Motorista;
    carro: Carro;
    horarioInicio: string;
    horarioFim: string;
    estacionamento: Estacionamento;
    tipoVagaOcupada: string;
    diaDoRegistro: string;

    constructor(id: number, motorista: Motorista, carro: Carro, horario_inicio: string, horario_fim: string, estacionamento: Estacionamento, tipoVagaOcupada: string, diaDoRegistro: string){
        this.id = id;
        this.motorista = motorista;
        this.carro = carro;
        this.horarioInicio = horario_inicio;
        this.horarioFim = horario_fim;
        this.estacionamento = estacionamento;
        this.tipoVagaOcupada = tipoVagaOcupada;
        this.diaDoRegistro = diaDoRegistro
    }
}