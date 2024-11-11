<script setup lang="ts">
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import SplitButton from 'primevue/splitbutton';
import Button from 'primevue/button';
import Card from 'primevue/card';
import Avatar from 'primevue/avatar';
import { ref } from 'vue';
import { FilterMatchMode } from '@primevue/core/api';
import { Registro } from '@/models/Registro';
import { Estacionamento } from '@/models/Estacionamento';
import { Pessoa } from '@/models/Pessoa';
import { Plano } from '@/models/Plano';
import { Motorista } from '@/models/Motorista';
import { Carro } from '@/models/Carro';
import { TipoCarro } from '@/models/TipoCarro';
import { Marca } from '@/models/Marca';
import { Guarda } from '@/models/Guarda';

let carro = new Carro(1, "Fiat", "2029", 4, "v12", "123456", "verde", new TipoCarro(1, "Sedan"), new Marca(1, "Fiat", "Marca ai"));
const pessoa = new Pessoa(1, 'Uryel Jó de Lucca Araujo de Oliveira', '12345678910', 20, new Plano(1, 'Premium', 23, 2500, 'P'));
const informacoesEstacionamento = ref<Estacionamento>(
    new Estacionamento(1, 'Fundo de Quintal', 'Rua Sim 1234', 20, 15));

let registrosDeEntrada = ref<Registro[]>([
    new Registro(1, new Motorista(1, pessoa, true), carro, '17:50', '', informacoesEstacionamento.value, 'Grande', '2021-10-10'),
    new Registro(2, new Motorista(1, pessoa, true), carro, '18:50', '', informacoesEstacionamento.value, 'Grande', '2021-10-10'),
    new Registro(3, new Motorista(1, pessoa, true), carro, '19:50', '', informacoesEstacionamento.value, 'Grande', '2021-10-10'),
    new Registro(4, new Motorista(1, pessoa, true), carro, '20:50', '', informacoesEstacionamento.value, 'Grande', '2021-10-10'),
    new Registro(5, new Motorista(1, pessoa, true), carro, '21:50', '', informacoesEstacionamento.value, 'Grande', '2021-10-10'),
    new Registro(6, new Motorista(1, pessoa, true), carro, '22:50', '', informacoesEstacionamento.value, 'Grande', '2021-10-10'),
]);

let guardinha1 = new Guarda(1, pessoa, 2500);
let guardinha2 = new Guarda(2, pessoa, 20);

const filters = ref({
    global: { value: null, matchMode: FilterMatchMode.CONTAINS }
});

const dialogVisivel = ref<boolean>(false);
const registroExibido = ref<Registro | null>(null);

let quantidadeVagasPequenasDisponiveis = 0;
let quantidadeVagasGrandesDisponiveis = 0;
let quantidadeVagasGrandesOcupadas = 0;
let quantidadeVagasPequenasOcupadas = 0;

const chegouLimiteDeVagas = ref<boolean>(false);

const conteudoSplitButton = (registro: Registro) => [
    { separator: true },
    { 
        label: 'Atualizar', icon: 'bi bi-arrow-clockwise', command: atualizar 
    },
    { 
        label: 'Excluir', icon: 'bi bi-trash', command: () => console.log('Excluir') 
    }
];

function exibirDetalhes(registro: Registro) {
    registroExibido.value = registro;
    dialogVisivel.value = true;
}

function atualizarStatusVagas() {
    quantidadeVagasGrandesDisponiveis = informacoesEstacionamento.value.quantidadeVagasG;
    quantidadeVagasPequenasDisponiveis = informacoesEstacionamento.value.quantidadeVagasP;

    registrosDeEntrada.value.forEach(registro => {
        if (registro.tipoVagaOcupada === 'Pequena') {
            quantidadeVagasPequenasOcupadas++;
            quantidadeVagasPequenasDisponiveis--;
        } else {
            quantidadeVagasGrandesOcupadas++;
            quantidadeVagasGrandesDisponiveis--;
        }
    });

    if (quantidadeVagasPequenasDisponiveis === 0 && quantidadeVagasGrandesDisponiveis === 0) {
        chegouLimiteDeVagas.value = true;
    }
}

function atualizar() {
    window.location.reload();
}
</script>

