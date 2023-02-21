<template>
    <NavBar />
<div class="container petcontainer">
    <div class="stat">
        <div class="data"><Petstat :pet="pet" /></div>
        <div class="items"></div>
    </div>
    <div class="pet">
        <Pet />
        <PetAction />
    </div>
</div>
</template>
<script>
import Petstat from "../components/PetStat.vue"
import Pet from "../components/Pet.vue"
import PetAction from "../components/PetAction.vue"
import NavBar from "../components/NavBar.vue"
import {http} from '../helper/http.js'

export default{
    components:{
        Petstat,
        Pet,
        PetAction,
        NavBar
    },
    data(){
return{
    pet: []
}
    },
    
methods:{
        async petStats(){
            const response = await http.get('pet/1');
            this.pet = response.data.data;
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