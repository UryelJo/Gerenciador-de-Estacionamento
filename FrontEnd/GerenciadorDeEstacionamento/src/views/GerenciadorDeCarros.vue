<script setup lang="ts">
import ComponenteTabela from '@/components/ComponenteTabela.vue';
import axios from 'axios';

axios.get('http://localhost:3000/pessoas').then((response) => {
    console.log(response.data);
});

</script>

<template>
    <div class="teste">
        <h1>Gerenciador de Carros</h1>
        <ComponenteTabela :lista-de-objetos="[]" :headers="['almir', 'uryel', 'bola', 'almir', 'uryel', 'bola']" :tamanho-da-tabela='100' ></ComponenteTabela>
    </div>
</template>

<style>

.teste{
    padding: 10px;
}

</style>
