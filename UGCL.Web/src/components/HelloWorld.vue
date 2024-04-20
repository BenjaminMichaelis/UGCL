<template>
  <v-app>
    <v-main>
      <v-container>
        <h1 class="display-2">Underground Garage Cornhole League</h1>
        <p class="subtitle-1">Welcome to the most exciting cornhole league in town!</p>
        <v-btn color="primary" large @click="exploreLeague">Explore the League</v-btn>
      </v-container>
    </v-main>
  </v-app>
</template>

<script>
export default {
  methods: {
    exploreLeague() {
      // Redirect to league details or other relevant pages
      // You can use Vue Router for navigation
    },
  },
};
</script>

<style>
/* Add custom styles here */
</style>
