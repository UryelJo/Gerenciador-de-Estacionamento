<script setup lang="ts">
    defineProps<{
        headers: string[];
        tamanhoDaTabela: number;
        tamanhoDaFonteDoBody: number;
        listaDeObjetos: Object[];
        camposVisiveis: string[];
    }>()
</script>

<template>
    <table :style="{width: tamanhoDaTabela + '%'}">
        <thead>
            <tr>
                <th class="estilizacao-tabela" v-for="(textoDoHeader, index) in headers" :key="index"> {{ textoDoHeader }}</th>
            </tr>
        </thead>
        <tbody>
            <tr :style="{fontSize: tamanhoDaFonteDoBody + 'px'}"  v-for="(elemento, index) in listaDeObjetos" :key="index">
                <td class="estilizacao-tabela"v-for="(campo, index) in camposVisiveis" :key="index">{{(elemento as any)[campo]}}</td>
                <td class="estilizacao-tabela">
                    <slot></slot>
                </td>
            </tr>
        </tbody>
    </table>

</template>

<style>

.estilizacao-tabela{
    padding: 10px;
    border: 1px solid #ccc;
    color: #fff;
    text-align: center;
}

table {
    border-collapse: collapse;
    width: 100%;
}

th {
    font-size: 20px;
    background-color: #333;
}

</style>