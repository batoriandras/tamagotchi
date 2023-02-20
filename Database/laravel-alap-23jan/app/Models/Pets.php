<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Pets extends Model
{
    protected $table = "pets";
    public function PetsAnimal(){
        return $this->belongsTo(Animals::class, "animals_id", "id");
    }
    public function PetsUser(){
        return $this->belongsTo(User::class,"users_id","id");
    }
}