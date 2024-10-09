<script setup lang="ts">
import ComponenteTabela from '@/components/ComponenteTabela.vue';
import { Pessoa } from '@/models/Pessoa';
import axios from 'axios';
import { ref } from 'vue';

axios.get('http://localhost:3000/pessoas').then((response) => {
    console.log(response.data);
});

</script>

<template>
    <div class="teste">
        <h1>Gerenciador de Carros</h1>
        <ComponenteTabela :lista-de-objetos="[]" :headers="['almir', 'uryel', 'bola', 'francisco']" :tamanho-da-tabela='100' ></ComponenteTabela>
    </div>
</template>

<style>

.teste{
    padding: 10px;
}

</style>
