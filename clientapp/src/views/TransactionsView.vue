<template>
  <q-card flat class="transactions-view">
    <q-toolbar class="q-py-md bg-blue-6 text-white" style="height: 50px; position: sticky; top: 0px; z-index: 1;">
      <q-toolbar-title class="text-bold text-center">
        Transaction History
      </q-toolbar-title>
    </q-toolbar>

    <q-toolbar class="q-py-md bg-grey-2" style="height: 30px; position: sticky; top: 0px; z-index: 1;">
      <q-toolbar-title class="sub-toolbar" style="flex: auto">
        Transactions as of Aug 16, 2023
      </q-toolbar-title>

      <q-space />

      <q-btn rounded icon="o_filter_alt" color="blue-6" flat unelevated dense padding="xs sm" style="font-weight: bold;" />
    </q-toolbar>

    <q-virtual-scroll style="height: calc(100% - 100px);" :items="items" separator v-slot="{ item, index }">

      <q-item :key="'b' + index" dense clickable class="q-py-sm">
        <q-item-section>
          <q-item-label class="text-bold">
            <div class="main-item flex">
              <div class="text-bold ellipsis" style="max-width: 65%; line-height: 24px;">{{ item.label }}</div>
              <q-space />
              <div class="text-bold ellipsis" style="line-height: 24px;">{{ item.amount }}</div>
              <q-icon name="o_more_horiz" size="sm" class="q-ml-md" color="blue-6" @click="details.Show(item)" />
            </div>            
          </q-item-label>
          <q-item-label class="ellipsis" caption style="max-width: 65%; ">
            {{ item.label }}
          </q-item-label>
        </q-item-section>
        <!-- <q-item-section side top>
          <q-btn icon="o_more_horiz" flat color="blue-6" round />
        </q-item-section> -->
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
      { label: "Gasoline"},
      { label: "Gasoline"},
      { label: "Gasoline"},
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
