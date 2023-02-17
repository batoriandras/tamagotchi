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
                    <input type="text" name="username" id="username" class="form-control">

                    <label for="pwd">Password</label><br>
                    <input type="password" name="pwd" id="pwd" class="form-control">

                    <label for="pwd">Password again</label><br>
                    <input type="password" name="pwd" id="pwd" class="form-control">
                    <br>
                    <input class="btn btn-light w-50" type="submit" value="Sign up">
                </form>
            </div>
        </div>
</template>

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