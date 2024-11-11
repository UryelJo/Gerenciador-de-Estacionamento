<script setup lang="ts">

import Card from 'primevue/card';
import InputText from 'primevue/inputtext';
import Button from 'primevue/button';
import { ref } from 'vue';
import FloatLabel from 'primevue/floatlabel';

const isCadastrar = ref<boolean>(false);
let login = ref<string>('');
let senha = ref<string>('');

function validarTamanhoDeCampos(){
    return (login.value.length > 10) && (senha.value.length > 6);
}

</script>

<template>
    <div class="login">
        <Card style="width: 25%; text-align: center; box-shadow: 0px 0px 50px 0.5px rgb(0, 0, 0);" v-if="!isCadastrar">
            <template #title>
                Para iniciar faça login
            </template>
            <template #content>
                <div style="display: flex; flex-direction: column; row-gap: 15px;">
                    <FloatLabel variant="on">
                        <InputText v-tooltip.left="'Email para poder acessar'" id="login" type="email" v-model="login" style="width: 100%;" />
                        <label for="login">Login</label>
                    </FloatLabel>
                    <FloatLabel variant="on">
                        <InputText v-tooltip.left="'Senha para poder acessar'" id="senha" type="password" v-model="senha" style="width: 100%;" />
                        <label for="senha">Senha</label>
                    </FloatLabel>
                </div>
            </template>
            <template #footer>
                <div style="gap: 20px; display: flex; justify-content: center;">
                    <Button label="Entrar" :disabled="!validarTamanhoDeCampos()" />
                    <Button label="Cadastrar" severity="secondary" @click="isCadastrar = true" />
                </div>
            </template>
        </Card>

        <Card v-if="isCadastrar" style="width: 30%; text-align: center;">
            <template #title>
                Almir
            </template>
        </Card>
    </div>

</template>

<style>

.login{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    
}

</style>