<script setup lang="ts">
    defineProps<{
        textoDoBotao: string
    }>()
</script>

<template>
    <button class="botao">
        <div class="icone">
            <slot></slot>
        </div>
        <p>{{textoDoBotao}}</p> 
    </button>
</template>

<style>
.botao{
    background-color: #fff;
    align-items: center;
    justify-content: right;
    border: none;
    cursor: pointer;
    font-size: 14px;
    display: flex;
    box-shadow: 2px 2px 2px 2px #888888;
    text-shadow: rgb(0, 0, 0, 40%) 2px 3px 4px ;
    border-radius: 5px;
    width: 100%;
    padding: 15px;
    height: 75px;
    transition: 0.2s;
}

.icone{
    position: absolute;
    padding-right: 245px;
    font-size: 30px;
    transition: 0.2s;
}

.botao:hover{
    background-color: #bebebe;
    font-size: 16px;
}
.botao:hover>.icone{
    font-size: 35px;
    text-shadow: 1px 1px 2px purple, 0 0 1em blue, 0 0 0.2em blueviolet;
}
</style>