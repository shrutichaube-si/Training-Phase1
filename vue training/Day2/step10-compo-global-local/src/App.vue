<template>
  <div>
    <h1>local and global components</h1>
    <my-global-comp></my-global-comp>
    <my-local-comp></my-local-comp>
  </div>
</template>

<script>
import MyGlobalComp from './components/MyGlobalComp.vue';
//import MyGlobalComp from './components/MyGlobalComp.vue';
import MyLocalComp from './components/MyLocalComp.vue';
export default {
  name: 'App',
  components: {
    MyLocalComp,
    MyGlobalComp
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
