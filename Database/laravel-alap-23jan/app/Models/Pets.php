<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Pets extends Model
{
    protected $table = "pets";
    public function PetsAnimals(){
        return $this->belongsTo(Animals::class,"id","animals_id");
    }
    public function PetsUsers(){
        return $this->belongsTo(UserModel::class,"id","UsersData_id");
    }
}
