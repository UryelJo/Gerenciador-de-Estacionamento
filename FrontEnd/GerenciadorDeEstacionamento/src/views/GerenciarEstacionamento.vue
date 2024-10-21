<script setup lang="ts">
import { CarroInfos } from '@/models/Carro/CarroInfos';
import { CarroModel } from '@/models/Carro/CarroModel';
import { TipoCarroModel } from '@/models/TipoCarro/TipoCarroModel';
import { ref } from 'vue';
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import SplitButton from 'primevue/splitbutton';
import Dialog from 'primevue/dialog';
import { FilterMatchMode } from '@primevue/core/api';
import InputText from 'primevue/inputtext';
import Button from 'primevue/button';
import Card from 'primevue/card';
import { EstacionamentoModel } from '@/models/Estacionamento/EstacionamentoModel';
import { EstacionamentoInfos } from '@/models/Estacionamento/EstacionamentoInfos';
import { PessoaModel } from '@/models/Pessoa/PessoaModel';
import { GuardaInfos } from '@/models/Guarda/GuardaInfos';
import Avatar from 'primevue/avatar';

let registrosDeEntrada = ref<CarroInfos[]>([
    new CarroInfos('Camaro', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Sedan V789', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Camaro', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Sedan V789', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Camaro', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Sedan V789', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Camaro', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Sedan V789', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
]);

const informacoesEstacionamento = ref<EstacionamentoModel>(
    new EstacionamentoInfos('Fundo de Quintal', 'Rua dos Bobos', 5, 7));

const pessoa = new PessoaModel();
pessoa.nome = 'Almir';
pessoa.cpf = '123.456.789-00';
pessoa.idade = 23;
const guardinhas = ref(new GuardaInfos(pessoa, new EstacionamentoModel(), 2500,'Sim' ));

const filters = ref({
    global: { value: null, matchMode: FilterMatchMode.CONTAINS }
});

const dialogVisivel = ref<boolean>(false);
const carroExibido = ref<CarroInfos | null>(null);
let quantidadeVagasPequenasDisponiveis = 0;
let quantidadeVagasGrandesDisponiveis = 0;
let quantidadeVagasGrandesOcupadas = 0;
let quantidadeVagasPequenasOcupadas = 0;

const conteudoSplitButton = (carro: CarroInfos) => [
    { separator: true },
    { 
        label: 'Atualizar', icon: 'bi bi-arrow-clockwise', command: atualizar 
    },
    { 
        label: 'Excluir', icon: 'bi bi-trash', command: () => console.log('Excluir') 
    }
];

function exibirDetalhes(carro: CarroInfos) {
    carroExibido.value = carro;
    dialogVisivel.value = true;
}

function atualizar() {
    window.location.reload();
}
</script>

<template>
    <div class="header-pagina"><b>Estacionamento {{informacoesEstacionamento.nome}}</b></div>
    <div class="conteudo">
        <div class="conteudo-direita">
            <DataTable v-model:filters="filters" :value="registrosDeEntrada" paginator :rows="5">
                <template #header>
                    <div class="header-tabela">
                        <h2>Registros Ativos</h2>
                        <Button label="Novo Registro" icon="bi bi-plus" @click="atualizar" text raised />
                    </div>
                </template>
                <!-- <Column>
                    <template #body = "{data}" :v-tooltip="'Almir'" >
                        <Button v-tooltip.left="'Exibir Detalhes'" icon="bi bi-eye" @click="exibirDetalhes(data)" text raised  />
                    </template>
                </Column> -->
                <Column field="nome" header="Modelo do Carro"></Column>
                <!-- <Column field="ano" header="Ano do Modelo"></Column>
                <Column field="placa" header="Numeração da Placa"></Column>
                <Column field="cor" header="Cor"></Column> -->
                <Column header="Ações"> 
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
                            <b>Nome:</b> Uryel Jó de Lucca Araujo de Oliveira <br>
                            <b>CPF:</b>  <br>
                            <b>Idade:</b> <br>
                        </p>
                    </template>
                </Card>
                <Card class="card">
                    <template #title>Guarda 2  <Avatar icon="bi bi-shield-plus" style="background-color: #ece9fc; color: #2a1261"/></template>
                        <template #content>
                        <p class="Card-Guardinha"  >
                            <b>Nome:</b> Uryel Jó de Lucca Araujo de Oliveira <br>
                            <b>CPF:</b>  <br>
                            <b>Idade:</b>  <br>
                        </p>
                    </template>
                </Card>
            </div>
            <div class="outras-infos">
                <div class="texto-quantidade">
                    <b>Quantidade de vagas Pequenas disponíveis: {{ quantidadeVagasPequenasDisponiveis }}</b><br>
                    <b>Quantidade de vagas Grandes disponíveis: {{ quantidadeVagasGrandesDisponiveis }}</b>
                </div>
                <br>
                <div class="texto-quantidade"> 
                    <b>Quantidade de vagas Pequenas ocupadas: {{ quantidadeVagasPequenasOcupadas }}</b><br>
                    <b>Quantidade de vagas Grandes ocupadas: {{ quantidadeVagasGrandesOcupadas }}</b>
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
    font-size: 23px;
    padding: 1rem;
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

.split-button > .p-splitbutton-button {
    display: none;
}

.split-button > .p-button-icon-only {
    display: flex;
    border-radius: 5px;
} */

</style>
