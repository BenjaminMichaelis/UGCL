<template>
  <v-app>
    <v-main>
      <v-container>
        <!-- Hero Section -->
        <v-row align="center" justify="center">
          <v-col cols="12" md="8" class="text-center">
            <h1 class="display-2 mb-4">Underground Garage Cornhole League</h1>
            <p class="subtitle-1 mb-6">Welcome to the most exciting cornhole league in town!</p>
            <v-btn color="primary" large @click="exploreLeague">Explore the League</v-btn>
          </v-col>
        </v-row>

        <!-- Featured Players Section -->
        <v-row class="my-10">
          <v-col cols="12">
            <h2 class="headline mb-4">Featured Players</h2>
            <v-carousel>
              <v-carousel-item v-for="(player, index) in featuredPlayers" :key="index">
                <v-card>
                  <v-img :src="player.avatar" alt="Player Photo"></v-img>
                  <v-card-title>{{ player.name }}</v-card-title>
                </v-card>
              </v-carousel-item>
            </v-carousel>
          </v-col>
        </v-row>

        <!-- Upcoming Events Section -->
        <v-row class="my-10">
          <v-col cols="12">
            <h2 class="headline mb-4">Upcoming Events</h2>
            <v-timeline>
              <v-timeline-item v-for="(event, index) in upcomingEvents" :key="index">
                <v-card>
                  <v-card-title>{{ event.title }}</v-card-title>
                  <v-card-subtitle>{{ event.date }}</v-card-subtitle>
                  <v-card-text>{{ event.description }}</v-card-text>
                </v-card>
              </v-timeline-item>
            </v-timeline>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-app>
</template>

<script>
export default {
  data() {
    return {
      featuredPlayers: [
        { name: 'Alice Johnson', avatar: '/assets/alice.jpg' },
        { name: 'Bob Smith', avatar: '/assets/bob.jpg' },
        // Add more players here
      ],
      upcomingEvents: [
        { title: 'Cornhole Championship', date: 'May 15, 2024', description: 'Join us for the ultimate showdown!' },
        { title: 'Garage Throwdown', date: 'June 5, 2024', description: 'Get ready to toss those bags!' },
        // Add more events here
      ],
    };
  },
  methods: {
    exploreLeague() {
      // Redirect to league details or other relevant pages
      // You can use Vue Router for navigation
    },
  },
};
</script>

<style scoped>
/* Add custom styles here */
</style>
