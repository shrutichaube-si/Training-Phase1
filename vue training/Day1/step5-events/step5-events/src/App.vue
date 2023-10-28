<template>
  <div>
    <h1>{{ title }}</h1>
    <button v-on:click="clickHandler">Change Title</button>
    <button @click="clickHandler">Change Title</button>
  </div>
</template>

<script>
export default {
  name: 'App',
  data(){
    return {
      title : "Sportz Interactive"
    }
  },
  methods : {
    clickHandler(){
      this.title = this.title == "Sportz Interactive" ? "New Company" : "Sportz Interactive";
    }
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
