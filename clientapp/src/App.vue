<template>
  <router-view/>
</template>

<script>
import { ref } from 'vue'

export default {
  name: 'App',

  components: {
  },

  setup () {
    return {
      leftDrawerOpen: ref(false)
    }
  }
}
</script>
