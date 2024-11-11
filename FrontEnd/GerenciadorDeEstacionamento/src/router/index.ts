import { createRouter, createWebHistory } from 'vue-router'
import PaginaInicial from '@/views/Login/Login.vue';
import 'bootstrap-icons/font/bootstrap-icons.css';
import { inject } from 'vue';

let logado = inject('logado') as boolean;

const isLoggedIn = () => {
  return logado == true;
};

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'login',
      component: PaginaInicial,
    },
    {
      path: '/tela-inicial' ,
      name: 'Pagina Inicial',
      component: () =>  import('../views/PaginaInicialView.vue'),
      meta: { requiresAuth: true }
    },
    {
      path:'/gerenciar-carros' ,
      name: 'tela de gerenciamento de carros',
      component: () =>  import('../views/GerenciadorDeCarros/GerenciadorDeCarros.vue'), 
      meta: { requiresAuth: true }
    },
    {
      path:'/gerenciar-funcionarios',
      name: 'tela de gerenciamento de funcionarios',
      component: () =>  import('../views/GerenciadorDeFuncionarios/GerenciadorDeFuncionarios.vue'),
      meta: { requiresAuth: true }
    },
    {
      path: '/gerenciar-planos',
      name: 'tela de gerenciamento de planos',
      component: () => import('../views/GerenciadorDePlanos/GerenciadorDePlanos.vue'),
      meta: { requiresAuth: true }
    },
    {
      path:  '/gerenciar-estacionamento' ,
      name: 'tela de gerenciamento de estacionamento',
      component: () => import('../views/GerenciarEstacionamento/GerenciarEstacionamento.vue'),
      meta: { requiresAuth: true }
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (to.matched.some(record => record.meta.requiresAuth)) {
    if (!isLoggedIn()) {
      next({ path: '/' });
    } else {
      next();
    }
  } else {
    next();
  }
});

export default router
