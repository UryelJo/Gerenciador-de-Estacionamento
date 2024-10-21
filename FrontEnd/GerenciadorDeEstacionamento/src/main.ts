import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import { PrimeVue } from '@primevue/core'
import Lara from '@primevue/themes/lara'
import Tooltip from 'primevue/tooltip'

const app = createApp(App)

app.use(router)

app.directive('tooltip', Tooltip);

app.use(PrimeVue,{theme:{
    preset: Lara
}})

app.mount('#app')
