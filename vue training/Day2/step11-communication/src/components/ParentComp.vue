<template>
    <div>
      <!-- if you use :propName then we can evaluate the expression for a data type -->
      <ChildComp title="Child 1" :power="5" :canWalk="true"/>
      <ChildComp title="Child 2" :power="6" :canWalk="true"/>
      <ChildComp title="Child 3" :power="7" :canWalk="true"/>
      <ChildComp :title="'Child 4'"  :canWalk="true"/>
      <ChildComp  :power="7" :canWalk="true"/>
      <ChildComp   />
    </div>
  </template>
   
  <script>
  import ChildComp from './components/ChildComp.vue'
   
  export default {
    name: 'App',
    components: {
      ChildComp
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
  