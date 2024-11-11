<script setup lang="ts">
import {RouterLink, RouterView} from 'vue-router'
import {inject, ref} from 'vue';
import Button from 'primevue/button';
import Drawer from 'primevue/drawer';
import Dialog from 'primevue/dialog';

const barraDePesquisaAtiva = ref<boolean>(false);
const visivel = ref<boolean>(false);
const dialogEdicaoVisivel = ref<boolean>(false);
let logado = inject('logado') as Boolean;

</script>

<template>
  <div id="app">

    <Dialog v-model:visible="dialogEdicaoVisivel" header="Editar Informações" modal closable resizable :style="{ width: '700px' }" baseZIndex="10000" :draggable="false">
      <p>Em construção</p>
    </Dialog>

    <Drawer v-model:visible="visivel" style="  background-color: rgba(39, 39, 42, 0.384); backdrop-filter: blur(5px); border: none;">
        <template #header>
          <router-link to="/">
            <div class="logo" @click="barraDePesquisaAtiva = false" >
              <h1>VAIDERÉ.so</h1>
              <p>Nunca vá de Frente</p>
            </div>
          </router-link>
        </template>
        <div class="menu">
          <RouterLink to="/gerenciar-estacionamento">
            <Button label="GERIR ESTACIONAMENTO" icon="bi bi-p-square-fill" iconPos ="left" severity="secondary" style="width: 100%; justify-content: left;"  />
          </RouterLink>
          <RouterLink to="/gerenciar-funcionarios">
            <Button label="FUNCIONÁRIOS" icon="bi bi-people-fill" iconPos ="left" severity="secondary" style="width: 100%; justify-content: left;" />
          </RouterLink>
          <RouterLink to="/gerenciar-planos">
            <Button label="PLANOS" icon="bi bi-list-check" iconPos ="left" severity="secondary" style="width: 100%; justify-content: left;" />
          </RouterLink>
          <RouterLink to="/gerenciar-carros">
            <Button label="GERENCIAR CARROS" icon="bi bi-car-front-fill" iconPos ="left" severity="secondary" style="width: 100%; justify-content: left;" />
          </RouterLink>
        </div>
        <template #footer>
          <div class="menu">
            <Button label="Editar Informações" @click="dialogEdicaoVisivel = true" icon="bi bi-pencil-square" iconPos ="left" style="width: 70%; font-size: 14px;" />
          </div>
        </template>
    </Drawer>
    <Button icon="bi bi-list" @click="visivel = !visivel" v-if="logado" style="position: absolute; top: 10px; left: 10px;"/>

    <main class="main-content">
      <section class="content">
        <router-view />
      </section>
    </main>
  </div>
</template>
<style>

#app {
  display: flex;
  padding: 0;
  width: 100%;
  height: 100%;
}

.logo {
  text-align: center;
  color: white;
  transition: 0.2s;
}

p{
  font-size: 14px;
  transition: 0.2s;
}

h1{
  font-size: 30px;
  margin: 0;
  transition: 0.2s;
}

.logo:hover>h1 {
  font-size: 32px;
  text-shadow: 1px 1px 2px purple, 0 0 1em blue, 0 0 0.2em blueviolet;
}

.logo:hover> p{
  font-size: 15px;
  text-shadow: 1px 1px 2px purple, 0 0 1em blue, 0 0 0.2em blueviolet;
} 

.menu {
  display: flex;
  flex-direction: column;
  gap: 7px;
}

.main-content {
  box-sizing: border-box;
  flex: 1;
  display: flex;
  height: 100%;
  width: 100%;
  flex-direction: column;
}

.content{
  width: 100%;
  height: 100%;
  overflow-y: auto
}

a{
  text-decoration: none;
}

a:hover{
  background-color: transparent;
}


</style>
