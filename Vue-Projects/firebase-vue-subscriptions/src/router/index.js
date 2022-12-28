import Vue from 'vue'
import VueRouter from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AccountView from '../views/Account.vue'
import SignInView from '../views/Signin.vue'
import { getCurrentUser } from '../firebase'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/account',
    name: 'account',
    componet: AccountView,
    meta: {
      requiresAuth: true
    }
  },
  {
    path: '/signin',
    name: 'signin',
    component: SignInView,
    meta: {
      guestOnly: true
    }
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})


router.beforeEach(async (to, from, next) => {
  const requiresAuth = to.matched.some(record => record.meta.requiresAuth)
  const isGuestOnly = to.matched.some(record => record.meta.guestOnly)

  const currentUser = await getCurrentUser()

  if(requiresAuth && !currentUser) {
    next('/signin')
  } else if (isGuestOnly && currentUser) {
    next('/account')
  } else {
    next()
  }
})

export default router
