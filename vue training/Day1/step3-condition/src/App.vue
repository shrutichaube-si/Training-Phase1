<template>
 <div>
    <h2 v-if="power === '0'">Power is 0</h2>
    <h2 v-if="power === '1'">Power is 1</h2>
    <h2 v-if="power === '2'">Power is 2</h2>
    <h2 v-if="power === '3'">Power is 3</h2>
    <h2 v-if="power === '4'">Power is 4</h2>
    <h2 v-if="power === '5'">Power is 5</h2>
    <span></span>
    <h2 v-if="power <= '5'">Power is less than or equal to 5</h2>
    <h2 v-else>Power now is {{ power }} which is greater than 5</h2>
    <input type="number" step="1" v-model="score" min="-5" max="10">
    <h3 v-if="score < 0 ">You Lost</h3>
    <h3 v-else-if="score <= 0">Lets Start </h3>
    <h3 v-else-if="score <= 4">You Must Try Harder</h3>
    <h3 v-else-if="score === 5">You Can Do It</h3>
    <h3 v-else-if="score <= 9">You Are Almost There</h3>
    <h3 v-else> You Won </h3>
 
    <h2 v-if="power === '5'">Power is now 5</h2>
    <h2 v-show="title === 'Avenger'">You are an Avenger</h2>
 
  </div>
</template>

<script>
 export default {
    data(){
      return {
        title : "Avenger",
        power : "5",
        version : 0,
        score : 4
      }
    },
    components: { }
  }
</script>

<style>
#root {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
