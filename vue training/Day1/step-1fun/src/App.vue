<template>
  <div>
  <h1>
  hello from app component
  </h1>
  <HeaderComp/>
  <FooterComp/>
<MainComp>
  <ArticleComp/>
    <ArticleComp/>
    <ArticleComp/>
</MainComp>
  
    </div>
</template>
<script>
import HeaderComp from './components/HeaderComp.vue';
import FooterComp from './components/FooterComp.vue';
import ArticleComp from './components/ArticleComp.vue';
import MainComp from './components/MainComp.vue';

export default{
  components:{
    HeaderComp,
    FooterComp,
    ArticleComp,
    MainComp
}
}
</script>
<style>

</style>
