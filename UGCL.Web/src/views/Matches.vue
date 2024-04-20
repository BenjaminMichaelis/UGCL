<template>
  <v-container style="max-width: 900px">
    <v-card>
      <v-card-title class="d-flex">
        Coalesce Example
        <v-spacer />
      </v-card-title>
    </v-card>
  </v-container>
</template>

<script setup lang="ts">
import { useBindKeyToRouteOnCreate } from "coalesce-vue";

const props = defineProps<{ id?: number }>();

</script>
