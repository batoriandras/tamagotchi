<script>
import {http} from '../helper/http.js'
import NavBar from "../components/NavBar.vue"
export default{
    components:{
        NavBar,
    },
    data(){
        return{
            user: ''
        }
    },
    methods:{
        async currentUser(){
            const response = await http.get('user/' + localStorage.getItem('userid'),{
                headers: { Authorization: `Bearer ${localStorage.getItem('token')}`}
        });
            this.user = response.data.data.username;
        },
        async deleteAcc(){
            const response = await http.delete('deleteuser/' + localStorage.getItem('userid'),{
                headers: { Authorization: `Bearer ${localStorage.getItem('token')}`}
        });
            this.$router.push({name: 'login'});
        }
    },
    mounted(){
        this.currentUser();
    }

}
</script>

<template>
    <NavBar />
    <div class="container">
        <div class="row">
        <div class="col">
            <h1>Welcome {{ this.user }}</h1>
            <button class="btn btn-danger" @click="deleteAcc()">Delete account</button>
        </div>
    </div>
    </div>
</template>

<style scoped>
div{
    text-align: center;
    margin-top: 20px;
}
</style>