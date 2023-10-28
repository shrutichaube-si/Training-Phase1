<template>
    <div class="box">
      <h1>Title : {{ title }}</h1>
      <h1>Power : {{ power }}</h1>
      <h1>canWalk : {{ canWalk }}</h1>
    </div>
  </template>
   
  <script>
  export default {
    name: 'ChildComp',
    props: {
      title: {
        type : String,
        required : true,
        default : "default message"
      },
      power : {
        type : Number,
        require : true,
        default : 1
      },
      canWalk : {
        type : Boolean,
        require : true,
        default : false
      }
    }
  }
  </script>
   
  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  .box{
    width : 400px;
    height: 200px;
    text-align: center;
    color: rgb(29, 29, 29);
    background-color: rgb(211, 211, 211);
  }
  </style>
  