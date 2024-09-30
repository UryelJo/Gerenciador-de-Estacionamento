<script setup lang="ts">
  import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
  import { RouterLink, RouterView } from 'vue-router'
  import ComponenteBotao from './components/ComponenteBotao.vue';
  import { ref } from 'vue';

  let variavel = ref("")
  let variavel2 = ref
  let podeMostrarHelloWorld = ref(false);
</script>

<template>
  <div id="app">
    <aside class="sidebar">
      <div class="logo">
        <h1>VAIDERÉ.so</h1>
        <p>Nunca vá de Frente</p>
      </div>
      <div class="menu">
        <ComponenteBotao textoDoBotao="GERENCIAR CARROS"><font-awesome-icon icon="user" /></ComponenteBotao>
        <ComponenteBotao texto-do-botao="GERENCIAR FUNCIONÁRIOS"><font-awesome-icon icon="magnifying-glass" /></ComponenteBotao>
        <ComponenteBotao texto-do-botao="GERENCIAR PLANOS">❤️</ComponenteBotao>
        <ComponenteBotao texto-do-botao="ESTACIONAMENTO">😘</ComponenteBotao>
      </div>
    </aside>

    <main class="main-content">
      <header>
        
        <input type="text" placeholder="Pesquisar..." />
      </header>
      <section class="content">
      </section>
    </main>
  </div>
</template>

<style scoped>
/* Estilos de layout geral */


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

header {
  background-color: #d1d1d1;
  padding: 15px;
  box-sizing: border-box;
}

input[type="text"] {
  width: 50%;
  padding: 10px;
  font-size: 16px;
  border: 1px solid #ccc;
  border-radius: 5px;
}

.content {
  margin-top: 20px;
}

header{
  width: 1000px;

}
</style>
