<template>
 <div>
    <!-- without modifiers -->
    <input type="range" v-model="power">
    <input type="range" v-model="booster">
    Power is : {{ power }}
    Booster is : {{ booster }}
    Power + Booster is {{ power + booster }} 
    <!-- with modifiers -->
    
    <!-- modifiers can be chained too -->
    <hr>
     <div>{{ title }}</div>
    <input type="text" v-model.trim="title">
    <br>
    <input type="range" v-model.number="power">
    <br>
    <input type="range" v-model.lazy.number="power">
    <br>
    <input type="range" v-model.number="booster">
    <br>
    <span v-once> v-once I wont display updated power{{ power }}</span>
    <br>
    <span v-pre> Power can be used as {{ power }}</span>
    Power is : {{ power }}
    Booster is : {{ booster }}
    Power + Booster is {{ power + booster }}
  </div>
</template>

<script>
export default {
    data(){
      return {
        title : "Welcome to VUE Training",
        nhero : '',
        power : '5',
        booster : '0'
      }
    },
    components: { }
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
