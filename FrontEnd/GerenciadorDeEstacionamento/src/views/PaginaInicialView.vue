<script setup lang="ts">

const nomeDoUsuario = 'Usuario';
</script>

<template>
    <div class="header">Olá {{ nomeDoUsuario }} </div>
</template>

<style>
.header {
    top: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    color: rgb(255, 255, 255);
    width: 100%;
    font-size: 40px;
    height: 100%;
}

</style>