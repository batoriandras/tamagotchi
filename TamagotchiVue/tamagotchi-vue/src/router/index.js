import { createRouter, createWebHistory } from 'vue-router'
import LoginView from '../views/LoginView.vue'
import SignupView from '../views/SignupView.vue'
import PetView from '../views/PetView.vue'
import AccountView from '../views/AccountView.vue'
import CreateView from '../views/CreateView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'login',
      meta: {requiresAuth:false},
      component: LoginView
    },
    {
      path: '/signup',
      name: 'signup',
      meta: {requiresAuth:false},
      component: SignupView
    },
    {
      path: '/pet',
      name: 'pet',
      meta: {requiresAuth:true},
      component: PetView
    },
    {
      path: '/account',
      name: 'account',
      meta: {requiresAuth:true},
      component: AccountView
    },
    {
      path: '/create',
      name: 'create',
      meta: {requiresAuth:true},
      component: CreateView
    }
  ]
})

export default router
function authguard(to,from,next){
if(!to.meta.requiresAuth){
  next();
}
else{
  if(localStorage.getItem('token') != null){
    next();
  }
  else{
    next({name:"login"});
  }
}
}
router.beforeEach(authguard);

