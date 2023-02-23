<template>
    <NavBar />
    <div class="alert alert-info" v-if="isloading" role="alert">
  Loading...
</div>
<div class="container petcontainer" v-if="!isloading">
    <div class="stat">
        <Petstat :pet="pet" />
    </div>
    <div class="pet">
        <Pet :animal="animal"/>
        <PetAction/>
    </div>
</div>
</template>
<script>
import Petstat from "../components/PetStat.vue"
import Pet from "../components/Pet.vue"
import PetAction from "../components/PetAction.vue"
import {http} from '../helper/http.js'
import NavBar from "../components/NavBar.vue"

export default{
    components:{
        NavBar,
        Petstat,
        Pet,
        PetAction
    },
    data(){
return{
    pet: {},
    animal:{},
    isloading: true
}
},
    
methods:{
        async petStats(){
            const response = await http.get('pet/'+localStorage.getItem('petid'));
            this.pet = response.data.data;
            this.Animaldata()
        },
        async Animaldata(){
            const response = await http.get('animal/'+this.pet.animals_id);
            this.animal = response.data.data;
            this.isloading = false;
        }
},
mounted(){
    this.petStats()
}
}

</script>
<style scoped>
.items{
    background-color:rgb(216, 158, 10);
    margin-top: 20px;
    border-radius: 40px;
    padding: 20px;
    color: black;
    text-align: center;
    height: 65%;
}
.pet{
    background-color: rgba(216, 158, 10, 70%);
    margin-top: 20px;
    border-radius: 40px;
    padding: 20px;
    color: black;
    text-align: center;
}
.stat{
    background-color: rgba(216, 158, 10, 70%);
    margin: auto;
    margin-top: 20px;
    border-radius: 40px;
    padding: 20px;
    color: black;
}

</style>