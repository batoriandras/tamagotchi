<template>
        <label>Days: </label><br>
        <label>Mood level: {{pet.mood}} </label><br>
        <label>Hunger level: {{pet.hunger}} </label><br>
        <label>Thirst level: {{pet.thirst}} </label><br>
        <label>Birth: {{ pet.birth }}</label><br>
</template>
<script>
export default{
props:{
        pet: Object
}
}
</script>