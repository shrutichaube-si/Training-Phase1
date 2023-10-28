<template>
  <div>
    <h1>{{ setTitle() }}</h1>
    <h1>Power  : {{ power }}</h1>
    <button @click="increasePower">Increase Power</button>
    <button @click="decreasePower">Decrease Power</button>
    <button @click="setPower(10)">Set Power to 10</button>
    <br>
     <input ref ="myref" type ="number">
     <button @click ="increasePowerByRef">Increase power</button>
    <input @change="setPowerFromInput($event)" type="number">
  </div>
</template>

<script>


export default {
  data(){
      return {
        title : "Welcome to VUE Training",
        power : 0,
        ntitle: "shruti chaube"
      }
    },
    methods : {
      setTitle(){
        return this.title;
      },
      increasePower : () => {
        alert("hello you clicked to increase")
        // this.power += 1;
      },
      decreasePower : () => {
        this.power -= 1;
      },
      setPower(val){
        this.power = val;
      },
      setPowerFromInput(evt){
        
        this.power = evt.target.value;
        this.title = "power increased"+this.power +"title changed to "+this.ntitle
      }
    },
  
   increasePowerByRef(){
    this.power = this.$refs.myref.value;
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
