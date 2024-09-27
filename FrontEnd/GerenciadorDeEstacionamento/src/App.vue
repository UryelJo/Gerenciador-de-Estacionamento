<script setup lang="ts">
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
import ComponenteBotao from './components/ComponenteBotao.vue';
import { ref } from 'vue';

let variavel = ref("")
let variavel2 = ref("")
let podeMostrarHelloWorld = ref(false);

</script>

<template>
  <header>
    <div class="wrapper">
      <input v-model="variavel"  type="text" />
      <input v-model="variavel2" type="text">
      <font-awesome-icon icon="car" />
      <button v-on:click="podeMostrarHelloWorld = true" type="submit"> enviar</button>
    </div>
    <HelloWorld v-if="podeMostrarHelloWorld" :msg="variavel" :name="variavel2"/>
  </header>

  <RouterView />
</template>

<style scoped>
header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
