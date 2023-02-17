<template>
   <div class="container-fluid">
        <div class="row">
            <div class="col">

            </div>
        </div>
        <div class="row">
            <div class="col-3 stats">
                
            </div>
            <div class="col-6 petimg">
                <div class="row">
                    <div class="col">
                        <Pet />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <PetAction />
                    </div>
                </div>
            </div>
            <div class="col-3">
                
            </div>
        </div>
    </div>
</template>
<script setup>
import Pet from "../components/Pet.vue"
import PetAction from "../components/PetAction.vue"
</script>
<style scoped>
.col-6, .col-3 {
    background-color: #D89E0A;
    border-radius: 40px;
    color: black;
    text-align: center;
}
</style>