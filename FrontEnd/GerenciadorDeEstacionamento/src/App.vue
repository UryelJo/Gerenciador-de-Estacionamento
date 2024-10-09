<script setup lang="ts">
import { RouterLink, RouterView, useRoute } from 'vue-router'
import ComponenteBotao from './components/ComponenteBotao.vue';
import { computed, ref } from 'vue';

const barraDePesquisaAtiva = ref<boolean>(false);
</script>

<template>
  <div id="app">
    <aside class="sidebar">
      <div class="logo">
        <h1>VAIDERÉ.so</h1>
        <p>Nunca vá de Frente</p>
      </div>
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
          <label for="inputDePesquisa" class="bi bi-search" style="margin-left: 4px; font-size: 25px; cursor: pointer;"></label>
          <input id="inputDePesquisa" type="text" placeholder="Pesquisar..." />
        </div>
      </header>
      <section>
        <router-view />
      </section>
    </main>
  </div>
</template>

<style scoped>
/* Sidebar */
.sidebar {
  width: 357px;
  height: 100vh;
  background-color: #d1d1d1;
  padding: 20px;
  box-sizing: border-box;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.logo {
  text-align: center;
  margin-bottom: 20px;
  color: black;
  border-radius: 5px;
  border: 0.5px solid black;
  padding: 20px 60px 20px 60px;
  background-color: #888888;
}

.menu {
  display: flex;
  flex-direction: column;
  gap: 10px;
  width: 100%;
}
/* Main content */
.main-content {
  padding-top: 20px;
  box-sizing: border-box;
  height: 100vh;
}

.barra-de-pesquisa{
  width: 100%;
  font-size: 20px;
  color: black;
  display: flex;
  border-radius: 5px;
  align-items: center;
  justify-content: space-between;
  background-color: #888888;
  padding-left: 10px;
  box-shadow: 2px 2px 2px 2px #888888;
  border: 0.5px solid black;
  cursor: pointer;
}

a{
  text-decoration: none;
  color: black;
}

header {
  background-color: #d1d1d1;
  padding: 15px;
  display: flex;
  justify-content: space-between;
  width: 945px;
}

input[type="text"] {
  width: 95%;
  padding: 10px;
  font-size: 16px;
}

</style>
