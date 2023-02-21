<template>
        <label  for="">Days: </label><br>
        <label  for="" name="mood">Mood level: {{pet.mood}} </label><br>
        <label  for="" name="hunger">Hunger level: <p>{{pet.hunger}}</p> </label><br>
        <label  for="" name="thirst">Thirst level: <p>{{pet.thirst}}</p> </label><br>
        <label for="">Birth level:</label><br>
</template>
<script>

export default{
props:{
        pet: Object
}
}


</script>