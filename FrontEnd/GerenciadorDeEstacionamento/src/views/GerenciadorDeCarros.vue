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

let almir = ref<CarroInfos[]>([
    new CarroInfos('Camaro', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel()),
    new CarroInfos('Sedan V789', 2024, 4,'Camaro', '1234-1234', 'Vermelho', new TipoCarroModel(), new CarroModel())
]);

const filters = ref({
    global: { value: null, matchMode: FilterMatchMode.CONTAINS }
});

const dialogVisivel = ref<boolean>(false);
const carroExibido = ref<CarroInfos | null>(null);

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
    <Dialog v-model:visible="dialogVisivel" header="Detalhes do Carro Selecionado" modal closable resizable :style="{ width: '700px' }"baseZIndex="10000" :draggable="true">
        <p>Modelo do Carro: {{ carroExibido?.nome }}</p>
        <p>Ano de Lancamento: {{ carroExibido?.ano }}</p>
        <p>Quantidade de Portas: {{ carroExibido?.quantidadeDePortas }}</p>
        <p>Modelo do Motor: {{ carroExibido?.modeloDoMotor }}</p>
        <p>Placa: {{ carroExibido?.placa }}</p>
        <p>Cor: {{ carroExibido?.cor }}</p>
        <p>Tipo de Carro: {{ carroExibido?.idTipoCarro }}</p>
    </Dialog>

    <Dialog header="Cadastrar Novo Veiculo">

    </Dialog>

    <div class="tabela-de-carros">
        <DataTable v-model:filters="filters" :value="almir" paginator :rows="5">
            <template #header>
                <div>
                    <InputText v-tooltip.left="'Pesquisa carro pelo modelo'" v-model="filters['global'].value" placeholder="Pesquisar por modelo" class="input-pesquisa" />
                </div>
            </template>
            <Column>
                <template #body = "{data}" :v-tooltip="'Almir'" >
                    <Button v-tooltip.left="'Exibir Detalhes'" icon="bi bi-eye" @click="exibirDetalhes(data)" text raised  />
                </template>
            </Column>
            <Column field="nome" header="Modelo do Carro"></Column>
            <Column field="ano" header="Ano do Modelo"></Column>
            <Column field="placa" header="Numeração da Placa"></Column>
            <Column field="cor" header="Cor"></Column>
            <Column header="Ações"> 
                <template #body="{ data }">
                    <SplitButton :model="conteudoSplitButton(data)" v-tooltip="'Mais Acões'" size="small" raised text class="split-button" />
                </template>
            </Column>
        </DataTable>
    </div>
</template>

<style>
.tabela-de-carros {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    padding: 1rem;
}

.input-pesquisa{
    width: 100%;
}

.split-button > .p-splitbutton-button {
    display: none;
}

.split-button > .p-button-icon-only {
    display: flex;
    border-radius: 5px;
}

</style>
