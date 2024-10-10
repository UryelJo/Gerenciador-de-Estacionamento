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
    width: 100%;
    border: none;
    display: flex;
    padding: 7px;
    font-size: 14px;
    gap: 15px;
    cursor: pointer;
    transition: 0.2s;
    border-radius: 5px;
    align-items: center;
    justify-content: left;
    background-color: #9196d800;
    color: white;
    text-shadow: rgb(0, 0, 0, 40%) 2px 3px 4px;
    border: 1px solid #ffffff00;
}
.icone{
    font-size: 25px;
    transition: 0.2s;
}

.botao:hover{
    background-color: #804bc5;
    box-shadow: inset 3px 3px 3px 0px #ffffff25,
                inset -3px -3px 3px 0px #00000025;
    border: 1px solid #ffffff25;
}


.botao:hover>.icone{
    text-shadow: 1px 1px 2px purple, 0 0 1em blue, 0 0 0.2em blueviolet;
}
</style>