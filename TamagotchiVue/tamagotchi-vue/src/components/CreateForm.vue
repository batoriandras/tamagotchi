<script>
import {http} from '../helper/http.js'
export default{
    data(){
        return{
            type: {}
        } 
    },
    methods:{
        async types(){
            const response = await http.get('animals');
            this.type = response.data.data;
        }
    }
}

</script>
<template>
    <form action="">
        <h1>Create your animal</h1>
        <label for="name">Animal name</label>
        <br>
        <input type="text" name="name" id="" placeholder="Animal name">
<br>

        <label for="type">Animal</label>
        <div v-for="item in type">
            <label for="animal">
                {{ item.animaltype }}
            </label>
            <input type="radio" name="animal" id="{{ item.id }}">
        </div>
        
    </form>
</template>
