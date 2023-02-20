<template>
    <div class="container">
        <div class="row">
        <div class="col">
            <h1>Name</h1>
            <button class="btn btn-danger" @click="deleteAcc(id)">Delete account</button>
        </div>
    </div>
    </div>
</template>
<script setup>

async function deleteAcc(id){
    const response = await http.delete('delete/' + id);
}
</script>
<style scoped>
div{
    text-align: center;
    margin-top: 20px;
}
</style>