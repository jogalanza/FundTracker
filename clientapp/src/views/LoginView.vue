<template>
  <q-card flat square class="bg-blue-6 login-view">
    <q-card-section class="text-bold text-h4 text-center text-white">

    </q-card-section>
    <q-card-section class="text-bold text-h4 text-center text-white">
      FundGo
    </q-card-section>
    <q-card-section>
      <q-list style="width: 100%">
        <q-item class="text-white">
          <q-item-section>
            <q-input v-model="creds.username" rounded outlined bg-color="white" dense input-style="margin-left:8px; margin-right: 24px; font-family: 'gotham_roundedbold'" input-class="text-blue-8"
              placeholder="Email">
              <template v-slot:prepend>
                <q-icon name="o_mail" />
              </template>
            </q-input>
          </q-item-section>
        </q-item>
        <q-item class="text-white q-mb-md">
          <q-item-section>
            <q-input v-model="creds.pw" rounded outlined bg-color="white" dense type="password" input-style="margin-left:8px; margin-right: 24px; font-family: 'gotham_roundedbold'"
              input-class="text-blue-8" placeholder="Password" bottom-slots class="q-mb-md">
              <template v-slot:prepend>
                <q-icon name="o_lock" />
              </template>
              <template v-slot:hint>
                <div class="flex q-pb-md">
                  <q-checkbox id="remember-me" v-model="remember" label="Remember Me" dense dark />
                  <q-space />
                  <q-btn id="forgot-pw" label="Forgot Password" no-caps flat dense text-color="white" />
                </div>
              </template>
            </q-input>
          </q-item-section>
        </q-item>
        <q-item v-if="errmsg" class="text-white">
          <q-item-section>
            <q-item-label caption class="text-center text-white">{{ errmsg }}</q-item-label>
          </q-item-section>
        </q-item>
        <q-item class="text-white">
          <q-item-section>
            <q-btn id="login-btn" rounded dense label="Login" no-caps color="blue-8" unelevated @click="EvalLogin" />
          </q-item-section>
        </q-item>
        <q-item class="text-white q-pb-none text-h7">
          <q-item-section class="q-pb-none">
            <q-item-label class="text-center">No account yet?</q-item-label>
          </q-item-section>
        </q-item>
        <q-item class="text-white">
          <q-item-section>
            <q-btn id="login-btn" rounded dense label="Sign Up" no-caps color="blue-8" unelevated @click="EvalLogin" />
          </q-item-section>
        </q-item>
        <q-item class="text-white">
          <q-item-section>
            <q-item-label caption class="text-center text-white">v1.0.1</q-item-label>
          </q-item-section>
        </q-item>
      </q-list>
    </q-card-section>

  </q-card>
</template>

<style lang="scss">
.login-view {
  height: 100vh;
  overflow: auto;

  #remember-me {
    .q-checkbox__label {
      font-size: 1.2em;
      color: white;
    }

    .q-checkbox__bg {
      border-radius: 50%;
    }
  }

  #forgot-pw {
    .q-btn__content {
      span {
        font-size: 0.95em;
      }
    }
  }

  #login-btn{
    font-size: 0.95em;
    font-family: 'gotham_roundedbold';
  }
}
</style>

<script>
import { onMounted, ref, watch } from 'vue'
import { useRouter } from 'vue-router';

export default {
  components: {

  },
  setup() {
    const router = useRouter();
    const remember = ref(false);
    const creds = ref({
      username: null,
      pw: null,
    });
    const errmsg = ref(null);

    watch(remember, (newVal) => {
      window.localStorage.setItem("remember", newVal ? 1 : 0)
    });

    const EvalLogin = () => {
      errmsg.value = null;

      if (!creds.value.username) {
        errmsg.value = "Invalid username (should not be blank)";
        return;
      }

      if (remember.value) {
        window.localStorage.setItem("fgusn", creds.value.username);
      }

      router.push({ name: "Home" })
    }

    onMounted(() => {
      try {
        var x = window.localStorage.getItem("remember");
        var y = window.localStorage.getItem("fgusn");
        if (x === "1" && y) {
          creds.value.username = y;
        }

        remember.value = x === "1";
      } catch { 
        //
      }

    });

    return {
      remember,
      creds,
      errmsg,
      EvalLogin
    }
  },
}
</script>
