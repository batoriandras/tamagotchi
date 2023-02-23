<script setup>
import {http} from '../helper/http.js'
import CreateFormVue from '../components/CreateForm.vue';
import NavBar from "../components/NavBar.vue"
async function deleteAcc(){
    const response = await http.delete('delete/' +localStorage.getItem('userid'));
    
}
</script>

<template>
    <NavBar />
    <div class="container">
        <div class="row">
        <div class="col">
            <h1>Name</h1>
            <CreateFormVue />
            <button class="btn btn-danger" @click="deleteAcc()">Delete account</button>
        </div>
    </div>
    </div>
</template>

<style scoped>
div{
    text-align: center;
    margin-top: 20px;
}
</style>