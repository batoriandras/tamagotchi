<template>
        <div class="row mb-3">
            <div class="col">
                <h2>Login</h2>
            </div>
        </div>
        <div class="row mb-3 p-4">
            <div class="col">
                <form @submit.prevent="checkUser()">
                    <label for="username">Username</label><br>
                    <input type="text" name="username" id="username" class="form-control" v-model="theUser.username">

                    <label for="password">Password</label> <br>
                    <input type="password" name="password" id="password" class="form-control" v-model="theUser.password">
                    <br>
                    <button class="btn btn-warning" type="submit">Login</button>
                </form>
            </div>
        </div>
        <div class="row mb-3">
                <Router-link class="btn" to="/signup">Sign up</Router-link>
        </div>
</template>
<script>
import {http} from '../helper/http.js'
export default{
    data(){
    return{
        theUser:{
            username: "",
            password: ""
        }
    }
},
methods:{
        async checkUser(){
            const response = await http.get('users');
            response.data.data.forEach(element => {
                if (element.username == this.theUser.username) {
                    this.$router.push({name: 'pet'});
                }
            });
        }
    }
}
</script>
<style scoped>
.row {
    background-color: #D89E0A;
    border-radius: 40px;
    color: black;
    width: 70%;
    text-align: center;
    margin: auto;
}
p{
    margin:auto;
    text-decoration: none;
    color:black;
}

input {
    width: 70%;
    margin: auto;
    border-radius: 40px;
}

label {
    padding: 10px;
    font-size: larger;
}
</style>