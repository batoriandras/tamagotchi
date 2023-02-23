<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;
use App\Http\Controllers\PetController;
use App\Http\Controllers\AnimalController;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/
Route::post('/login', [UserController::class, 'authenticate']);
Route::get('/logout', [UserController::class, 'logout']);

Route::middleware('auth:sanctum')->group(function () {
    Route::get('/users', [UserController::class, 'index']);
    Route::get('/user/{id}', [UserController::class, 'show']);
    Route::post('/newuser', [UserController::class, 'store']);
    Route::put('/edituser/{id}', [UserController::class, 'update']);
    Route::delete('/deleteuser/{id}', [UserController::class, 'destroy']);
});

Route::middleware('auth:sanctum')->group(function () {
    Route::get('/pets', [PetController::class, 'index']);
    Route::get('/pet/{id}', [PetController::class, 'show']);
    Route::post('/newpet', [PetController::class, 'store']);
    Route::put('/editpet/{id}', [PetController::class, 'update']);
    Route::put('/editpetstat/{id}', [PetController::class, 'updateStat']);
    Route::delete('/deletepet/{id}', [PetController::class, 'destroy']);
});

Route::middleware('auth:sanctum')->group(function () {
    Route::get('/animals', [AnimalController::class, 'index']);
    Route::get('/animal/{id}', [AnimalController::class, 'show']);
    Route::post('/newanimal', [AnimalController::class, 'store']);
});
