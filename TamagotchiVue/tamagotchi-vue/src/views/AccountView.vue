<script setup>
import {http} from '../helper/http.js'
import NavBar from "../components/NavBar.vue"
import router from '../router';
async function deleteAcc(){
    const response = await http.delete('deleteuser/' + localStorage.getItem('userid'));
    this.router.push({name: 'login'});
}
</script>

<template>
    <NavBar />
    <div class="container">
        <div class="row">
        <div class="col">
            <h1>Name</h1>
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