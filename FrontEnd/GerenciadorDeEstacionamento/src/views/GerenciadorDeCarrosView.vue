<script setup lang="ts">
import ComponenteTabela from '@/components/ComponenteTabela.vue';
import { Pessoa } from '@/models/Pessoa';
import { ref } from 'vue';

const uryel = ref<Pessoa[]>([
  new Pessoa(1, "Uryel", "", 12)
])
</script>

<template>
    <div class="teste">
        <h1>Gerenciador de Carros</h1>
        <ComponenteTabela :lista-de-objetos="uryel" :headers="['almir', 'uryel', 'bola', 'francisco']" :tamanho-da-tabela='100' ></ComponenteTabela>
    </div>
</template>

<style>

.teste{
    padding: 10px;
}

</style>
