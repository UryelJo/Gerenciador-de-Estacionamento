<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import {ref } from 'vue';
import Button from 'primevue/button';
import Drawer from 'primevue/drawer';

const barraDePesquisaAtiva = ref<boolean>(false);
const visivel = ref<boolean>(true);
</script>

<template>
  <div id="app">
    <Drawer v-model:visible="visivel" class="sidebar">
        <template #header>
          <router-link to="/">
            <div class="logo" @click="barraDePesquisaAtiva = false">
              <h1>VAIDERÉ.so</h1>
              <p>Nunca vá de Frente</p>
            </div>
          </router-link>
        </template>
        <div class="menu">
          <RouterLink to="/gerenciar-carros">
            <Button label="GERENCIAR CARROS" icon="bi bi-car-front-fill" iconPos ="left" text raised severity="secondary" @click = "barraDePesquisaAtiva = true"/>
          </RouterLink>
          <RouterLink to="/gerenciar-funcionarios">
            <Button label="GERENCIAR FUNCIONÁRIOS" icon="bi bi-people-fill" iconPos ="left" text raised severity="secondary" @click = "barraDePesquisaAtiva = true"/>
          </RouterLink>
          <RouterLink to="/gerenciar-planos">
            <Button label="GERENCIAR PLANOS" icon="bi bi-list-check" iconPos ="left" text raised severity="secondary" @click = "barraDePesquisaAtiva = true"/>
          </RouterLink>
          <RouterLink to="/gerenciar-estacionamento">
            <Button label="GERENCIAR ESTACIONAMENTO" icon="bi bi-p-square-fill" iconPos ="left" text raised severity="secondary" @click = "barraDePesquisaAtiva = true"/>
          </RouterLink>
        </div>
    </Drawer>
    <Button icon="bi bi-list" @click="visivel = !visivel" style="position: absolute; top: 10px; left: 10px;"/>

    <main class="main-content">
      <section class="content">
        <router-view />
      </section>
    </main>
  </div>
</template>
<style scoped>

#app {
  display: flex;
  padding: 0;
  width: 100%;
}

.p-drawer{
  background-color: rgb(0, 0, 0) !important;
}

.logo {
  text-align: center;
  color: rgb(255, 255, 255);
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
