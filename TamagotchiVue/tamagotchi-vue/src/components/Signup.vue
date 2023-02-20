<template>
     <div class="row mb-3">
            <div class="col">
                <h2>Register</h2>
            </div>
        </div>
        <div class="row mb-3 p-4">
            <div class="col">
                <form>
                    <label for="username">Username</label><br>
                    <input type="text" name="username" id="username" class="form-control" v-model="newUser.username">

                    <label for="password">Password</label><br>
                    <input type="password" name="password" id="password" class="form-control" v-model="newUser.password">

                    <button class="btn btn-danger" @click="$emit('registerUser',newUser)"> Sign Up</button>
                </form>
            </div>
        </div>
</template>

<script>

export default{
    name: "Signup",
data(){
    return{
        newUser:{
            "username": "",
            "password": "",
            "lastUsedAt": null,
            "createdAt": null,
            "updatedAt": null,
            "pets": []
        }
    }
},
emits:[
        "registerUser"
]
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