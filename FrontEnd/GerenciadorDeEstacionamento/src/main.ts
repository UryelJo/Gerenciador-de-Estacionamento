import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import { PrimeVue } from '@primevue/core'
import Lara from '@primevue/themes/lara'
import Tooltip from 'primevue/tooltip'
import { Estacionamento } from './models/Estacionamento'

const app = createApp(App)

app.use(router)

app.directive('tooltip', Tooltip);

app.use(PrimeVue,{theme:{
    preset: Lara
}})

app.provide('informacoesDoEstacionamento', new Estacionamento(0, ' ', ' ', 0, 0))
app.provide('logado', false)

app.mount('#app')
