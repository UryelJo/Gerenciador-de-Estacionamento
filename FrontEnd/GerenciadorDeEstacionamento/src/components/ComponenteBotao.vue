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
    font-size: 16px;
    display: flex;
    text-shadow: rgb(0, 0, 0, 40%) 2px 3px 4px ;
    border-radius: 5px;
    width: 100%;
    padding: 15px;
    height: 75px;
    transition: 0.2s;
}

.botao:hover{
    background-color: #bebebe;
    font-size: large;
}
.botao:active{
    background-color: cornsilk;
}
.icone{
    position: absolute;
    padding-right: 245px;
}
</style>