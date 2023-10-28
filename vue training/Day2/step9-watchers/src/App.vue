<template>
  <div>
    <!-- step 1 start -->
    <h3>Power is {{ power }}</h3>
    <h3>{{ message }}</h3>
    <input type="number" v-model="power">
    <!-- step 1 end -->
 
    <!-- step 2 start -->
    <!-- 
      watches are functions with the same name as properties on data object and will be called when that property is mutated
      watchers by default do not run immediately when the application is loaded
      but you can configure them to do so using immediate and handler
      both handler and immediate is reserved key words
      deep allows us to watch for deep nested object properties and arrays changes / mutates
    -->
    <!-- step 2 end -->
 
    <!-- step 3 deep start -->
    <hr>
    <input type="text" @keypress.enter="avengers.push($event.target.value)">
    <ol>
      <li v-for="hero in avengers" v-bind:key="hero"> {{ hero }}</li>
    </ol>
    <!-- step 3 end -->
  </div>
</template>
 
<script>
  export default {
    data(){
      return {
        title : "Welcome to VUE Training",
        power : 1,
        message : "Hero is not ready to fight",
        avengers : ["Ironman"]
      }
    },
    computed : {},
    watch : {
      power(npower){
        console.log("Power was changed to ", npower)
        if(npower >= 5) this.message = "Hero is now ready to fight";
        if(npower >= 10) {this.message = "power can not be more than 10"; this.power = 10;}
      }
      /* power(npower, opower){
        console.log("Power was changed to ", npower, "From ", opower)
        if(npower >= 5) this.message = "Hero is now ready to fight";
        if(npower >= 10) {this.message = "power can not be more than 10"; this.power = 10;}
      }  */
      /*  
      power : {
        handler( npower ){
          console.log("Power was changed to ", npower)
          if(npower >= 5) this.message = "Hero is now ready to fight";
          if(npower >= 10) {this.message = "power can not be more than 10"; this.power = 10;}
          
        },
        immediate : true,
        deep : true // allows us to watch for deep nested object properties and arrays changes / mutates
      }
      */
      ,
      avengers : {
        handler(oldlist, newlist){
          console.log("avengers is updated",oldlist, newlist);
        },
        immediate : true,
        // deep : true
      }
    },
    components: { }
  }
</script>
 
<style>
#app {
  font-family: sans-serif;
  color: #2c3e50;
  margin-top: 60px;
}
</style>