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
import {useRouter} from "vue-router";
const router = useRouter();

    function incMood(){
        
        http.put('editpetstat/' + localStorage.getItem('userid'),
        {
            mood: 10,
            thirst: thirst,
            hunger: hunger,
            fatigue: fatigue
        });
        router.push({name: 'pet'});
    }
    function incThirst(){
        
        http.put('editpetstat/' + localStorage.getItem('userid'),
        {
            thirst: 10
        });
        router.push({name: 'pet'});
    }
    function incHunger(){
        
        http.put('editpetstat/' + localStorage.getItem('userid'),
        {
            hunger: 10
        });
        router.push({name: 'pet'});
    }

</script>
<style scoped>
button{
    background-color: brown;
    padding: 10px;
    color:wheat;
}
</style>
