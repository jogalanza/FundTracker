<template>
  <q-card flat class="home-view">
    <q-toolbar class="q-py-md bg-grey-2" style="height: 60px; position: sticky; top: 0px; z-index: 1;">
      <q-toolbar-title class="ellipsis text-bold">
        Hello!
      </q-toolbar-title>

      <q-space />

      <q-btn id="help-btn" rounded label="Help" color="blue-6" unelevated dense padding="xs sm" style="font-weight: bold;" />
    </q-toolbar>

    <q-toolbar class="bg-grey-2" style="position: sticky; top: 60px; z-index: 1">
      <q-card class="bg-blue-6 text-white" style="width: 100%;">
        <q-card-section>
          <q-list>
            <q-item-label>
              <span>Available Balance</span>
              <q-icon :name="hideValue ? 'o_visibility_off' : 'o_visibility'" size="sm" class="q-ml-md" @click="hideValue = !hideValue" />
            </q-item-label>
            <q-item class="q-px-none">
              <q-item-section>
                <div class="text-h4 text-bold" style="font-family: gotham_roundedbold;">{{ balance }}</div>
              </q-item-section>
              <q-item-section side>
                <q-btn rounded icon="o_add" label="New Entry" color="white" text-color="primary" padding="xs sm" no-caps unelevated />
              </q-item-section>
            </q-item>
          </q-list>
        </q-card-section>
      </q-card>
    </q-toolbar>

    <q-card flat class="bg-grey-2">
      <q-card-section class="row">
        <div v-for="(m, i) in menuItems" :key="i" class="col-3 q-pa-sm text-center">
          <q-btn class="home-btn" :icon="m.icon" stack :label="m.label" no-caps text-color="blue-6" flat />
        </div>
      </q-card-section>
    </q-card>

    <q-card flat>
      <q-card-section class="text-bold text-h6 q-py-sm">Incoming Due Dates</q-card-section>
      <q-card-section class="q-pt-none q-pb-md">
        <q-virtual-scroll :items="dueDates" virtual-scroll-horizontal v-slot="{ item, index }">
          <q-card :key="index" class="q-ma-sm q-mr-md">
            <q-card-section class="text-center text-bold text-grey-6">
              <div class="doc-card-title text-left">
                {{ item.label }}
              </div>

            </q-card-section>
            <q-card-section class="text-bold text-h5 text-center">
              {{ item.dueDate }}
            </q-card-section>
          </q-card>
        </q-virtual-scroll>
      </q-card-section>
    </q-card>

    <q-card flat>
      <q-card-section class="text-bold text-h6 q-py-sm">Incoming Due Dates</q-card-section>
      <q-card-section class="q-pt-none q-pb-md">
        <q-virtual-scroll :items="dueDates" virtual-scroll-horizontal v-slot="{ item, index }">
          <q-card :key="index" class="q-ma-sm q-mr-md">
            <q-card-section class="text-center text-bold text-grey-6">
              <div class="doc-card-title text-left">
                {{ item.label }}
              </div>

            </q-card-section>
            <q-card-section class="text-bold text-h5 text-center">
              {{ item.dueDate }}
            </q-card-section>
          </q-card>
        </q-virtual-scroll>
      </q-card-section>
    </q-card>


  </q-card>
</template>

<style lang="scss">
.home-view {
  height: 100%;
  overflow: auto;

  .home-btn {
    .q-btn__content {
      .q-icon {
        font-size: 2.4rem;
      }
    }
  }

  #help-btn{
    font-size: 0.8em;
    font-family: 'gotham_roundedbold';
  }
}
</style>

<script>
import { computed, ref } from 'vue'
import { useRouter } from 'vue-router';

export default {
  setup() {
    const router = useRouter();
    const menuItems = ref([
      {
        label: "Category", icon: "o_fact_check", action: () => {
          router.push({ name: "Category" });
        }
      },
      {
        label: "Income", icon: "o_paid", action: () => {

        }
      },
      {
        label: "Expenses", icon: "o_shopping_basket", action: () => {

        }
      },
      {
        label: "Bills", icon: "o_payment", action: () => {

        }
      },
      {
        label: "Loans", icon: "o_real_estate_agent", action: () => {

        }
      }
    ]);
    const hideValue = ref(false);

    const balance = computed(() => {
      if (hideValue.value){
        return "P ....."
      }
      return `P ${(new Intl.NumberFormat().format(1250))}`;
    });

    const dueDates = ref([
      { label: "PLDT Home", dueDate: "11-Aug-2023" },
      { label: "Meralco", dueDate: "11-Aug-2023" },
      { label: "HOA", dueDate: "11-Aug-2023" }
    ])

    return {
      hideValue,
      menuItems,
      balance,
      dueDates
    }
  },
}
</script>
