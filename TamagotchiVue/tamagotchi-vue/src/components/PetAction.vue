<template>
    <div class="row p-3">
        <div class="col"><button class="btn" @click="editHunger()">Eat</button></div>
        <div class="col"><button class="btn" @click="editThirst()">Drink</button></div>
        <div class="col"><button class="btn" @click="huntMood()">Hunt</button></div>
        <div class="col"><button class="btn" @click="editMood()">Pet</button></div>
    </div>
</template>
<script>
import { http } from '../helper/http'
import moment from 'moment'
import { VueElement } from 'vue';
export default{
    data(){
        return{
            pet: {},
            obj: {},
            date: new Date()
        }
    },
    methods:{
        async petStats(){
            const response = await http.get('pet/'+localStorage.getItem('userid'));
            this.pet = response.data.data;
            
        },
        async editHunger(){
            this.obj = {
                hunger: this.pet.hunger + 20,
                thirst: this.pet.thirst,
                mood: this.pet.mood,
                fatigue: this.pet.fatigue
            }
            const response = await http.put('editpetstat/'+localStorage.getItem('userid'), this.obj);
            window.location.reload();
        },
        async editThirst(){
            this.obj = {
                hunger: this.pet.hunger,
                thirst: this.pet.thirst + 20,
                mood: this.pet.mood,
                fatigue: this.pet.fatigue
            }
            const response = await http.put('editpetstat/'+localStorage.getItem('userid'), this.obj);
            window.location.reload();
        },
        async editMood(){
            this.obj = {
                hunger: this.pet.hunger,
                thirst: this.pet.thirst,
                mood: this.pet.mood + 20,
                fatigue: this.pet.fatigue
            }
            const response = await http.put('editpetstat/'+localStorage.getItem('userid'), this.obj);
            window.location.reload();
        },
        async huntMood(){
            this.obj = {
                hunger: this.pet.hunger,
                thirst: this.pet.thirst,
                mood: this.pet.mood + 60,
                fatigue: this.pet.fatigue
            }
            const response = await http.put('editpetstat/'+localStorage.getItem('userid'), this.obj);
            window.location.reload();
        }
    },
    mounted(){
        this.petStats();
    }
}




</script>
<style scoped>
button{
    background-color: brown;
    padding: 10px;
    color:wheat;
}
</style>
