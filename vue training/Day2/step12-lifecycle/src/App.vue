<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
  </div>
</template>
 
<script>
export default {
  name: 'HelloWorld',
    beforeCreate(){
      console.log("Component's beforeCreate was called");
    },
    created(){
      console.log("Component's created was called");     
    },

    beforeMount(){
      console.log("Component's beforeMount was called");     
    },
    mounted(){
      console.log("Component's mounted was called");      
    },
    beforeUpdate(){
      console.log("Component's beforeUpdate was called");     
    },
    update(){
      console.log("Component's beforeUpdate was called");     
    },
    beforeUnmount(){
      console.log("Component's beforeUnmount was called");      
    },
    unmount(){
      console.log("Component's unmount was called");
    },
  props: {
    msg: String
  }
}
</script>
 
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>