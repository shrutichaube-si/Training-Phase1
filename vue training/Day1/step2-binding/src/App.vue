<template>
 <div class="box">
  <h1>Bindind in VUE</h1>
  <h2>{{ title }}</h2>
  <h2 v-bind:innerHtml="title"></h2>
  <div v-html="linkTag"></div>
  <h2 v-bind:innerHTML="title"></h2>
  <section v-bind:class="selectedClass">
      i am a section
    </section>
    <article v-bind:id="selectedId">
      i am an article
    </article>
    <button v-bind:disabled="show">Click Me</button>
    <br>
    <input v-model="show" type="checkbox">
    <br>
    <input v-model="title" type="text">
    <br>
    <fieldset v-bind:hidden="show">
      <legend>Terms and Conditions</legend>
      <p>
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Commodi quam quod adipisci repellat. Officia aut facere, impedit, quisquam sint, repellendus dolorum ratione unde quam perferendis saepe eum odio perspiciatis earum.
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Excepturi cumque voluptatem accusamus dignissimos quo, deserunt laudantium tempora tenetur modi adipisci minima nam optio numquam impedit provident possimus facere culpa laboriosam?
      </p>
    </fieldset>
 </div>
</template>

<script>
export default {
  name: 'App',
 data(){
  return {
    title: "sportz interactive",
    linkTag : "<li><a href='https://google.com'>New Name </a></li>",
    show : true,
    selectedClass : 'box',
    selectedId : 'player'
  }
 }
}
</script>

<style>
#root {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  text-align: center;
  color: #2c3e50;
}
/* .box{
  width: 200px;
  height: 100px;
  background-color: crimson;
  text-align: center;
  font-family: sans-serif;
  color: papayawhip;
} */
#player{
  width: 100px;
  height: 100px;
  margin: auto;
  background-color: rgb(32, 252, 211);
  text-align: center;
  font-family: sans-serif;
  color: rgb(38, 12, 91);
}
</style>
