<script setup lang="ts">
    defineProps<{
        textoDoBotao: string,
        iconeDoBotao: string,
        funcaoDoBotao: () => void
    }>()
</script>

<template >
    <button class="botao">
        {{iconeDoBotao}}
        {{textoDoBotao}}
    </button>
</template>