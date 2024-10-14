<script setup lang="ts">
import ComponenteBotao from '@/components/ComponenteBotao.vue';
import ComponenteTabela from '@/components/ComponenteTabela.vue';
import { CarroInfos } from '@/models/Carro/CarroInfos';
import { CarroModel } from '@/models/Carro/CarroModel';
import { TipoCarroModel } from '@/models/TipoCarro/TipoCarroModel';
import axios from 'axios';
import { ref } from 'vue';

axios.get('https://localhost:44307/listar-todos-os-carros').then((response) => {
    console.log(response.data);
});

</script>

<template>
    <div class="tabela-de-carros">
        <h1 class="titulo-da-tabela">Carros Cadastrados</h1>
        <ComponenteTabela :lista-de-objetos="listaDeCarros" :headers="['Nome do Carro','Ano de Lancamento','Placa', 'Acões']" :tamanho-da-tabela='90' :campos-visiveis="['nome', 'ano', 'placa']" :tamanho-da-fonte-do-body='23' class="componente-tabela">
            <ComponenteBotao texto-do-botao="VER DETALHES" class="botoes-tabela"><i class="bi bi-eye"></i></ComponenteBotao>
            <ComponenteBotao texto-do-botao="EDITAR" class="botoes-tabela"><i class="bi bi-pencil-square"></i></ComponenteBotao>
            <ComponenteBotao texto-do-botao="DELETAR" class="botoes-tabela"><i class="bi bi-trash"></i></ComponenteBotao>
        </ComponenteTabela>
    </div>
</template>

<style>
.tabela-de-carros{
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
}

.botoes-tabela{
    box-shadow: inset 0 0 10px #ffffff20;
    display: flex;
    font-size: 14px;
    margin: 2px 0;
    align-items: center;
    justify-content: center;
    height: 35px;
}

.botoes-tabela i{
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 16px;
}


.titulo-da-tabela{
    font-size: 30px;
    margin-top: 40px;
    margin-bottom: 20px;
    border-bottom: 1px solid #fff;
    transition: 1s;
}

.titulo-da-tabela:hover{
    color: #ffffff;
    text-shadow: 1px 1px 2px purple, 0 0 1em blue, 0 0 0.2em blueviolet;
}

.componente-tabela{
    transition: 1s;
}

.componente-tabela:hover{
    box-shadow: 0 0 10px #ffffff50;
}
</style>
