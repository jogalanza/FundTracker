<template>
  <q-layout class="main-layout" view="hHh lpR fFf">
    <!-- <q-header class="app-header" elevated >
      
    </q-header> -->

    <q-page-container style="padding-bottom: 0px; height: calc(100vh - 70px);">
      <router-view v-slot="{ Component, route }">

        <!-- <transition name="animate__fadeInDown">
          <component :is="Component" :key="route.path" />
        </transition> -->

        <transition name="fade" mode="out-in">
          <component :is="Component" :key="route.path" />
        </transition>
      </router-view>
    </q-page-container>

    <q-footer class="bg-blue-6">
      <q-btn-group class="footer-menu" spread style="height: 70px;">
        <q-btn label="Home" icon="o_home" stack no-caps @click="router.push({ name: 'Home' })" />
        <q-btn label="Inbox" icon="o_email" stack no-caps @click="router.push({ name: 'Inbox' })" />
        <!-- <q-btn label="Dashboard" icon="o_email" stack no-caps @click="router.push({ name: 'Inbox' })" /> -->
        <q-btn label="Transactions" icon="o_receipt_long" stack no-caps @click="router.push({ name: 'Transactions' })" />
        <q-btn label="Profile" icon="o_account_circle" stack no-caps @click="router.push({ name: 'Profile' })" />
      </q-btn-group>
    </q-footer>
  </q-layout>
</template>

<style lang="scss">
.main-layout {
  .footer-menu {
    .q-btn {
      font-size: 0.8em;
    }

  }
}
</style>

<script>
import { ref } from 'vue'
import { useRouter } from 'vue-router';

export default {
  name: 'LayoutDefault',

  components: {

  },

  setup() {
    const router = useRouter();

    return {
      leftDrawerOpen: ref(false),
      router
    }
  }
}
</script>
