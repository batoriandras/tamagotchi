<template>
    <Error :error="error" v-if="error!=null"/>
<div class="container petcontainer">
    <div class="stat">
        <div class="data"><Petstat :pet="pet" /></div>
        <div class="items"></div>
    </div>
    <div class="pet">
        <Pet :animal="animal"/>
        <PetAction />
    </div>
</div>
</template>
<script>
import Petstat from "../components/PetStat.vue"
import Error from "../components/Error.vue"
import Pet from "../components/Pet.vue"
import PetAction from "../components/PetAction.vue"
import {http} from '../helper/http.js'
import { handleError } from "vue"

export default{
    components:{
        Petstat,
        Pet,
        PetAction,
        Error
    },
    data(){
return{
    pet: {},
    error: null,
    animal:{}
}
},
    
methods:{
        async petStats(){
            const response = await http.get('pet/'+localStorage.getItem('userid')).catch(handleError);
            this.pet = response.data.data;
            this.Animaldata()
        },
        handleError(error){
            this.error = error.response.data;
        },
        async Animaldata(){
            const response = await http.get('animal/'+this.pet.animals_id).catch(handleError);
            this.animal = response.data.data;
        }
},
mounted(){
    this.petStats()
}
}

</script>
<style scoped>
.data{
    background-color:rgb(216, 158, 10);
    margin-top: 20px;
    border-radius: 40px;
    padding: 20px;
    color: black;
    text-align: center;
}
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
    margin-top: 20px;
    border-radius: 40px;
    padding: 20px;
    color: black;
}

</style>