<template>
    <div class="header-pagina"><b>Estacionamento {{informacoesEstacionamento.nome}}</b></div>
    <div class="conteudo">
        <div class="conteudo-direita">
            <DataTable v-model:filters="filters" stripedRows :value="registrosDeEntrada" paginator :rows="4">
                <template #header>
                    <div class="header-tabela">
                        <h2>Registros Ativos</h2>
                        <Button label="Novo Registro" icon="bi bi-plus" @click="atualizar" text raised :disabled="chegouLimiteDeVagas" />
                    </div>
                </template>
                <Column style="text-align: center;" field="motorista.pessoa.nome" header="Nome Cliente"></Column>
                <Column style="text-align: center;" field="carro.modelo" header="Modelo do Carro"></Column>
                <Column style="text-align: center;" field="carro.placa" header="Placa do Carro"></Column>
                <Column style="text-align: center;" field="horarioInicio" header="Horario Entrada"></Column>
                <Column style="text-align: center;" field="motorista.pessoa.plano.nivelDoPlano" header="Plano"></Column>
                <Column style="text-align: center;" field="tipoVagaOcupada" header="Vaga Ocupada"></Column>
                <Column > 
                    <template #body="{ data }">
                        <SplitButton :model="conteudoSplitButton(data)" v-tooltip="'Mais Acões'" size="small" raised text class="split-button" />
                    </template>
                </Column>
            </DataTable>
        </div>
        <div class="conteudo-esquerda">
            <div class="header-guardas"> Guardas Ativos <Button label="Trocar Turno" icon="bi bi-arrow-left-right" @click="atualizar" text raised /></div>
            
            <div class="tabela-de-funcionarios">
                <Card class="card">
                    <template #title>Guarda 1  <Avatar icon="bi bi-shield-plus" style="background-color: #ece9fc; color: #2a1261"/> </template>
                        <template #content>
                        <p >
                            <b>Nome:</b> {{guardinha1.pessoa.nome}} <br>
                            <b>CPF:</b> {{guardinha1.pessoa.cpf}}  <br>
                            <b>Idade:</b> {{ guardinha1.pessoa.idade }} <br>
                        </p>
                    </template>
                </Card>
                <Card class="card">
                    <template #title>Guarda 2  <Avatar icon="bi bi-shield-plus" style="background-color: #ece9fc; color: #2a1261"/></template>
                        <template #content>
                        <p class="Card-Guardinha"  >
                            <b>Nome:</b> {{guardinha2.pessoa.nome}} <br>
                            <b>CPF:</b> {{guardinha2.pessoa.cpf}}  <br>
                            <b>Idade:</b> {{ guardinha2.pessoa.idade }} <br>
                        </p>
                    </template>
                </Card>
            </div>
            <div class="outras-infos" :v-model="atualizarStatusVagas()">
                <div class="texto-quantidade">
                    <b>Quantidade de vagas Pequenas disponíveis: {{quantidadeVagasPequenasDisponiveis}}</b><br>
                    <b>Quantidade de vagas Grandes disponíveis: {{quantidadeVagasGrandesDisponiveis}}</b>
                </div>
                <br>
                <div class="texto-quantidade"> 
                    <b>Quantidade de vagas Pequenas ocupadas: {{quantidadeVagasPequenasOcupadas}}</b><br>
                    <b>Quantidade de vagas Grandes ocupadas: {{quantidadeVagasGrandesOcupadas}}</b>
                </div>
            </div>
        </div>
    </div>
</template>

<style>

.p-card-title{
    color: #32BC8A;
}

.conteudo{
    display: flex;
    flex-direction: row;
    flex: 1;
}

.conteudo-direita{
    width: 65%;
    height: 100%;
    padding: 1rem;
}

.conteudo-esquerda{
    width: 35%;
    height: 100%;
    padding: 1rem;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
}

.header-pagina{
    display: flex;
    justify-content: center;
    font-size: 30px;
    color: white;
    background-color: #1f1f1f;
    align-items: center;
    transition: 1s;
}

.header-tabela{
    justify-content: center;
    gap: 40px;
    display: flex;
}

.header-guardas{
    justify-content: center;
    display: flex;
    align-items: center;
    font-size: 23px;
    color: white;
    gap: 40px;
    padding: 10px;
    background-color: #27272A;
    border-radius: 5px;
    margin-bottom: 10px;
}

.header-pagina:hover{
    background-color: #1f1f1f;
    text-shadow: 1px 1px 2px purple, 0 0 1em blue, 0 0 0.2em blueviolet;
}

.tabela-de-funcionarios{
    display: flex;
    flex-direction: row;
    justify-content: center;
    gap: 40px;
}

.outras-infos{
    color: white;
    margin: 30px 5px 20px 5px
}

.texto-quantidade{
    color: white;
    font-size: 16px;
    background-color: #27272A;
    padding: 10px;
    border-radius: 5px;
}

.Card-Guardinha > b{
    color: white;
    font-size: 15px;
}

.card{
    transition: 1s;
}

.card:hover {
    background-color: #27272ad2;
    color: white;
}

/* .tabela-de-registros {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    padding: 1rem;
} */

/* .input-pesquisa{
    width: 100%;
}
*/

.split-button > .p-splitbutton-button {
    display: none;
}

.split-button > .p-button-icon-only {
    display: flex;
    border-radius: 5px;
}

</style>
