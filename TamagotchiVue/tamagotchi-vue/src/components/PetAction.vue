<template>
    <div class="row p-3">
        <div class="col"><button class="btn" @click="incrementHunger()">Eat</button></div>
        <div class="col"><button class="btn" @click="incrementThirst()">Drink</button></div>
        <div class="col"><button class="btn" @click="hunt()">Hunt</button></div>
        <div class="col"><button class="btn" @click="incrementMood()">Pet</button></div>
    </div>
</template>
<script>

export default{
    methods:{
        incrementHunger(){
            this.hunger += 20;
        },
        incrementThirst(){
            this.thirst += 20;
        },
        incrementMood(){
            this.mood += 20;
        },
        hunt(){
            for (let index = 0; index < 100; index++) {
                mood+=10;
            }
        }
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
