<script>
import {http} from '../helper/http.js'
export default{
    data(){
        return{
            animaltypes: {},
            pet_name: '',
            animal_type: '',
            newpet: {
                user_id: '',
                animals_id: '',
                petname: '',
                hunger: 50,
                thirst: 50,
                mood: 50,
                fatigue: 50
            }
        }
    },
    methods:{
        async animals(){
            const response = await http.get('animals');
            this.animaltypes = response.data.data;
        },
        sendAnimal(){
            this.newpet.petname = this.pet_name;
            this.newpet.animals_id = this.animal_type;
            console.log(this.newpet.petname);
            console.log(this.newpet.animals_id);
        },
        onChange(event){
            this.animal_type = event.target.value;
        }
    },
    
    mounted(){
        this.animals();
    }
}

</script>
<template>
    
    <form class="form" @submit.prevent="sendAnimal()">
        <label for="name" class="form-label">Animal name</label>
        <input type="text" name="name" id="name" class="form-control" v-model="this.pet_name">

        <label for="type" class="form-label">Choose an animal type</label>

        <select name="animal" id="type" v-model="this.animal_type" @change="onChange($event)">
            <option  v-for="item in this.animaltypes" :value="item.id">
            {{ item.animaltype }}
            </option>
        </select>
        <button class="btn-warning btn form-control" type="submit">Create</button>
    </form>
</template>
<style scoped>
.form{
    margin: auto;
    margin-top: 50px;
    background-color: rgba(124, 252, 0, 0.6);
    border-radius: 10px;
}
button{
    margin: auto;
}
</style>
