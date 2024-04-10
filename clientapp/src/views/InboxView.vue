<template>
  <q-card flat class="transactions-view">
    <q-toolbar class="q-py-md bg-blue-6 text-white" style="height: 50px; position: sticky; top: 0px; z-index: 1;">
      <q-toolbar-title class="text-bold text-center">
        Inbox
      </q-toolbar-title>
    </q-toolbar>

    <q-toolbar class="q-py-md bg-grey-2" style="height: 30px; position: sticky; top: 0px; z-index: 1;">
      <q-toolbar-title class="sub-toolbar" style="flex: auto">
        Latest
      </q-toolbar-title>

      <q-space />

      <q-btn rounded icon="o_filter_alt" color="blue-6" flat unelevated dense padding="xs sm" style="font-weight: bold;" />
    </q-toolbar>

    <q-virtual-scroll style="height: calc(100% - 100px);" :items="items" separator v-slot="{ item, index }">

      <q-item :key="'b' + index" dense clickable class="q-py-sm">
        <q-item-section avatar style="min-width: 0px;">
          <q-icon name="o_email"></q-icon>
        </q-item-section>
        <q-item-section>

          <q-item-label class="text-bold text-h7 ellipsis">{{ item.label }}
          </q-item-label>
          <q-item-label class="ellipsis" caption style="max-width: 65%; ">
            {{ item.label }}
          </q-item-label>
        </q-item-section>
        <q-item-section side top>
          <q-item-label caption>10 minutes ago</q-item-label>
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
import { defineAsyncComponent, ref } from 'vue'
export default {
  components: {
    TransactionDetails: defineAsyncComponent(() => import("../components/General/TransactionDetails.vue"))
  },
  setup() {
    const details = ref(null);
    const items = ref([
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline" },
      { label: "Gasoline" },
      { label: "Gasoline" },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
      { label: "Gasoline. A verly long description it hink. should be more longer", amount: 1200 },
    ])

    return {
      details,
      items
    }
  },
}
</script>
