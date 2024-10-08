<script setup lang="ts">
    defineProps<{
        listaDeObjetos: Object[];
        headers: string[];
        tamanhoDaTabela: number;
    }>()
</script>

<template>
    <table :style="{width: tamanhoDaTabela + '%'}">
        <thead>
            <tr>
                <th v-for = "textoDoHeader in headers"> {{textoDoHeader}}</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="elemento in listaDeObjetos">
                <slot id="leftSide"></slot>
                <td v-for="valorDoElemento in elemento">{{valorDoElemento}}</td>
                <slot id="rightSide"></slot>
            </tr>
        </tbody>
    </table>

</template>

<style>
th , td {
    padding: 10px;
    border: 1px solid #ccc;
}

</style>