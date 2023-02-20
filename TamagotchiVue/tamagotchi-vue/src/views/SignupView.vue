<script>
import Signup from '../components/Signup.vue'
import axios from axios;

export default{
    components:{
        Signup
    },
    data(){
        return {
            users: []
        }
    },
    methods:{
        async registerUser(newUser){
            const response = await axios.post('https://localhost:5001/api/User', newUser);
            this.users.push(response.data);
        }
    },
    props:{
        users: Array
    },
    emits:[
        "registerUser"
    ],
}

</script>
<template>
    <div class="container-fluid">
        <Signup @register-user="(newUser) => $emit('registerUser',newUser)"/>
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
<style>
body {
    backdrop-filter: blur(3px);
    background-image: url(/login-bg.jpg);
    background-size: cover;
    background-repeat: no-repeat;
}
</style>