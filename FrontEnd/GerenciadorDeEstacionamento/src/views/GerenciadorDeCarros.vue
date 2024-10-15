<script setup lang="ts">
import { CarroInfos } from '@/models/Carro/CarroInfos';
import { CarroModel } from '@/models/Carro/CarroModel';
import { TipoCarroModel } from '@/models/TipoCarro/TipoCarroModel';
import { ref } from 'vue';
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import SplitButton from 'primevue/splitbutton';
import Dialog from 'primevue/dialog';
import { FilterMatchMode, FilterOperator } from '@primevue/core/api';
import InputText from 'primevue/inputtext';

let almir = ref<CarroInfos[]>([
    new CarroInfos('Sedan V89', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Sedan V789', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel())
]);

const filters = ref({
    global: { value: null, matchMode: FilterMatchMode.CONTAINS }
});

const dialogVisivel = ref<boolean>(false);
const carroExibido = ref<CarroInfos | null>(null);

const conteudoSplitButton = (carro: CarroInfos) => [
    { 
        label: 'Ver Detalhes', icon: 'bi bi-eye', command: () => exibirDetalhes(carro) 
    },
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
    <Dialog v-model:visible="dialogVisivel" header="Detalhes do Carro Selecionado" modal closable resizable :baseZIndex="10000">
        <p>Nome do Carro: {{ carroExibido?.nome }}</p>
        <p>Ano de Lancamento: {{ carroExibido?.ano }}</p>
        <p>Quantidade de Portas: {{ carroExibido?.quantidadeDePortas }}</p>
        <p>Modelo: {{ carroExibido?.modelo }}</p>
        <p>Placa: {{ carroExibido?.placa }}</p>
        <p>Cor: {{ carroExibido?.cor }}</p>
        <p>Tipo de Carro: {{ carroExibido?.tipoCarro }}</p>
        <p>Carro: {{ carroExibido?.carro }}</p>
    </Dialog>

    <div class="tabela-de-carros">
        <DataTable v-model:filters="filters" :value="almir" paginator :rows="5">
            <template #header>
                <div class="table-header">
                    <InputText v-model="filters['global'].value" placeholder="Pesquisar por nome do carro" />
                </div>
            </template>
            <Column field="nome" header="Nome do Carro"></Column>
            <Column field="ano" header="Ano de Lançamento"></Column>
            <Column field="placa" header="Placa"></Column>
            <Column header="Ações"> 
                <template #body="{ data }">
                    <SplitButton :model="conteudoSplitButton(data)" size="small" severity="contrast" raised text class="split-button" />
                </template>
            </Column>
        </DataTable>
    </div>
</template>

<style scoped>
.tabela-de-carros {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    padding: 1rem;
}

.split-button > .p-button {
    display: none;
}

.split-button > .p-button-icon-only {
    display: flex;
    border-radius: 7px;
}
</style>
