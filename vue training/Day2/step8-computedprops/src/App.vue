<template>
  <div>
    <!-- Using computed properties for combining data values -->
    <h3>Using computed properties</h3>
    <h2>{{ fullName }}</h2>

    <h3>Using computed properties</h3>
    <h2>Total Power: {{ totalPower }}</h2>
     <h2>Heroes with Power Greater then 5:</h2>
    <ul>
      <li v-for="hero in powerfulHeroes" :key="hero.title">
        {{ hero.title }} - Power: {{ hero.power }}
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Welcome to VUE Training",
      firstname: "Bruce",
      lastname: "Wayne",
      version: 0,
      avengers: [
        { title: "Ironman", power: 7 },
        { title: "Antman", power: 6 },
        { title: "Thor", power: 4 },
        { title: "Hulk", power: 9 },
        { title: "Captain America", power: 8 }
      ]
    };
  },
  computed: {
    fullName() {
      return this.firstname + " " + this.lastname;
    },
    totalPower() {
      return this.avengers.reduce((total, hero) => total + hero.power, 0);
    },
      powerfulHeroes() {
      return this.avengers.filter(hero => hero.power > 5);
    }
  }
};
</script>

<style>
#app {
  font-family: sans-serif;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>