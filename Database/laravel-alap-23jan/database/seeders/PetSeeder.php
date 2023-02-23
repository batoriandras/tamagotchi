<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class PetSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('pets')->insert([
            ["users_id"=>1,"animals_id"=>1, "petname" =>"peti", "hunger" =>100,"thirst" =>50,"mood" =>75,"fatigue" =>80,"birth" =>"2015-01-08"]
        ]);
    }
}
