<script setup>
import Signup from '../components/Signup.vue'

</script>
<template>
    <div class="container-fluid">
        <Signup />
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