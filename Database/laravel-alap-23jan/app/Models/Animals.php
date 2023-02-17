<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Animals extends Model
{
    protected $table = "animals";
    public function petsanimaltype()
    {
        return $this->hasMany(Pets::class,"animals_id","id");
    }
}
