import type { Estacionamento } from "./Estacionamento";
import type { Pessoa } from "./pessoa";


export class Guarda{
    id?: number;
    pessoa?: Pessoa;
    estacionamento?: Estacionamento;
    salario?: number;
    horario_turno?: string;
}