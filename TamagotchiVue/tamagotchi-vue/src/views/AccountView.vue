<script setup>
import {http} from '../helper/http.js'
async function deleteAcc(){
    const response = await http.delete('delete/' +localStorage.getItem('userid'));
    
}
</script>

<template>
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