import { createRouter, createWebHistory } from 'vue-router'
import PaginaInicial from '../views/PaginaInicialView.vue'
import 'bootstrap-icons/font/bootstrap-icons.css';

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Pagina inicial',
      component: PaginaInicial
    },
    {
      path: '/gerenciar-carros',
      name: 'tela de gerenciamento de carros',
      component: () => import('../views/GerenciadorDeCarrosView.vue')
    },
    {
      path: '/gerenciar-funcionarios',
      name: 'tela de gerenciamento de funcionarios',
      component: () => import('../views/GerenciadorDeFuncionarios.vue')
    }
  ]
})

export default router
