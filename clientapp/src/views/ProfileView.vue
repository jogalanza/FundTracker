<template>
  <q-card flat square class="transactions-view">
    <!-- <q-toolbar class="q-py-md bg-blue-6 text-white" style="height: 50px; position: sticky; top: 0px; z-index: 1;">
      <q-toolbar-title class="text-bold text-center">
        Profile
      </q-toolbar-title>
    </q-toolbar> -->

    <q-toolbar class="q-py-md q-pr-none bg-blue-6" style="position: sticky; top: 0px; z-index: 1;">
      <q-list style="width: 100%">
        <q-item class="text-white" clickable>
          <q-item-section avatar>

          </q-item-section>
          <q-item-section>
            <q-item-label class="text-bold">[First Name] [Last Name]</q-item-label>
            <q-item-label caption class="text-white">firstname.lastname@email.com</q-item-label>
            <q-item-label caption class="text-white">09XX XXX XXXX</q-item-label>
          </q-item-section>
          <q-item-section side>
            <q-icon name="o_chevron_right" round flat color="white" />
          </q-item-section>
        </q-item>

      </q-list>
    </q-toolbar>

    <q-virtual-scroll style="height: calc(100% - 100px);" :items="items" separator v-slot="{ item, index }" class="bg-blue-6 text-white">

      <q-item :key="'b' + index" clickable class="q-py-sm" @click="item.action">
        <q-item-section avatar style="min-width: 0px;">
          <q-icon :name="item.icon ?? 'o_email'"></q-icon>
        </q-item-section>
        <q-item-section>

          <q-item-label class="text-bold ellipsis">{{ item.label }}
          </q-item-label>
        </q-item-section>
        <q-item-section side>
          <q-icon name="o_chevron_right" round flat color="white" />
        </q-item-section>
      </q-item>
    </q-virtual-scroll>

    <TransactionDetails ref="details" />
  </q-card>
</template>

<style lang="scss">
.transactions-view {
  height: 100%;
  overflow: auto;

  .home-btn {
    .q-btn__content {
      .q-icon {
        font-size: 2.4rem;
      }
    }

  }
}
</style>

<script>
import { defineAsyncComponent, ref } from 'vue';
import { useRouter } from "vue-router";

export default {
  components: {
    TransactionDetails: defineAsyncComponent(() => import("../components/General/TransactionDetails.vue"))
  },
  setup() {
    const router = useRouter();
    const details = ref(null);
    const items = ref([
      {
        label: "Workspaces", icon: "o_workspace_premium", action: () => {

        }
      },
      {
        label: "Help", icon: "o_help_outline", action: () => {

        }
      },
      {
        label: "Settings", icon: "o_settings", action: () => {

        }
      },
      {
        label: "Log Out", icon: "o_logout", action: () => {
          LogOut();
        }
      },
    ]);

    const LogOut = () => {
      //TODO: remove cookies, etc.
      router.push({name: "Login"})
    }

    return {
      details,
      items,
      LogOut
    }
  },
}
</script>
