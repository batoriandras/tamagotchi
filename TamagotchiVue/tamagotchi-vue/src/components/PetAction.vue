<template>
    <div class="row p-3">
        <div class="col"><button class="btn" @click="incHunger()">Eat</button></div>
        <div class="col"><button class="btn" @click="incThirst()">Drink</button></div>
        <div class="col"><button class="btn" @click="incMood()">Hunt</button></div>
        <div class="col"><button class="btn" @click="incMood()">Pet</button></div>
    </div>
</template>
<script setup>
import { http } from '../helper/http';

    function incMood(){
        let mood = 100;
        http.put('/editpetstat/' + localStorage.getItem('userid'),{
            mood: mood
        }).then(() => {this.$router.push({name: 'pet'})});
    }
    function incThirst(){
        let thirst = 100;
        http.put('/editpetstat/' + localStorage.getItem('userid'),{
            thirst: thirst
        }).then(() => {this.$router.push({name: 'pet'})});
    }
    function incHunger(){
        let hunger = 100;
        http.put('/editpetstat/' + localStorage.getItem('userid'),{
            hunger: hunger
        }).then(() => {this.$router.push({name: 'pet'})});
    }

</script>
<style scoped>
button{
    background-color: brown;
    padding: 10px;
    color:wheat;
}
</style>
