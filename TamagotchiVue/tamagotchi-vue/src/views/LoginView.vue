<script>
import Login from '../components/Login.vue'

export default{
    components:{
        Login
    },
    data(){
return{
    pets: []
}
},
methods:{
    async allpet(){
            const response = await http.get('pets');
            this.pets = response.data.data;
},
mounted(){
this.allpet()
}
}
}
</script>

<template>
    <div class="container-fluid">
        <Login :pets="pets"/>
    </div>
</template>
<style scoped>
.container-fluid {
    width: 800px;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    margin: auto;
    margin-top: 10%;

}
</style>

