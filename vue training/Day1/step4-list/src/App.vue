<template>
 <div>
  <h1>{{ title }}</h1>
  <ul>
    <li v-for="avenger in avengers" :key="avenger">{{ avenger }}</li>
  </ul>
  <ul>
    <li v-for="(avenger, index) in avengers" :key="index">{{ avenger }}</li>
  </ul>
  <ol>
    <li v-for="({title, firstname, lastname}, index) in names" :key="index">{{ title }} {{ firstname }} {{ lastname }}</li>
  </ol>
 
    
  <div v-for="(lavenger, index) in ladyAvengers" :key="index">
        <h4>{{(index+1) +". Title "+ lavenger.title }}</h4>
        <span v-if="lavenger?.firstname.length > 0"> Full Name :  {{ lavenger?.firstname+" "+lavenger?.lastname }}</span>
        <article style=" background-color: silver; padding : 10px; width : 300px; margin : auto ">
          <ol v-for="(movie, index) in lavenger.movies" :key="index">{{ movie.title  }}</ol>
        </article>
      </div>
      
 </div>

</template>

<script>


export default {
  name: 'App',
  data(){
      return {
        title: "Welcome to VUE Training",
        avengers: ['Black Widow', 'Scarlet Witch', 'Shuri', 'Wasp', 'Captain Marvel', 'Gamora'],
        names: [
          { title: 'Wasp', firstname: "Janet", lastname: 'Van Dyne' },
          { title: 'Scarlet Witch', firstname: "Wanda", lastname: 'Maximoff' },
          { title: 'Black Widow', firstname: "Natasha", lastname: 'Romanoff' },
          { title: 'Captain Marvel', firstname: "Carol", lastname: 'Danvers' },
        ],
        project : {
          apptitle : "Avengers App",
          author : "Vijay",
          version : 101,
          year  :2023
        },
        ladyAvengers: [
          {
            "title": "Wasp",
            "firstname": "Janet",
            "lastname": "Van Dyne",
            "movies": [
              { "title": "Ant-Man", "year": 2015 },
              { "title": "Ant‑Man and the Wasp", "year": 2018 },
              { "title": "Avengers: Endgame", "year": 2019 }
            ]
          },
          {
            "title": "Scarlet Witch",
            "firstname": "Wanda",
            "lastname": "Maximoff",
            "movies": [
              { "title": "Captain America: The Winter Soldier", "year": 2014 },
              { "title": "Avengers: Age of Ultron", "year": 2015 },
              { "title": "Captain America: Civil War", "year": 2016 },
              { "title": "Avengers: Infinity War", "year": 2018 },
              { "title": "Avengers: Endgame", "year": 2019 },
              { "title": "Doctor Strange in the Multiverse of Madness", "year": 2022 }
            ]
          },
          {
            "title": "Black Widow",
            "firstname": "Natasha",
            "lastname": "Romanoff",
            "movies": [
              { "title": "Iron Man 2", "year": 2010 },
              { "title": "Avengers", "year": 2012 },
              { "title": "Captain America: The Winter Soldier", "year": 2014 },
              { "title": "Avengers: Age of Ultron", "year": 2015 },
              { "title": "Captain America: Civil War", "year": 2016 },
              { "title": "Avengers: Infinity War", "year": 2018 },
              { "title": "Avengers: Endgame", "year": 2019 }
            ]
          },
          {
            "title": "Captain Marvel",
            "firstname": "Carol",
            "lastname": "Danvers",
            "movies": [
              { "title": "Captain Marvel", "year": 2019 },
              { "title": "Avengers: Endgame", "year": 2019 }
            ]
          },
          {
            "title": "Gamora",
            "firstname": "",
            "lastname": "",
            "movies": [
              { "title": "Guardians of the Galaxy", "year": 2014 },
              { "title": "Guardians of the Galaxy Vol. 2", "year": 2017 },
              { "title": "Avengers: Infinity War", "year": 2018 },
              { "title": "Avengers: Endgame", "year": 2019 }
            ]
          },
          {
            "title": "Shuri",
            "firstname": "Shuri",
            "lastname": "Princess",
            "movies": [
              { "title": "Black Panther", "year": 2018 },
              { "title": "Avengers: Infinity War", "year": 2018 },
              { "title": "Avengers: Endgame", "year": 2019 },
              { "title": "Black Panther: Wakanda Forever", "year": 2022 }
            ]
          }
]
        }
}
}
</script>

<style>
#root {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  color: #2c3e50;
}
</style>
