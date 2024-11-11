export class Plano{
    id:number;
    nivelDoPlano:string;
    totalDiasCobertos:number;
    valorDoPlano:number;
    tipoDeVagaCoberta:string;

    constructor(id:number, nivelDoPlano:string, totalDiasCobertos:number, valorDoPlano:number, tipoDeVagaCoberta:string){
        this.id = id;
        this.nivelDoPlano = nivelDoPlano;
        this.totalDiasCobertos = totalDiasCobertos;
        this.valorDoPlano = valorDoPlano;
        this.tipoDeVagaCoberta = tipoDeVagaCoberta;
    }
}