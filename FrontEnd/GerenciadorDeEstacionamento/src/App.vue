<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import ComponenteBotao from './components/ComponenteBotao.vue';
import {ref } from 'vue';

const barraDePesquisaAtiva = ref<boolean>(false);
</script>

<template>
  <div id="app">
    <aside class="sidebar">
      <router-link to="/">
        <div class="logo" @click="barraDePesquisaAtiva = false">
          <h1>VAIDERÉ.so</h1>
          <p>Nunca vá de Frente</p>
        </div>
      </router-link>
      <div class="menu">
        <RouterLink to="/gerenciar-carros">
          <ComponenteBotao texto-do-botao="GERENCIAR CARROS" @click = "barraDePesquisaAtiva = true"><i class="bi bi-car-front-fill"></i></ComponenteBotao>
        </RouterLink>
        <RouterLink to="/gerenciar-funcionarios" active-class="active">
          <ComponenteBotao texto-do-botao="GERENCIAR FUNCIONÁRIOS" @click = "barraDePesquisaAtiva = true"><i class="bi bi-people-fill"></i></ComponenteBotao>
        </RouterLink>
        <RouterLink to="/gerenciar-planos">
          <ComponenteBotao texto-do-botao="GERENCIAR PLANOS" @click = "barraDePesquisaAtiva = true"><i class="bi bi-list-check"></i></ComponenteBotao>
        </RouterLink>
        <RouterLink to="/gerenciar-estacionamento">
          <ComponenteBotao texto-do-botao="GERENCIAR ESTACIONAMENTO" @click = "barraDePesquisaAtiva = true"><i class="bi bi-p-square-fill"></i></ComponenteBotao>
        </RouterLink>
      </div>
    </aside>

    <main class="main-content">
      <header v-if="barraDePesquisaAtiva">
        <div class="barra-de-pesquisa">
          <label for="inputDePesquisa" class="bi bi-search" style="
          font-size: 25px;
          cursor: pointer;
          "></label>
          <input id="inputDePesquisa" type="text" placeholder="Pesquisar..." class="input" />
        </div>
      </header>
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
  height: 100vh;
}

.sidebar {
  width: 305px;
  height: 100vh;
  background-color: #282828;
  padding: 20px;
  box-sizing: border-box;
  display: flex;
  flex-direction: column;
  align-items: center;
  box-shadow: 3px 0px 3px 0px #00000025;
  transition: 0.6s;
}

.sidebar:hover {
  box-shadow: 1px 0px 50px 0px #ffffff10;
}

.logo {
  text-align: center;
  margin-bottom: 20px;
  color: rgb(255, 255, 255);
  border-radius: 5px;
  padding: 20px 60px 20px 60px;
  transition: 0.2s;
}

.input{
  width: 100%;
  padding: 10px;
  font-size: 16px;
  cursor: pointer;
  border-radius: 10px;
  border: 1px solid #ffffff00;
  transition: 0.2s;
}

.input:focus{
  border: inset 1px solid #ffffff25;
  outline: none;
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
  gap: 10px;
  width: 100%;
}

.main-content {
  box-sizing: border-box;
  flex: 1;
  display: flex;
  flex-direction: column;
}

.barra-de-pesquisa{
  font-size: 20px;
  color: rgb(255, 255, 255);
  display: flex;
  align-items: center;
  gap: 10px;
  padding: 10px;
  border: 1px solid #ffffff00;
  border-radius: 10px;
  justify-content: space-between;
  background-color: #282828;
  box-shadow:  3px 0px 3px 0px #00000025;
  cursor: pointer;
  transition: 0.2s;
}

.barra-de-pesquisa:hover{
  transition: 0.2s;
  background-color: #282828;
  background-color: #804bc5;
  box-shadow: inset 3px 3px 3px 0px red
                inset -3px -3px 3px 0px red;
  border: 1px solid #ffffff25;
  box-shadow: 1px 0px 50px 0px #ffffff20;
  
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

header {
  display: flex;
  justify-content: center;
  padding-top: 10px;
  margin-right: 10px
}

</style>
