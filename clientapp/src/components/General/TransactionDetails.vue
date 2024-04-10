<template>
    <q-dialog v-model="dialog">
        <q-card style="width: 90%;">
            <q-toolbar>
                <q-toolbar-title class="text-bold">Transaction Details</q-toolbar-title>

            </q-toolbar>
            <q-card-section class="q-py-sm text-bold text-h7">
                Short description of the transaction
            </q-card-section>

            <q-card-section class="flex q-py-sm">
                <div class="text-h7 text-grey">Date & Time</div>
                <q-space />
                <div class="text-h7 text-bold text-right">Aug 17, 2023 07:35 AM</div>
            </q-card-section>

            <q-card-section class="flex q-py-sm">
                <div class="text-h7 text-grey">Amount</div>
                <q-space />
                <div class="text-h7 text-bold text-right">-100</div>
            </q-card-section>

            <q-card-section class="flex bg-grey-2 q-mt-md">
                <div class="text-h7">Reference Number</div>
                <q-space />
                <div class="text-h7 text-bold text-right">123456</div>
            </q-card-section>
            <q-card-actions class="bg-grey-2 flex text-center justify-center q-py-md">
                <q-btn rounded label="Okay" no-caps color="blue-8" unelevated style="width: 90%;" @click="dialog = false" />
            </q-card-actions>
        </q-card>
    </q-dialog>
</template>

<script>
import { ref } from 'vue'
export default {
    setup() {
        const dialog = ref(false);

        const Show = () => {
            dialog.value = true;
        }

        return {
            dialog,
            Show
        }
    },
}
</script>