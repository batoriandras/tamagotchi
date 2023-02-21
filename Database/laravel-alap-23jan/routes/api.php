<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;
use App\Http\Controllers\PetController;

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

Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
    return $request->user();
});

Route::get('/users', [UserController::class, 'index']);
Route::get('/user/{id}', [UserController::class, 'show']);
Route::post('/newuser', [UserController::class, 'store']);
Route::put('/edituser/{id}', [UserController::class, 'update']);
Route::delete('/delete/{id}', [UserController::class, 'destroy']);

Route::middleware('auth:sanctum')->get('/pet', function (Request $request) {
    return $request->user();
});

Route::get('/pets', [PetController::class, 'index']);
Route::get('/pet/{id}', [PetController::class, 'show']);
Route::post('/newpet', [PetController::class, 'store']);
Route::put('/editpet/{id}', [PetController::class, 'update']);
Route::delete('/delete/{id}', [PetController::class, 'destroy']);